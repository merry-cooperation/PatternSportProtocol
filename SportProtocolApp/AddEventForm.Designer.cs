namespace SportProtocolApp
{
    partial class AddEventForm
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
            this.eTypeComboBox = new System.Windows.Forms.ComboBox();
            this.playersACheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.playersBCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.eTypeLabel = new System.Windows.Forms.Label();
            this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(663, 508);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(138, 41);
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
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "infoLabel";
            // 
            // eTypeComboBox
            // 
            this.eTypeComboBox.FormattingEnabled = true;
            this.eTypeComboBox.Location = new System.Drawing.Point(17, 161);
            this.eTypeComboBox.Name = "eTypeComboBox";
            this.eTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.eTypeComboBox.TabIndex = 3;
            // 
            // playersACheckedListBox
            // 
            this.playersACheckedListBox.CheckOnClick = true;
            this.playersACheckedListBox.FormattingEnabled = true;
            this.playersACheckedListBox.Location = new System.Drawing.Point(186, 69);
            this.playersACheckedListBox.Name = "playersACheckedListBox";
            this.playersACheckedListBox.Size = new System.Drawing.Size(248, 327);
            this.playersACheckedListBox.TabIndex = 4;
            // 
            // playersBCheckedListBox
            // 
            this.playersBCheckedListBox.CheckOnClick = true;
            this.playersBCheckedListBox.FormattingEnabled = true;
            this.playersBCheckedListBox.Location = new System.Drawing.Point(462, 69);
            this.playersBCheckedListBox.Name = "playersBCheckedListBox";
            this.playersBCheckedListBox.Size = new System.Drawing.Size(248, 327);
            this.playersBCheckedListBox.TabIndex = 5;
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(254, 413);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(321, 84);
            this.eventsListBox.TabIndex = 6;
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(42, 245);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(96, 32);
            this.addEventButton.TabIndex = 7;
            this.addEventButton.Text = "Add event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(12, 69);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(168, 17);
            this.minutesLabel.TabIndex = 8;
            this.minutesLabel.Text = "Minutes since match start";
            // 
            // eTypeLabel
            // 
            this.eTypeLabel.AutoSize = true;
            this.eTypeLabel.Location = new System.Drawing.Point(13, 138);
            this.eTypeLabel.Name = "eTypeLabel";
            this.eTypeLabel.Size = new System.Drawing.Size(80, 17);
            this.eTypeLabel.TabIndex = 9;
            this.eTypeLabel.Text = "Event Type";
            // 
            // minutesNumericUpDown
            // 
            this.minutesNumericUpDown.Location = new System.Drawing.Point(42, 90);
            this.minutesNumericUpDown.Name = "minutesNumericUpDown";
            this.minutesNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.minutesNumericUpDown.TabIndex = 10;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 561);
            this.Controls.Add(this.minutesNumericUpDown);
            this.Controls.Add(this.eTypeLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.playersBCheckedListBox);
            this.Controls.Add(this.playersACheckedListBox);
            this.Controls.Add(this.eTypeComboBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox eTypeComboBox;
        private System.Windows.Forms.CheckedListBox playersACheckedListBox;
        private System.Windows.Forms.CheckedListBox playersBCheckedListBox;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label eTypeLabel;
        private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
    }
}