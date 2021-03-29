using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerU_;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            InitializeLists();
        }
        
        private void InitializeLists()
        {
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";


            tournamentTeamsListBox.DataSource = selectedTeams; // dane z listy selected
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);

                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;

            selectTeamDropDown.DataSource = availableTeams; // dane z listy available..
            selectTeamDropDown.DisplayMember = "TeamName"; // drukuj imie i nazwisko

            tournamentTeamsListBox.DataSource = null;

            tournamentTeamsListBox.DataSource = selectedTeams; // dane z listy selected
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void deleteSelectedTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);

                availableTeams.Add(t);

                WireUpLists();
            }

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
            // Get back from the form a PrizeModel
            // Take the PrizeModel and put it into our list selected prizes
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a PrizeModel
            // Take the PrizeModel and put it into our list selected prizes
            selectedPrizes.Add(model);
            WireUpLists();

        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //Validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee",
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //Create our tournament Model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;
            // tm.prizes i tm.EnteredTeams to listy tm.Prizes=selectedPrizes=List<PrizeModel>
            //tm.EnteredTeams=selectedTeams=List<TeamModel>;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - Wire our matchups
            TournamentLogic.CreateRounds(tm);


            // Create Tornament Entry
            // Create all of the prizes entries
            // Create all of the team entries
            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();



            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();

        }

        private void deleteSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel model = (PrizeModel)prizesListBox.SelectedItem;
            if (model != null)
            {
                selectedPrizes.Remove(model);

                WireUpLists();
            }

        }
    }
}
