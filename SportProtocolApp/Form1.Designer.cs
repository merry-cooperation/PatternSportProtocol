namespace SportProtocolApp
{
    partial class Form1
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
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usrNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.sportsListBox = new System.Windows.Forms.ListBox();
            this.addSportButton = new System.Windows.Forms.Button();
            this.addSportGroupBox = new System.Windows.Forms.GroupBox();
            this.newSportEventsLabel = new System.Windows.Forms.Label();
            this.eTypesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addSportTextBox = new System.Windows.Forms.TextBox();
            this.logInGroupBox = new System.Windows.Forms.GroupBox();
            this.adminControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.editTeamsButton = new System.Windows.Forms.Button();
            this.matchesListBox = new System.Windows.Forms.ListBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.getStatsButton = new System.Windows.Forms.Button();
            this.addSportGroupBox.SuspendLayout();
            this.logInGroupBox.SuspendLayout();
            this.adminControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Location = new System.Drawing.Point(22, 23);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(46, 17);
            this.loggedInLabel.TabIndex = 0;
            this.loggedInLabel.Text = "Guest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // usrNameTextBox
            // 
            this.usrNameTextBox.Location = new System.Drawing.Point(230, 15);
            this.usrNameTextBox.Name = "usrNameTextBox";
            this.usrNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.usrNameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(411, 15);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(517, 13);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(105, 27);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // sportsListBox
            // 
            this.sportsListBox.FormattingEnabled = true;
            this.sportsListBox.ItemHeight = 16;
            this.sportsListBox.Location = new System.Drawing.Point(246, 141);
            this.sportsListBox.Name = "sportsListBox";
            this.sportsListBox.Size = new System.Drawing.Size(126, 452);
            this.sportsListBox.TabIndex = 7;
            this.sportsListBox.SelectedValueChanged += new System.EventHandler(this.sportsListBox_SelectedValueChanged);
            // 
            // addSportButton
            // 
            this.addSportButton.Location = new System.Drawing.Point(60, 225);
            this.addSportButton.Name = "addSportButton";
            this.addSportButton.Size = new System.Drawing.Size(75, 23);
            this.addSportButton.TabIndex = 8;
            this.addSportButton.Text = "add sport";
            this.addSportButton.UseVisualStyleBackColor = true;
            this.addSportButton.Click += new System.EventHandler(this.addSportButton_Click);
            // 
            // addSportGroupBox
            // 
            this.addSportGroupBox.Controls.Add(this.newSportEventsLabel);
            this.addSportGroupBox.Controls.Add(this.eTypesCheckedListBox);
            this.addSportGroupBox.Controls.Add(this.addSportButton);
            this.addSportGroupBox.Controls.Add(this.addSportTextBox);
            this.addSportGroupBox.Location = new System.Drawing.Point(6, 191);
            this.addSportGroupBox.Name = "addSportGroupBox";
            this.addSportGroupBox.Size = new System.Drawing.Size(202, 254);
            this.addSportGroupBox.TabIndex = 9;
            this.addSportGroupBox.TabStop = false;
            this.addSportGroupBox.Text = "Add new sport";
            // 
            // newSportEventsLabel
            // 
            this.newSportEventsLabel.AutoSize = true;
            this.newSportEventsLabel.Location = new System.Drawing.Point(12, 46);
            this.newSportEventsLabel.Name = "newSportEventsLabel";
            this.newSportEventsLabel.Size = new System.Drawing.Size(137, 17);
            this.newSportEventsLabel.TabIndex = 10;
            this.newSportEventsLabel.Text = "Events for new sport";
            // 
            // eTypesCheckedListBox
            // 
            this.eTypesCheckedListBox.CheckOnClick = true;
            this.eTypesCheckedListBox.FormattingEnabled = true;
            this.eTypesCheckedListBox.Location = new System.Drawing.Point(6, 66);
            this.eTypesCheckedListBox.Name = "eTypesCheckedListBox";
            this.eTypesCheckedListBox.Size = new System.Drawing.Size(190, 140);
            this.eTypesCheckedListBox.TabIndex = 11;
            // 
            // addSportTextBox
            // 
            this.addSportTextBox.Location = new System.Drawing.Point(15, 21);
            this.addSportTextBox.Name = "addSportTextBox";
            this.addSportTextBox.Size = new System.Drawing.Size(167, 22);
            this.addSportTextBox.TabIndex = 9;
            // 
            // logInGroupBox
            // 
            this.logInGroupBox.Controls.Add(this.loggedInLabel);
            this.logInGroupBox.Controls.Add(this.label3);
            this.logInGroupBox.Controls.Add(this.label2);
            this.logInGroupBox.Controls.Add(this.logInButton);
            this.logInGroupBox.Controls.Add(this.usrNameTextBox);
            this.logInGroupBox.Controls.Add(this.passwordTextBox);
            this.logInGroupBox.Location = new System.Drawing.Point(68, 12);
            this.logInGroupBox.Name = "logInGroupBox";
            this.logInGroupBox.Size = new System.Drawing.Size(635, 48);
            this.logInGroupBox.TabIndex = 10;
            this.logInGroupBox.TabStop = false;
            this.logInGroupBox.Text = "Logged in as";
            // 
            // adminControlsGroupBox
            // 
            this.adminControlsGroupBox.Controls.Add(this.addEventButton);
            this.adminControlsGroupBox.Controls.Add(this.editTeamsButton);
            this.adminControlsGroupBox.Controls.Add(this.addSportGroupBox);
            this.adminControlsGroupBox.Enabled = false;
            this.adminControlsGroupBox.Location = new System.Drawing.Point(12, 141);
            this.adminControlsGroupBox.Name = "adminControlsGroupBox";
            this.adminControlsGroupBox.Size = new System.Drawing.Size(214, 451);
            this.adminControlsGroupBox.TabIndex = 11;
            this.adminControlsGroupBox.TabStop = false;
            this.adminControlsGroupBox.Text = "Admin controls";
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(6, 21);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(196, 45);
            this.addEventButton.TabIndex = 12;
            this.addEventButton.Text = "Add Events for selected match";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // editTeamsButton
            // 
            this.editTeamsButton.Location = new System.Drawing.Point(56, 131);
            this.editTeamsButton.Name = "editTeamsButton";
            this.editTeamsButton.Size = new System.Drawing.Size(109, 24);
            this.editTeamsButton.TabIndex = 10;
            this.editTeamsButton.Text = "Edit Teams";
            this.editTeamsButton.UseVisualStyleBackColor = true;
            this.editTeamsButton.Click += new System.EventHandler(this.editTeamsButton_Click);
            // 
            // matchesListBox
            // 
            this.matchesListBox.FormattingEnabled = true;
            this.matchesListBox.ItemHeight = 16;
            this.matchesListBox.Location = new System.Drawing.Point(378, 141);
            this.matchesListBox.Name = "matchesListBox";
            this.matchesListBox.Size = new System.Drawing.Size(692, 196);
            this.matchesListBox.TabIndex = 12;
            this.matchesListBox.SelectedValueChanged += new System.EventHandler(this.matchesListBox_SelectedValueChanged);
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(378, 350);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(692, 244);
            this.eventsListBox.TabIndex = 13;
            // 
            // getStatsButton
            // 
            this.getStatsButton.Location = new System.Drawing.Point(652, 103);
            this.getStatsButton.Name = "getStatsButton";
            this.getStatsButton.Size = new System.Drawing.Size(114, 23);
            this.getStatsButton.TabIndex = 15;
            this.getStatsButton.Text = "Get Stats";
            this.getStatsButton.UseVisualStyleBackColor = true;
            this.getStatsButton.Click += new System.EventHandler(this.getStatsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 635);
            this.Controls.Add(this.getStatsButton);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.matchesListBox);
            this.Controls.Add(this.adminControlsGroupBox);
            this.Controls.Add(this.logInGroupBox);
            this.Controls.Add(this.sportsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addSportGroupBox.ResumeLayout(false);
            this.addSportGroupBox.PerformLayout();
            this.logInGroupBox.ResumeLayout(false);
            this.logInGroupBox.PerformLayout();
            this.adminControlsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.ListBox sportsListBox;
        private System.Windows.Forms.Button addSportButton;
        private System.Windows.Forms.GroupBox addSportGroupBox;
        private System.Windows.Forms.TextBox addSportTextBox;
        private System.Windows.Forms.GroupBox logInGroupBox;
        private System.Windows.Forms.GroupBox adminControlsGroupBox;
        private System.Windows.Forms.ListBox matchesListBox;
        private System.Windows.Forms.Button editTeamsButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.CheckedListBox eTypesCheckedListBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Label newSportEventsLabel;
        private System.Windows.Forms.Button getStatsButton;
    }
}

