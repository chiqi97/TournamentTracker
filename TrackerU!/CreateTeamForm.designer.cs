
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.createTeamLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTeamLabel.Location = new System.Drawing.Point(2, -6);
            this.createTeamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(223, 50);
            this.createTeamLabel.TabIndex = 18;
            this.createTeamLabel.Text = "Create Team";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.teamNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(2, 44);
            this.teamNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(92, 21);
            this.teamNameLabel.TabIndex = 17;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(2, 67);
            this.teamNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(252, 29);
            this.teamNameValue.TabIndex = 19;
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addMemberButton.Location = new System.Drawing.Point(42, 174);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(157, 45);
            this.addMemberButton.TabIndex = 22;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(2, 132);
            this.selectTeamMemberDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(251, 29);
            this.selectTeamMemberDropDown.TabIndex = 21;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(2, 109);
            this.selectTeamMemberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(154, 21);
            this.selectTeamMemberLabel.TabIndex = 20;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(11, 223);
            this.addNewMemberGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(298, 234);
            this.addNewMemberGroupBox.TabIndex = 23;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.createMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createMemberButton.Location = new System.Drawing.Point(57, 184);
            this.createMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(157, 46);
            this.createMemberButton.TabIndex = 28;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(118, 138);
            this.cellphoneValue.Margin = new System.Windows.Forms.Padding(2);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(174, 29);
            this.cellphoneValue.TabIndex = 27;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cellPhoneLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cellPhoneLabel.Location = new System.Drawing.Point(10, 146);
            this.cellPhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(80, 21);
            this.cellPhoneLabel.TabIndex = 26;
            this.cellPhoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(118, 105);
            this.emailValue.Margin = new System.Windows.Forms.Padding(2);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(174, 29);
            this.emailValue.TabIndex = 25;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.emailLabel.Location = new System.Drawing.Point(10, 113);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 21);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(118, 64);
            this.lastNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(174, 29);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(10, 72);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(118, 26);
            this.firstNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(174, 29);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.firstNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 34);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 21);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 21;
            this.teamMembersListBox.Location = new System.Drawing.Point(307, 4);
            this.teamMembersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(285, 443);
            this.teamMembersListBox.TabIndex = 24;
            // 
            // removeSelectedMemberButton
            // 
            this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.removeSelectedMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.removeSelectedMemberButton.Location = new System.Drawing.Point(605, 174);
            this.removeSelectedMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            this.removeSelectedMemberButton.Size = new System.Drawing.Size(157, 85);
            this.removeSelectedMemberButton.TabIndex = 25;
            this.removeSelectedMemberButton.Text = "Remove Selected";
            this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
            this.removeSelectedMemberButton.Click += new System.EventHandler(this.deleteSelectedMemberButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.createTeamButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createTeamButton.Location = new System.Drawing.Point(248, 461);
            this.createTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(214, 45);
            this.createTeamButton.TabIndex = 26;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 508);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.createTeamLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellPhoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button removeSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}