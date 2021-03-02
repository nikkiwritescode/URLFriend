
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
            this.CancelDoubleSpaceRemovalSettings = new System.Windows.Forms.Button();
            this.SaveDoubleSpaceRemovalSettingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RunAdditionalTimesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            // CancelDoubleSpaceRemovalSettings
            // 
            this.CancelDoubleSpaceRemovalSettings.Location = new System.Drawing.Point(175, 140);
            this.CancelDoubleSpaceRemovalSettings.Name = "CancelDoubleSpaceRemovalSettings";
            this.CancelDoubleSpaceRemovalSettings.Size = new System.Drawing.Size(75, 23);
            this.CancelDoubleSpaceRemovalSettings.TabIndex = 1;
            this.CancelDoubleSpaceRemovalSettings.Text = "Cancel";
            this.CancelDoubleSpaceRemovalSettings.UseVisualStyleBackColor = true;
            this.CancelDoubleSpaceRemovalSettings.Click += new System.EventHandler(this.CancelDoubleSpaceRemovalSettings_Click);
            // 
            // SaveDoubleSpaceRemovalSettingsButton
            // 
            this.SaveDoubleSpaceRemovalSettingsButton.Location = new System.Drawing.Point(85, 140);
            this.SaveDoubleSpaceRemovalSettingsButton.Name = "SaveDoubleSpaceRemovalSettingsButton";
            this.SaveDoubleSpaceRemovalSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveDoubleSpaceRemovalSettingsButton.TabIndex = 2;
            this.SaveDoubleSpaceRemovalSettingsButton.Text = "Save";
            this.SaveDoubleSpaceRemovalSettingsButton.UseVisualStyleBackColor = true;
            this.SaveDoubleSpaceRemovalSettingsButton.Click += new System.EventHandler(this.SaveDoubleSpaceRemovalSettingsButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "By default, this feature checks only for Double (2) spaces in a row. Here you can" +
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RunAdditionalTimesComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RunMultipleTimesCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // ConfigureDoubleSpaceRemovalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 186);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveDoubleSpaceRemovalSettingsButton);
            this.Controls.Add(this.CancelDoubleSpaceRemovalSettings);
            this.Name = "ConfigureDoubleSpaceRemovalPanel";
            this.Text = "ConfigureDoubleSpaceRemovalPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox RunMultipleTimesCheckbox;
        private System.Windows.Forms.Button CancelDoubleSpaceRemovalSettings;
        private System.Windows.Forms.Button SaveDoubleSpaceRemovalSettingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RunAdditionalTimesComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}