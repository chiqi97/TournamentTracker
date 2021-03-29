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
    public partial class CreateTeamForm : Form
    {
        //przypisz do listy wszystkich dostepnych osobnikow z bazy
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All(); 
        //
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();
            callingForm = caller;
            WireUpLists();
        }


        /// <summary>
        /// Testy
        /// </summary>
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tom", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Jones" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Ane", LastName = "Jhin" });
        }

        /// <summary>
        /// metoda, ktora wyswietla dane w listboxie i  dropboxie, odswieza dane
        /// </summary>
        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers; // dane z listy available..
            selectTeamMemberDropDown.DisplayMember = "FullName"; // drukuj imie i nazwisko

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers; // dane z listy selected
            teamMembersListBox.DisplayMember = "FullName";
        }

        


        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();


                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }



            else 
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }
        /// <summary>
        /// Sprawdzenie czy dane wpisane spelniaja zalozenia, czy nie sa puste
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output=true;

            if (firstNameValue.Text.Length ==0)
            {
                output = false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                output = false;
            }
            if (emailValue.Text.Length == 0)
            {
                output = false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                output = false;
            }

            return output;

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // tworze obiekt person model p  i przypisuje do niego wartosc wybrana z listy
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            if (p != null)
            {

                // usuwam obiekt z listy
                availableTeamMembers.Remove(p);
                // dodaje obiekt do lisboxa
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }
        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if(p != null)
            {
                selectedTeamMembers.Remove(p);

                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            
            t.TeamName = teamNameValue.Text;
            //write team members from list <PErsonModel> selected TeamMembers
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);


            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
