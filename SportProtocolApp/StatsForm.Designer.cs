namespace SportProtocolApp
{
    partial class StatsForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.statsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getStatsButton = new System.Windows.Forms.Button();
            this.playersListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(754, 528);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(111, 38);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(66, 17);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "infoLabel";
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(191, 279);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(656, 228);
            this.eventsListBox.TabIndex = 8;
            // 
            // statsComboBox
            // 
            this.statsComboBox.FormattingEnabled = true;
            this.statsComboBox.Items.AddRange(new object[] {
            "All goals by player",
            "All passes with player",
            "All fouls by player",
            "All yellow cards for player",
            "All red cards for player"});
            this.statsComboBox.Location = new System.Drawing.Point(12, 91);
            this.statsComboBox.Name = "statsComboBox";
            this.statsComboBox.Size = new System.Drawing.Size(161, 24);
            this.statsComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type of stat";
            // 
            // getStatsButton
            // 
            this.getStatsButton.Location = new System.Drawing.Point(27, 148);
            this.getStatsButton.Name = "getStatsButton";
            this.getStatsButton.Size = new System.Drawing.Size(113, 34);
            this.getStatsButton.TabIndex = 11;
            this.getStatsButton.Text = "get stats";
            this.getStatsButton.UseVisualStyleBackColor = true;
            this.getStatsButton.Click += new System.EventHandler(this.getStatsButton_Click);
            // 
            // playersListBox1
            // 
            this.playersListBox1.FormattingEnabled = true;
            this.playersListBox1.ItemHeight = 16;
            this.playersListBox1.Location = new System.Drawing.Point(191, 71);
            this.playersListBox1.Name = "playersListBox1";
            this.playersListBox1.Size = new System.Drawing.Size(656, 196);
            this.playersListBox1.TabIndex = 12;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 593);
            this.Controls.Add(this.playersListBox1);
            this.Controls.Add(this.getStatsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statsComboBox);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.ComboBox statsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getStatsButton;
        private System.Windows.Forms.ListBox playersListBox1;
    }
}