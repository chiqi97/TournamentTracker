
namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizesButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(12, 122);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(334, 35);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(148, 181);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.entryFeeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 179);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(199, 240);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 82);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.headerLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(334, 50);
            this.headerLabel.TabIndex = 16;
            this.headerLabel.Text = "Create Tournament";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(13, 289);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(333, 38);
            this.selectTeamDropDown.TabIndex = 18;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 233);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 17;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.addTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addTeamButton.Location = new System.Drawing.Point(137, 355);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(151, 46);
            this.addTeamButton.TabIndex = 19;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.createPrizeButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(137, 420);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(151, 46);
            this.createPrizeButton.TabIndex = 20;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 30;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(386, 82);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(379, 152);
            this.tournamentTeamsListBox.TabIndex = 21;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.tournamentPlayersLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(386, 32);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(184, 37);
            this.tournamentPlayersLabel.TabIndex = 22;
            this.tournamentPlayersLabel.Text = "Teams/Players";
            // 
            // deleteSelectedTeamButton
            // 
            this.deleteSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteSelectedTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.deleteSelectedTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedTeamButton.Location = new System.Drawing.Point(654, 23);
            this.deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            this.deleteSelectedTeamButton.Size = new System.Drawing.Size(111, 46);
            this.deleteSelectedTeamButton.TabIndex = 23;
            this.deleteSelectedTeamButton.Text = "Delete";
            this.deleteSelectedTeamButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTeamButton.Click += new System.EventHandler(this.deleteSelectedTeamButton_Click);
            // 
            // deleteSelectedPrizesButton
            // 
            this.deleteSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.deleteSelectedPrizesButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(654, 255);
            this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(111, 46);
            this.deleteSelectedPrizesButton.TabIndex = 26;
            this.deleteSelectedPrizesButton.Text = "Delete";
            this.deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPrizesButton.Click += new System.EventHandler(this.deleteSelectedPrizesButton_Click);
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.prizesLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.prizesLabel.Location = new System.Drawing.Point(386, 264);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(85, 37);
            this.prizesLabel.TabIndex = 25;
            this.prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(386, 314);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(379, 152);
            this.prizesListBox.TabIndex = 24;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.createTournamentButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(277, 472);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(221, 46);
            this.createTournamentButton.TabIndex = 27;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 526);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizesButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedTeamButton);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedTeamButton;
        private System.Windows.Forms.Button deleteSelectedPrizesButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}