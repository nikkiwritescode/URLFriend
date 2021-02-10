using URLfriend.FileList;

namespace URLfriend.Panels
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FileNameList = new URLfriend.FileList.BufferedListView();
            this.url = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.progress = new System.Windows.Forms.ColumnHeader();
            this.outputfilename = new System.Windows.Forms.ColumnHeader();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.ReadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.removeParenthesisCheckbox = new System.Windows.Forms.CheckBox();
            this.RemoveCharacterReferencesCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBoxFileNamePadding = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveSpacesCheckbox = new System.Windows.Forms.CheckBox();
            this.ConfigureCharacterReferencesButton = new System.Windows.Forms.Button();
            this.ConfigureParenthesisTextRemoval = new System.Windows.Forms.Button();
            this.ConfigureDoubleSpaceRemovalButton = new System.Windows.Forms.Button();
            this.DownloadAllButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.groupBoxConfigureOutput = new System.Windows.Forms.GroupBox();
            this.SetOutputDirectoryLabel = new System.Windows.Forms.Label();
            this.SetOutputDirectoryButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBoxFileNamePadding.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxConfigureOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameList
            // 
            this.FileNameList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.FileNameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.url,
            this.Status,
            this.progress,
            this.outputfilename});
            this.FileNameList.Cursor = System.Windows.Forms.Cursors.Default;
            this.FileNameList.FullRowSelect = true;
            this.FileNameList.HideSelection = false;
            this.FileNameList.Location = new System.Drawing.Point(12, 193);
            this.FileNameList.Name = "FileNameList";
            this.FileNameList.Size = new System.Drawing.Size(1460, 556);
            this.FileNameList.TabIndex = 0;
            this.FileNameList.UseCompatibleStateImageBehavior = false;
            this.FileNameList.View = System.Windows.Forms.View.Details;
            // 
            // url
            // 
            this.url.Name = "url";
            this.url.Text = "URL";
            this.url.Width = 650;
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 100;
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Text = "Progress";
            this.progress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.progress.Width = 200;
            // 
            // outputfilename
            // 
            this.outputfilename.Name = "outputfilename";
            this.outputfilename.Text = "Output File Name";
            this.outputfilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.outputfilename.Width = 500;
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(18, 154);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(160, 33);
            this.ReadFileButton.TabIndex = 1;
            this.ReadFileButton.Text = "Read File (.txt)";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // ReadFileDialog
            // 
            this.ReadFileDialog.FileName = "openFileDialog1";
            // 
            // removeParenthesisCheckbox
            // 
            this.removeParenthesisCheckbox.AutoSize = true;
            this.removeParenthesisCheckbox.Checked = true;
            this.removeParenthesisCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeParenthesisCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeParenthesisCheckbox.Location = new System.Drawing.Point(3, 33);
            this.removeParenthesisCheckbox.Name = "removeParenthesisCheckbox";
            this.removeParenthesisCheckbox.Size = new System.Drawing.Size(204, 24);
            this.removeParenthesisCheckbox.TabIndex = 2;
            this.removeParenthesisCheckbox.Text = "Remove Text Between Parenthesis";
            this.removeParenthesisCheckbox.UseVisualStyleBackColor = true;
            // 
            // RemoveCharacterReferencesCheckbox
            // 
            this.RemoveCharacterReferencesCheckbox.AutoSize = true;
            this.RemoveCharacterReferencesCheckbox.Checked = true;
            this.RemoveCharacterReferencesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveCharacterReferencesCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveCharacterReferencesCheckbox.Location = new System.Drawing.Point(3, 3);
            this.RemoveCharacterReferencesCheckbox.Name = "RemoveCharacterReferencesCheckbox";
            this.RemoveCharacterReferencesCheckbox.Size = new System.Drawing.Size(183, 24);
            this.RemoveCharacterReferencesCheckbox.TabIndex = 3;
            this.RemoveCharacterReferencesCheckbox.Text = "Remove Character References";
            this.RemoveCharacterReferencesCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBoxFileNamePadding
            // 
            this.groupBoxFileNamePadding.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxFileNamePadding.Location = new System.Drawing.Point(12, 27);
            this.groupBoxFileNamePadding.Name = "groupBoxFileNamePadding";
            this.groupBoxFileNamePadding.Size = new System.Drawing.Size(340, 121);
            this.groupBoxFileNamePadding.TabIndex = 4;
            this.groupBoxFileNamePadding.TabStop = false;
            this.groupBoxFileNamePadding.Text = "Output Filename Manipulation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.RemoveSpacesCheckbox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.removeParenthesisCheckbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RemoveCharacterReferencesCheckbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConfigureCharacterReferencesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConfigureParenthesisTextRemoval, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConfigureDoubleSpaceRemovalButton, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 91);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // RemoveSpacesCheckbox
            // 
            this.RemoveSpacesCheckbox.AutoSize = true;
            this.RemoveSpacesCheckbox.Checked = true;
            this.RemoveSpacesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RemoveSpacesCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveSpacesCheckbox.Location = new System.Drawing.Point(3, 63);
            this.RemoveSpacesCheckbox.Name = "RemoveSpacesCheckbox";
            this.RemoveSpacesCheckbox.Size = new System.Drawing.Size(149, 25);
            this.RemoveSpacesCheckbox.TabIndex = 4;
            this.RemoveSpacesCheckbox.Text = "Remove Double Spaces";
            this.RemoveSpacesCheckbox.UseVisualStyleBackColor = true;
            // 
            // ConfigureCharacterReferencesButton
            // 
            this.ConfigureCharacterReferencesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigureCharacterReferencesButton.Location = new System.Drawing.Point(217, 3);
            this.ConfigureCharacterReferencesButton.Name = "ConfigureCharacterReferencesButton";
            this.ConfigureCharacterReferencesButton.Size = new System.Drawing.Size(110, 24);
            this.ConfigureCharacterReferencesButton.TabIndex = 5;
            this.ConfigureCharacterReferencesButton.Text = "Configure";
            this.ConfigureCharacterReferencesButton.UseVisualStyleBackColor = true;
            this.ConfigureCharacterReferencesButton.Click += new System.EventHandler(this.ConfigureCharacterReferencesButton_Click);
            // 
            // ConfigureParenthesisTextRemoval
            // 
            this.ConfigureParenthesisTextRemoval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigureParenthesisTextRemoval.Location = new System.Drawing.Point(217, 33);
            this.ConfigureParenthesisTextRemoval.Name = "ConfigureParenthesisTextRemoval";
            this.ConfigureParenthesisTextRemoval.Size = new System.Drawing.Size(110, 24);
            this.ConfigureParenthesisTextRemoval.TabIndex = 6;
            this.ConfigureParenthesisTextRemoval.Text = "Configure";
            this.ConfigureParenthesisTextRemoval.UseVisualStyleBackColor = true;
            this.ConfigureParenthesisTextRemoval.Click += new System.EventHandler(this.ConfigureParenthesisTextRemoval_Click);
            // 
            // ConfigureDoubleSpaceRemovalButton
            // 
            this.ConfigureDoubleSpaceRemovalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigureDoubleSpaceRemovalButton.Location = new System.Drawing.Point(217, 63);
            this.ConfigureDoubleSpaceRemovalButton.Name = "ConfigureDoubleSpaceRemovalButton";
            this.ConfigureDoubleSpaceRemovalButton.Size = new System.Drawing.Size(110, 25);
            this.ConfigureDoubleSpaceRemovalButton.TabIndex = 7;
            this.ConfigureDoubleSpaceRemovalButton.Text = "Configure";
            this.ConfigureDoubleSpaceRemovalButton.UseVisualStyleBackColor = true;
            this.ConfigureDoubleSpaceRemovalButton.Click += new System.EventHandler(this.ConfigureDoubleSpaceRemovalButton_Click);
            // 
            // DownloadAllButton
            // 
            this.DownloadAllButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DownloadAllButton.Location = new System.Drawing.Point(1270, 33);
            this.DownloadAllButton.Name = "DownloadAllButton";
            this.DownloadAllButton.Size = new System.Drawing.Size(202, 154);
            this.DownloadAllButton.TabIndex = 5;
            this.DownloadAllButton.Text = "Download All Files";
            this.DownloadAllButton.UseVisualStyleBackColor = true;
            this.DownloadAllButton.Click += new System.EventHandler(this.DownloadAllButton_Clicked);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(188, 154);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(160, 33);
            this.ClearListButton.TabIndex = 6;
            this.ClearListButton.Text = "Clear List";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // groupBoxConfigureOutput
            // 
            this.groupBoxConfigureOutput.Controls.Add(this.SetOutputDirectoryLabel);
            this.groupBoxConfigureOutput.Location = new System.Drawing.Point(360, 27);
            this.groupBoxConfigureOutput.Name = "groupBoxConfigureOutput";
            this.groupBoxConfigureOutput.Size = new System.Drawing.Size(904, 121);
            this.groupBoxConfigureOutput.TabIndex = 7;
            this.groupBoxConfigureOutput.TabStop = false;
            this.groupBoxConfigureOutput.Text = "Output Directory";
            // 
            // SetOutputDirectoryLabel
            // 
            this.SetOutputDirectoryLabel.AutoSize = true;
            this.SetOutputDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetOutputDirectoryLabel.Location = new System.Drawing.Point(6, 25);
            this.SetOutputDirectoryLabel.MinimumSize = new System.Drawing.Size(895, 80);
            this.SetOutputDirectoryLabel.Name = "SetOutputDirectoryLabel";
            this.SetOutputDirectoryLabel.Size = new System.Drawing.Size(895, 80);
            this.SetOutputDirectoryLabel.TabIndex = 1;
            this.SetOutputDirectoryLabel.Text = "No Directory Selected";
            this.SetOutputDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetOutputDirectoryButton
            // 
            this.SetOutputDirectoryButton.Location = new System.Drawing.Point(733, 154);
            this.SetOutputDirectoryButton.Name = "SetOutputDirectoryButton";
            this.SetOutputDirectoryButton.Size = new System.Drawing.Size(160, 33);
            this.SetOutputDirectoryButton.TabIndex = 0;
            this.SetOutputDirectoryButton.Text = "Set Output Directory";
            this.SetOutputDirectoryButton.UseVisualStyleBackColor = true;
            this.SetOutputDirectoryButton.Click += new System.EventHandler(this.SetOutputDirectoryButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.OptionsMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemeMenuItem});
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Size = new System.Drawing.Size(61, 20);
            this.OptionsMenuItem.Text = "Options";
            // 
            // ThemeMenuItem
            // 
            this.ThemeMenuItem.Name = "ThemeMenuItem";
            this.ThemeMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ThemeMenuItem.Text = "Theme";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AboutMenuItem.Text = "About...";
            this.AboutMenuItem.Click += new System.EventHandler(this.OpenAboutWindow);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SetOutputDirectoryButton);
            this.Controls.Add(this.groupBoxConfigureOutput);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.DownloadAllButton);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.FileNameList);
            this.Controls.Add(this.groupBoxFileNamePadding);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "URLfriend 1.0.0 alpha ";
            this.groupBoxFileNamePadding.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxConfigureOutput.ResumeLayout(false);
            this.groupBoxConfigureOutput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public BufferedListView FileNameList;
        private System.Windows.Forms.ColumnHeader url;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader outputfilename;
        public System.Windows.Forms.Button ReadFileButton;
        public System.Windows.Forms.OpenFileDialog ReadFileDialog;
        public System.Windows.Forms.CheckBox removeParenthesisCheckbox;
        public System.Windows.Forms.CheckBox RemoveCharacterReferencesCheckbox;
        public System.Windows.Forms.GroupBox groupBoxFileNamePadding;
        public System.Windows.Forms.Button DownloadAllButton;
        public System.Windows.Forms.Button ClearListButton;
        public System.Windows.Forms.GroupBox groupBoxConfigureOutput;
        public System.Windows.Forms.Label SetOutputDirectoryLabel;
        public System.Windows.Forms.Button SetOutputDirectoryButton;
        public System.Windows.Forms.CheckBox RemoveSpacesCheckbox;
        private System.Windows.Forms.ColumnHeader Status;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        public System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        public System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ThemeMenuItem;
        public System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button ConfigureCharacterReferencesButton;
        public System.Windows.Forms.Button ConfigureParenthesisTextRemoval;
        public System.Windows.Forms.Button ConfigureDoubleSpaceRemovalButton;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

