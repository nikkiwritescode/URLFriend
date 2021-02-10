
using URLfriend.FileList;

namespace URLfriend.Panels
{
    partial class ConfigureRemoveCharacterReferencesPanel
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
            this.EnableSelectedRuleButton = new System.Windows.Forms.Button();
            this.DisableSelectedRuleButton = new System.Windows.Forms.Button();
            this.CharacterReferenceListView = new URLfriend.FileList.BufferedListView();
            this.IsEnabledHeader = new System.Windows.Forms.ColumnHeader();
            this.SymbolHeader = new System.Windows.Forms.ColumnHeader();
            this.ReplaceTextHeader = new System.Windows.Forms.ColumnHeader();
            this.CancelCharacterReferenceButton = new System.Windows.Forms.Button();
            this.SaveCharacterReferenceButton = new System.Windows.Forms.Button();
            this.ReloadEncodingDefaultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnableSelectedRuleButton
            // 
            this.EnableSelectedRuleButton.Location = new System.Drawing.Point(205, 12);
            this.EnableSelectedRuleButton.Name = "EnableSelectedRuleButton";
            this.EnableSelectedRuleButton.Size = new System.Drawing.Size(136, 35);
            this.EnableSelectedRuleButton.TabIndex = 2;
            this.EnableSelectedRuleButton.Text = "Enable Selected";
            this.EnableSelectedRuleButton.UseVisualStyleBackColor = true;
            this.EnableSelectedRuleButton.Click += new System.EventHandler(this.EnableSelectedItemButtonClick);
            // 
            // DisableSelectedRuleButton
            // 
            this.DisableSelectedRuleButton.Location = new System.Drawing.Point(205, 53);
            this.DisableSelectedRuleButton.Name = "DisableSelectedRuleButton";
            this.DisableSelectedRuleButton.Size = new System.Drawing.Size(136, 35);
            this.DisableSelectedRuleButton.TabIndex = 3;
            this.DisableSelectedRuleButton.Text = "Disable Selected";
            this.DisableSelectedRuleButton.UseVisualStyleBackColor = true;
            this.DisableSelectedRuleButton.Click += new System.EventHandler(this.DisableSelectedItemButtonClick);
            // 
            // CharacterReferenceListView
            // 
            this.CharacterReferenceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IsEnabledHeader,
            this.SymbolHeader,
            this.ReplaceTextHeader});
            this.CharacterReferenceListView.FullRowSelect = true;
            this.CharacterReferenceListView.HideSelection = false;
            this.CharacterReferenceListView.Location = new System.Drawing.Point(6, 12);
            this.CharacterReferenceListView.Name = "CharacterReferenceListView";
            this.CharacterReferenceListView.Size = new System.Drawing.Size(192, 276);
            this.CharacterReferenceListView.TabIndex = 4;
            this.CharacterReferenceListView.UseCompatibleStateImageBehavior = false;
            this.CharacterReferenceListView.View = System.Windows.Forms.View.Details;
            // 
            // IsEnabledHeader
            // 
            this.IsEnabledHeader.Name = "IsEnabledHeader";
            this.IsEnabledHeader.Text = "Status";
            this.IsEnabledHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SymbolHeader
            // 
            this.SymbolHeader.Name = "SymbolHeader";
            this.SymbolHeader.Text = "Symbol";
            this.SymbolHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SymbolHeader.Width = 55;
            // 
            // ReplaceTextHeader
            // 
            this.ReplaceTextHeader.Name = "ReplaceTextHeader";
            this.ReplaceTextHeader.Text = "Text";
            this.ReplaceTextHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReplaceTextHeader.Width = 55;
            // 
            // CancelCharacterReferenceButton
            // 
            this.CancelCharacterReferenceButton.Location = new System.Drawing.Point(205, 253);
            this.CancelCharacterReferenceButton.Name = "CancelCharacterReferenceButton";
            this.CancelCharacterReferenceButton.Size = new System.Drawing.Size(65, 35);
            this.CancelCharacterReferenceButton.TabIndex = 5;
            this.CancelCharacterReferenceButton.Text = "Cancel";
            this.CancelCharacterReferenceButton.UseVisualStyleBackColor = true;
            this.CancelCharacterReferenceButton.Click += new System.EventHandler(this.CancelCharacterReferenceButtonClick);
            // 
            // SaveCharacterReferenceButton
            // 
            this.SaveCharacterReferenceButton.Location = new System.Drawing.Point(276, 253);
            this.SaveCharacterReferenceButton.Name = "SaveCharacterReferenceButton";
            this.SaveCharacterReferenceButton.Size = new System.Drawing.Size(65, 35);
            this.SaveCharacterReferenceButton.TabIndex = 6;
            this.SaveCharacterReferenceButton.Text = "Save";
            this.SaveCharacterReferenceButton.UseVisualStyleBackColor = true;
            this.SaveCharacterReferenceButton.Click += new System.EventHandler(this.SaveCharacterReferenceButtonClick);
            // 
            // ReloadEncodingDefaultsButton
            // 
            this.ReloadEncodingDefaultsButton.Location = new System.Drawing.Point(205, 149);
            this.ReloadEncodingDefaultsButton.Name = "ReloadEncodingDefaultsButton";
            this.ReloadEncodingDefaultsButton.Size = new System.Drawing.Size(136, 35);
            this.ReloadEncodingDefaultsButton.TabIndex = 7;
            this.ReloadEncodingDefaultsButton.Text = "Reload Defaults";
            this.ReloadEncodingDefaultsButton.UseVisualStyleBackColor = true;
            this.ReloadEncodingDefaultsButton.Click += new System.EventHandler(this.ReloadEncodingDefaultsButton_Click);
            // 
            // ConfigureRemoveCharacterReferencesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 299);
            this.Controls.Add(this.ReloadEncodingDefaultsButton);
            this.Controls.Add(this.SaveCharacterReferenceButton);
            this.Controls.Add(this.CancelCharacterReferenceButton);
            this.Controls.Add(this.CharacterReferenceListView);
            this.Controls.Add(this.DisableSelectedRuleButton);
            this.Controls.Add(this.EnableSelectedRuleButton);
            this.Name = "ConfigureRemoveCharacterReferencesPanel";
            this.Text = "ASCII Encoding";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EnableSelectedRuleButton;
        private System.Windows.Forms.Button DisableSelectedRuleButton;
        private System.Windows.Forms.ColumnHeader SymbolHeader;
        private System.Windows.Forms.ColumnHeader ReplaceTextHeader;
        private System.Windows.Forms.ColumnHeader StatusHeader;
        private System.Windows.Forms.ColumnHeader IsEnabledHeader;
        private System.Windows.Forms.Button CancelCharacterReferenceButton;
        private System.Windows.Forms.Button SaveCharacterReferenceButton;
        private System.Windows.Forms.Button ReloadEncodingDefaultsButton;
        private BufferedListView CharacterReferenceListView;
    }
}