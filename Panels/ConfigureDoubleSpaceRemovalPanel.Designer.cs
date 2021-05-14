
using URLfriend.UI;

namespace URLfriend.Panels
{
    partial class ConfigureDoubleSpaceRemovalPanel
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
            this.RunMultipleTimesCheckbox = new System.Windows.Forms.CheckBox();
            this.CancelDoubleSpaceRemovalSettingsButton = new System.Windows.Forms.Button();
            this.SaveDoubleSpaceRemovalSettingsButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.RunAdditionalTimesComboBox = new CustomComboBox();
            this.DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunMultipleTimesCheckbox
            // 
            this.RunMultipleTimesCheckbox.AutoSize = true;
            this.RunMultipleTimesCheckbox.Location = new System.Drawing.Point(36, 74);
            this.RunMultipleTimesCheckbox.Name = "RunMultipleTimesCheckbox";
            this.RunMultipleTimesCheckbox.Size = new System.Drawing.Size(142, 19);
            this.RunMultipleTimesCheckbox.TabIndex = 0;
            this.RunMultipleTimesCheckbox.Text = "Run Additional Times:";
            this.RunMultipleTimesCheckbox.UseVisualStyleBackColor = true;
            this.RunMultipleTimesCheckbox.CheckedChanged += new System.EventHandler(this.RunMultipleTimesCheckbox_CheckedChanged);
            // 
            // CancelDoubleSpaceRemovalSettingsButton
            // 
            this.CancelDoubleSpaceRemovalSettingsButton.Location = new System.Drawing.Point(175, 128);
            this.CancelDoubleSpaceRemovalSettingsButton.Name = "CancelDoubleSpaceRemovalSettingsButton";
            this.CancelDoubleSpaceRemovalSettingsButton.Size = new System.Drawing.Size(75, 35);
            this.CancelDoubleSpaceRemovalSettingsButton.TabIndex = 1;
            this.CancelDoubleSpaceRemovalSettingsButton.Text = "Cancel";
            this.CancelDoubleSpaceRemovalSettingsButton.UseVisualStyleBackColor = true;
            this.CancelDoubleSpaceRemovalSettingsButton.Click += new System.EventHandler(this.CancelDoubleSpaceRemovalSettings_Click);
            // 
            // SaveDoubleSpaceRemovalSettingsButton
            // 
            this.SaveDoubleSpaceRemovalSettingsButton.Location = new System.Drawing.Point(85, 128);
            this.SaveDoubleSpaceRemovalSettingsButton.Name = "SaveDoubleSpaceRemovalSettingsButton";
            this.SaveDoubleSpaceRemovalSettingsButton.Size = new System.Drawing.Size(75, 35);
            this.SaveDoubleSpaceRemovalSettingsButton.TabIndex = 2;
            this.SaveDoubleSpaceRemovalSettingsButton.Text = "Save";
            this.SaveDoubleSpaceRemovalSettingsButton.UseVisualStyleBackColor = true;
            this.SaveDoubleSpaceRemovalSettingsButton.Click += new System.EventHandler(this.SaveDoubleSpaceRemovalSettingsButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 19);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(309, 50);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "By default, this feature checks only for Double (2) spaces in a row. Here you can" +
    " configure the settings to check for triple (3), quadruple (4), or more spaces.";
            // 
            // RunAdditionalTimesComboBox
            // 
            this.RunAdditionalTimesComboBox.DisplayMember = "0";
            this.RunAdditionalTimesComboBox.Enabled = false;
            this.RunAdditionalTimesComboBox.FormattingEnabled = true;
            this.RunAdditionalTimesComboBox.Items.AddRange(new object[] {
            "2 times",
            "3 times",
            "4 times",
            "5 times",
            "6 times",
            "7 times",
            "8 times",
            "9 times",
            "10 times"});
            this.RunAdditionalTimesComboBox.Location = new System.Drawing.Point(184, 72);
            this.RunAdditionalTimesComboBox.Name = "RunAdditionalTimesComboBox";
            this.RunAdditionalTimesComboBox.Size = new System.Drawing.Size(74, 23);
            this.RunAdditionalTimesComboBox.TabIndex = 4;
            this.RunAdditionalTimesComboBox.Text = "2 times";
            // 
            // DescriptionGroupBox
            // 
            this.DescriptionGroupBox.Controls.Add(this.RunAdditionalTimesComboBox);
            this.DescriptionGroupBox.Controls.Add(this.DescriptionLabel);
            this.DescriptionGroupBox.Controls.Add(this.RunMultipleTimesCheckbox);
            this.DescriptionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DescriptionGroupBox.Name = "DescriptionGroupBox";
            this.DescriptionGroupBox.Size = new System.Drawing.Size(321, 110);
            this.DescriptionGroupBox.TabIndex = 5;
            this.DescriptionGroupBox.TabStop = false;
            // 
            // ConfigureDoubleSpaceRemovalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 172);
            this.Controls.Add(this.DescriptionGroupBox);
            this.Controls.Add(this.SaveDoubleSpaceRemovalSettingsButton);
            this.Controls.Add(this.CancelDoubleSpaceRemovalSettingsButton);
            this.Name = "ConfigureDoubleSpaceRemovalPanel";
            this.Text = "ConfigureDoubleSpaceRemovalPanel";
            this.DescriptionGroupBox.ResumeLayout(false);
            this.DescriptionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox RunMultipleTimesCheckbox;
        private System.Windows.Forms.Button CancelDoubleSpaceRemovalSettingsButton;
        private System.Windows.Forms.Button SaveDoubleSpaceRemovalSettingsButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.GroupBox DescriptionGroupBox;
        private CustomComboBox RunAdditionalTimesComboBox;
    }
}