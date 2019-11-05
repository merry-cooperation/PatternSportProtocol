namespace SportProtocolApp
{
    partial class TeamsForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.sportsListBox = new System.Windows.Forms.ListBox();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(678, 406);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 32);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sportsListBox
            // 
            this.sportsListBox.FormattingEnabled = true;
            this.sportsListBox.ItemHeight = 16;
            this.sportsListBox.Location = new System.Drawing.Point(12, 91);
            this.sportsListBox.Name = "sportsListBox";
            this.sportsListBox.Size = new System.Drawing.Size(110, 148);
            this.sportsListBox.TabIndex = 1;
            this.sportsListBox.SelectedValueChanged += new System.EventHandler(this.sportsListBox_SelectedValueChanged);
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 16;
            this.teamsListBox.Location = new System.Drawing.Point(176, 91);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(144, 148);
            this.teamsListBox.TabIndex = 2;
            this.teamsListBox.SelectedValueChanged += new System.EventHandler(this.teamsListBox_SelectedValueChanged);
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(176, 399);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(137, 36);
            this.createTeamButton.TabIndex = 3;
            this.createTeamButton.Text = "create team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(176, 371);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(144, 22);
            this.teamNameTextBox.TabIndex = 4;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(378, 371);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(143, 22);
            this.playerNameTextBox.TabIndex = 5;
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Location = new System.Drawing.Point(378, 411);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(143, 24);
            this.createPlayerButton.TabIndex = 6;
            this.createPlayerButton.Text = "create player";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(378, 91);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(154, 148);
            this.playersListBox.TabIndex = 7;
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.sportsListBox);
            this.Controls.Add(this.closeButton);
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox sportsListBox;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.ListBox playersListBox;
    }
}