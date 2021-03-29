
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.createPrizeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createPrizeLabel.Location = new System.Drawing.Point(11, 9);
            this.createPrizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(217, 50);
            this.createPrizeLabel.TabIndex = 19;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(140, 75);
            this.placeNumberValue.Margin = new System.Windows.Forms.Padding(2);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(174, 29);
            this.placeNumberValue.TabIndex = 21;
            this.placeNumberValue.TextChanged += new System.EventHandler(this.placeNumberValue_TextChanged);
            // 
            // placNumberLabel
            // 
            this.placNumberLabel.AutoSize = true;
            this.placNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.placNumberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.placNumberLabel.Location = new System.Drawing.Point(16, 83);
            this.placNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placNumberLabel.Name = "placNumberLabel";
            this.placNumberLabel.Size = new System.Drawing.Size(108, 21);
            this.placNumberLabel.TabIndex = 20;
            this.placNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(140, 122);
            this.placeNameValue.Margin = new System.Windows.Forms.Padding(2);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(174, 29);
            this.placeNameValue.TabIndex = 23;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.placeNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.placeNameLabel.Location = new System.Drawing.Point(16, 130);
            this.placeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(92, 21);
            this.placeNameLabel.TabIndex = 22;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(140, 165);
            this.prizeAmountValue.Margin = new System.Windows.Forms.Padding(2);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(174, 29);
            this.prizeAmountValue.TabIndex = 25;
            this.prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.prizeAmountLabel.Location = new System.Drawing.Point(16, 173);
            this.prizeAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(104, 21);
            this.prizeAmountLabel.TabIndex = 24;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(140, 246);
            this.prizePercentageValue.Margin = new System.Windows.Forms.Padding(2);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(174, 29);
            this.prizePercentageValue.TabIndex = 27;
            this.prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.prizePercentageLabel.Location = new System.Drawing.Point(16, 254);
            this.prizePercentageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(124, 21);
            this.prizePercentageLabel.TabIndex = 26;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.orLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.orLabel.Location = new System.Drawing.Point(89, 211);
            this.orLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(37, 21);
            this.orLabel.TabIndex = 28;
            this.orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.createPrizeButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(89, 307);
            this.createPrizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(213, 85);
            this.createPrizeButton.TabIndex = 29;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // prizeListBox
            // 
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 21;
            this.prizeListBox.Location = new System.Drawing.Point(355, 83);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(120, 88);
            this.prizeListBox.TabIndex = 30;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placNumberLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox prizeListBox;
    }
}