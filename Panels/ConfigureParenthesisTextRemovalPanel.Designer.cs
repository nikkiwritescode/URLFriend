using URLfriend.UI;

namespace URLfriend.Panels
{
    partial class ConfigureParenthesisTextRemovalPanel
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
            this.PhraseToPreserveListForParenthesisPanel = new BufferedListView();
            this.PhraseHeader = new System.Windows.Forms.ColumnHeader();
            this.AddPhraseToPreserveButton = new System.Windows.Forms.Button();
            this.RemovePhraseToPreserveButton = new System.Windows.Forms.Button();
            this.CloseConfigureTextBetweenParenthesisWindowButton = new System.Windows.Forms.Button();
            this.ClearPhraseToPreserveListButton = new System.Windows.Forms.Button();
            this.AddPhraseToPreserveTextBox = new System.Windows.Forms.TextBox();
            this.PhraseToPreserveLabel = new System.Windows.Forms.Label();
            this.AddPhraseToRemoveTextBox = new System.Windows.Forms.TextBox();
            this.AddPhraseToRemoveButton = new System.Windows.Forms.Button();
            this.ClearPhraseToRemoveListButton = new System.Windows.Forms.Button();
            this.RemovePhraseToRemoveButton = new System.Windows.Forms.Button();
            this.PhraseToRemoveLabel = new System.Windows.Forms.Label();
            this.PhraseToRemoveListForParenthesisPanel = new BufferedListView();
            this.PhrasesToRemoveHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // PhraseToPreserveListForParenthesisPanel
            // 
            this.PhraseToPreserveListForParenthesisPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PhraseHeader});
            this.PhraseToPreserveListForParenthesisPanel.HideSelection = false;
            this.PhraseToPreserveListForParenthesisPanel.Location = new System.Drawing.Point(12, 91);
            this.PhraseToPreserveListForParenthesisPanel.Name = "PhraseToPreserveListForParenthesisPanel";
            this.PhraseToPreserveListForParenthesisPanel.Size = new System.Drawing.Size(209, 229);
            this.PhraseToPreserveListForParenthesisPanel.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.PhraseToPreserveListForParenthesisPanel.TabIndex = 0;
            this.PhraseToPreserveListForParenthesisPanel.UseCompatibleStateImageBehavior = false;
            this.PhraseToPreserveListForParenthesisPanel.View = System.Windows.Forms.View.Details;
            // 
            // PhraseHeader
            // 
            this.PhraseHeader.Name = "PhraseHeader";
            this.PhraseHeader.Text = "Phrases To Preserve";
            this.PhraseHeader.Width = 205;
            // 
            // AddPhraseToPreserveButton
            // 
            this.AddPhraseToPreserveButton.Location = new System.Drawing.Point(146, 62);
            this.AddPhraseToPreserveButton.Name = "AddPhraseToPreserveButton";
            this.AddPhraseToPreserveButton.Size = new System.Drawing.Size(75, 23);
            this.AddPhraseToPreserveButton.TabIndex = 1;
            this.AddPhraseToPreserveButton.Text = "Add New";
            this.AddPhraseToPreserveButton.UseVisualStyleBackColor = true;
            this.AddPhraseToPreserveButton.Click += new System.EventHandler(this.AddPhraseButton_Click);
            // 
            // RemovePhraseToPreserveButton
            // 
            this.RemovePhraseToPreserveButton.Location = new System.Drawing.Point(116, 326);
            this.RemovePhraseToPreserveButton.Name = "RemovePhraseToPreserveButton";
            this.RemovePhraseToPreserveButton.Size = new System.Drawing.Size(105, 32);
            this.RemovePhraseToPreserveButton.TabIndex = 2;
            this.RemovePhraseToPreserveButton.Text = "Remove Selected";
            this.RemovePhraseToPreserveButton.UseVisualStyleBackColor = true;
            this.RemovePhraseToPreserveButton.Click += new System.EventHandler(this.RemovePhraseButton_Click);
            // 
            // CloseConfigureTextBetweenParenthesisWindowButton
            // 
            this.CloseConfigureTextBetweenParenthesisWindowButton.Location = new System.Drawing.Point(116, 364);
            this.CloseConfigureTextBetweenParenthesisWindowButton.Name = "CloseConfigureTextBetweenParenthesisWindowButton";
            this.CloseConfigureTextBetweenParenthesisWindowButton.Size = new System.Drawing.Size(220, 43);
            this.CloseConfigureTextBetweenParenthesisWindowButton.TabIndex = 3;
            this.CloseConfigureTextBetweenParenthesisWindowButton.Text = "Close Window";
            this.CloseConfigureTextBetweenParenthesisWindowButton.UseVisualStyleBackColor = true;
            this.CloseConfigureTextBetweenParenthesisWindowButton.Click += new System.EventHandler(this.CloseConfigureTextBetweenParenthesisWindowButton_Click);
            // 
            // ClearPhraseToPreserveListButton
            // 
            this.ClearPhraseToPreserveListButton.Location = new System.Drawing.Point(12, 326);
            this.ClearPhraseToPreserveListButton.Name = "ClearPhraseToPreserveListButton";
            this.ClearPhraseToPreserveListButton.Size = new System.Drawing.Size(98, 32);
            this.ClearPhraseToPreserveListButton.TabIndex = 4;
            this.ClearPhraseToPreserveListButton.Text = "Clear List";
            this.ClearPhraseToPreserveListButton.UseVisualStyleBackColor = true;
            this.ClearPhraseToPreserveListButton.Click += new System.EventHandler(this.ClearPhraseListButton_Click);
            // 
            // AddPhraseToPreserveTextBox
            // 
            this.AddPhraseToPreserveTextBox.Location = new System.Drawing.Point(12, 62);
            this.AddPhraseToPreserveTextBox.Name = "AddPhraseToPreserveTextBox";
            this.AddPhraseToPreserveTextBox.Size = new System.Drawing.Size(128, 23);
            this.AddPhraseToPreserveTextBox.TabIndex = 5;
            // 
            // PhraseToPreserveLabel
            // 
            this.PhraseToPreserveLabel.Location = new System.Drawing.Point(12, 9);
            this.PhraseToPreserveLabel.Name = "PhraseToPreserveLabel";
            this.PhraseToPreserveLabel.Size = new System.Drawing.Size(213, 46);
            this.PhraseToPreserveLabel.TabIndex = 6;
            this.PhraseToPreserveLabel.Text = "Phrases you add to this list will be preserved, but parenthesis around this text " +
    "will be removed.";
            // 
            // AddPhraseToRemoveTextBox
            // 
            this.AddPhraseToRemoveTextBox.Location = new System.Drawing.Point(238, 62);
            this.AddPhraseToRemoveTextBox.Name = "AddPhraseToRemoveTextBox";
            this.AddPhraseToRemoveTextBox.Size = new System.Drawing.Size(128, 23);
            this.AddPhraseToRemoveTextBox.TabIndex = 8;
            // 
            // AddPhraseToRemoveButton
            // 
            this.AddPhraseToRemoveButton.Location = new System.Drawing.Point(372, 62);
            this.AddPhraseToRemoveButton.Name = "AddPhraseToRemoveButton";
            this.AddPhraseToRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.AddPhraseToRemoveButton.TabIndex = 9;
            this.AddPhraseToRemoveButton.Text = "Add New";
            this.AddPhraseToRemoveButton.UseVisualStyleBackColor = true;
            this.AddPhraseToRemoveButton.Click += new System.EventHandler(this.AddPhraseToRemoveButton_Click);
            // 
            // ClearPhraseToRemoveListButton
            // 
            this.ClearPhraseToRemoveListButton.Location = new System.Drawing.Point(238, 326);
            this.ClearPhraseToRemoveListButton.Name = "ClearPhraseToRemoveListButton";
            this.ClearPhraseToRemoveListButton.Size = new System.Drawing.Size(98, 32);
            this.ClearPhraseToRemoveListButton.TabIndex = 10;
            this.ClearPhraseToRemoveListButton.Text = "Clear List";
            this.ClearPhraseToRemoveListButton.UseVisualStyleBackColor = true;
            this.ClearPhraseToRemoveListButton.Click += new System.EventHandler(this.ClearPhraseToRemoveListButton_Click);
            // 
            // RemovePhraseToRemoveButton
            // 
            this.RemovePhraseToRemoveButton.Location = new System.Drawing.Point(342, 326);
            this.RemovePhraseToRemoveButton.Name = "RemovePhraseToRemoveButton";
            this.RemovePhraseToRemoveButton.Size = new System.Drawing.Size(105, 32);
            this.RemovePhraseToRemoveButton.TabIndex = 11;
            this.RemovePhraseToRemoveButton.Text = "Remove Selected";
            this.RemovePhraseToRemoveButton.UseVisualStyleBackColor = true;
            this.RemovePhraseToRemoveButton.Click += new System.EventHandler(this.RemovePhraseToRemoveButton_Click);
            // 
            // PhraseToRemoveLabel
            // 
            this.PhraseToRemoveLabel.Location = new System.Drawing.Point(238, 9);
            this.PhraseToRemoveLabel.Name = "PhraseToRemoveLabel";
            this.PhraseToRemoveLabel.Size = new System.Drawing.Size(210, 46);
            this.PhraseToRemoveLabel.TabIndex = 12;
            this.PhraseToRemoveLabel.Text = "Phrases you add to this list, when they exist inside parenthesis, will be removed" +
    " entirely.";
            // 
            // PhraseToRemoveListForParenthesisPanel
            // 
            this.PhraseToRemoveListForParenthesisPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PhrasesToRemoveHeader});
            this.PhraseToRemoveListForParenthesisPanel.HideSelection = false;
            this.PhraseToRemoveListForParenthesisPanel.Location = new System.Drawing.Point(238, 91);
            this.PhraseToRemoveListForParenthesisPanel.Name = "PhraseToRemoveListForParenthesisPanel";
            this.PhraseToRemoveListForParenthesisPanel.Size = new System.Drawing.Size(209, 229);
            this.PhraseToRemoveListForParenthesisPanel.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.PhraseToRemoveListForParenthesisPanel.TabIndex = 13;
            this.PhraseToRemoveListForParenthesisPanel.UseCompatibleStateImageBehavior = false;
            this.PhraseToRemoveListForParenthesisPanel.View = System.Windows.Forms.View.Details;
            // 
            // PhrasesToRemoveHeader
            // 
            this.PhrasesToRemoveHeader.Name = "PhraseHeader";
            this.PhrasesToRemoveHeader.Text = "Phrases To Remove";
            this.PhrasesToRemoveHeader.Width = 205;
            // 
            // ConfigureParenthesisTextRemovalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 416);
            this.Controls.Add(this.PhraseToRemoveListForParenthesisPanel);
            this.Controls.Add(this.PhraseToRemoveLabel);
            this.Controls.Add(this.RemovePhraseToRemoveButton);
            this.Controls.Add(this.ClearPhraseToRemoveListButton);
            this.Controls.Add(this.AddPhraseToRemoveButton);
            this.Controls.Add(this.AddPhraseToRemoveTextBox);
            this.Controls.Add(this.PhraseToPreserveLabel);
            this.Controls.Add(this.AddPhraseToPreserveTextBox);
            this.Controls.Add(this.ClearPhraseToPreserveListButton);
            this.Controls.Add(this.CloseConfigureTextBetweenParenthesisWindowButton);
            this.Controls.Add(this.RemovePhraseToPreserveButton);
            this.Controls.Add(this.AddPhraseToPreserveButton);
            this.Controls.Add(this.PhraseToPreserveListForParenthesisPanel);
            this.Name = "ConfigureParenthesisTextRemovalPanel";
            this.Text = "Text-Inside-Parenthesis Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BufferedListView PhraseToPreserveListForParenthesisPanel;
        private System.Windows.Forms.Button AddPhraseToPreserveButton;
        private System.Windows.Forms.Button RemovePhraseToPreserveButton;
        private System.Windows.Forms.Button CloseConfigureTextBetweenParenthesisWindowButton;
        private System.Windows.Forms.Button ClearPhraseToPreserveListButton;
        private System.Windows.Forms.TextBox AddPhraseToPreserveTextBox;
        private System.Windows.Forms.Label PhraseToPreserveLabel;
        private System.Windows.Forms.ColumnHeader PhrasesToPreserveHeader;
        private System.Windows.Forms.TextBox AddPhraseToRemoveTextBox;
        private System.Windows.Forms.Button AddPhraseToRemoveButton;
        private System.Windows.Forms.Button ClearPhraseToRemoveListButton;
        private System.Windows.Forms.Button RemovePhraseToRemoveButton;
        private System.Windows.Forms.Label PhraseToRemoveLabel;
        private BufferedListView PhraseToRemoveListForParenthesisPanel;
        private System.Windows.Forms.ColumnHeader PhrasesToRemoveHeader;
        private System.Windows.Forms.ColumnHeader PhraseHeader;
    }
}