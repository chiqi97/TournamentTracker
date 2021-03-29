using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();



        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();
            

            tournament = tournamentModel;

            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;

            WireUpLists();


            LoadFormData();

            LoadRounds();

        }

        private void Tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;

            //roundDropDown.DataSource = tournament.Rounds;
            //roundDropDown.DisplayMember = "Rounds";

            //matchupListBox.DataSource = tournament;
            //matchupListBox.DisplayMember=""
        }

        private void LoadRounds()
        {
            //rounds = new BindingList<int>();
            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            LoadMatchups(1);
           // roundsBinding.ResetBindings(false);
            //WireUpListsRounds();

        }



        private void WireUpLists()
        {
            // matchupListBox.DataSource = null;
            roundDropDown.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {



            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if(round == matchups.First().MatchupRound)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckbox.Checked)
                        {
                            selectedMatchups.Add(m); 
                        }
                    }


                }


            }
            if (selectedMatchups.Count >0)
            {
                LoadMatchup(selectedMatchups.First());
            }


            DisplayMatchupInfo();
            // matchupsBinding.ResetBindings(false);
            // WireUpListsMatchups();

        }

        private void DisplayMatchupInfo()
        {

            bool isVisible = (selectedMatchups.Count > 0);

                teamOneName.Visible = isVisible;
                teamOneScoreValue.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;

            scoreButton.Visible = isVisible;
            versusLabel.Visible = isVisible;

            teamTwoName.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreValue.Visible = isVisible;



        }
        private void LoadMatchup(MatchupModel m)
        {


            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting!=null )
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        teamTwoName.Text = "<bye>";
                        teamTwoScoreValue.Text = "0";
                    }
                    else
                    {
                        teamOneName.Text = "Not set yet";
                        teamOneScoreValue.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoName.Text = "Not set yet";
                        teamTwoScoreValue.Text = "";
                    }
                }
            }

        }
        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((MatchupModel)matchupListBox.SelectedItem != null)
            {
                LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
            }



        }

        private void tournamentName_Click(object sender, EventArgs e)
        {

        }

        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length>0)
            {
                MessageBox.Show($"Input Error: {errorMessage}");
                return;
            }

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {


                        bool scoreValid = double.TryParse(teamOneScoreValue.Text,out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore; 
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1");
                            return;
                        }


                    }

                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {


                        bool scoreValid = double.TryParse(teamTwoScoreValue.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2");
                            return;
                        }
                    }

                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had the following error:{ex.Message}");
                return;

            }
            LoadMatchups((int)roundDropDown.SelectedItem);

        }

        private string ValidateData()
        {
            double score1Value=0;
            double score2Value = 0;

            string output = "";

            
            bool teamOneBool = double.TryParse(teamOneScoreValue.Text, out score1Value);
            bool teamTwoBool= double.TryParse(teamTwoScoreValue.Text, out score2Value);

            if(!teamOneBool)
            {
                output = $"The score one value is not a valid number: \"{teamOneScoreValue.Text}\"";

            }


            if (!teamTwoBool)
            {

                output = $"The score two value is not a valid number: \"{teamTwoScoreValue.Text}\"";

                if (!teamOneBool)
                {
                    output += $"\nThe score one value is not a valid number: \"{teamOneScoreValue.Text}\"";
                }
            }

            if ((score1Value == score2Value) && teamTwoBool && teamOneBool)
            {
                output = "We dont allow ties in the application";
            }

            if (score1Value == 0 && score2Value==0 && teamTwoBool && teamOneBool)
            {
                output = "You didnt enter a score for either team.";
            }




            return output;


        }
    }
}
