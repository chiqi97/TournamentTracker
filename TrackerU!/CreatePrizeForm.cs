﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerU_;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;

        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createTeamLabel_Click(object sender, EventArgs e)
        {

        }
  
        
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);
                
                 GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();




                //placeNameValue.Text="";
                //placeNumberValue.Text="";
                //prizeAmountValue.Text="0";
                //prizePercentageValue.Text="0";
            }
           else
            {
                MessageBox.Show("This form has invalid information. Please chek it and try again.");
            }
       
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValid)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if(placeNameValue.Text.Length ==0)
            {

                output = false;
            }
            decimal prizeAmount;
           double prizePercentage;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if(prizeAmount <=0 && prizePercentage <= 0)
            {
                output = false;
            }
            if(prizePercentage<0 || prizePercentage > 100)
            {
                output = false;

            }
            return output;

        }

        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
