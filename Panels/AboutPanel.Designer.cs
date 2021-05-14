namespace URLfriend.Panels
{
    partial class AboutPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPanel));
            this.aboutOKButton = new System.Windows.Forms.Button();
            this.csmmNameLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.logoDark = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.logoLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLight)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutOKButton
            // 
            this.aboutOKButton.Location = new System.Drawing.Point(10, 109);
            this.aboutOKButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aboutOKButton.Name = "aboutOKButton";
            this.aboutOKButton.Size = new System.Drawing.Size(294, 34);
            this.aboutOKButton.TabIndex = 0;
            this.aboutOKButton.Text = "Close Window";
            this.aboutOKButton.UseVisualStyleBackColor = true;
            this.aboutOKButton.Click += new System.EventHandler(this.aboutOKButton_Click);
            // 
            // csmmNameLabel
            // 
            this.csmmNameLabel.AutoSize = true;
            this.csmmNameLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csmmNameLabel.Location = new System.Drawing.Point(142, 7);
            this.csmmNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.csmmNameLabel.Name = "csmmNameLabel";
            this.csmmNameLabel.Size = new System.Drawing.Size(142, 25);
            this.csmmNameLabel.TabIndex = 1;
            this.csmmNameLabel.Text = "URLfriend :)";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(142, 64);
            this.companyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(129, 15);
            this.companyLabel.TabIndex = 2;
            this.companyLabel.Text = "©2021 Nikkums House";
            // 
            // logoDark
            // 
            this.logoDark.Image = ((System.Drawing.Image)(resources.GetObject("logoDark.Image")));
            this.logoDark.Location = new System.Drawing.Point(10, 7);
            this.logoDark.Name = "logoDark";
            this.logoDark.Size = new System.Drawing.Size(98, 98);
            this.logoDark.TabIndex = 3;
            this.logoDark.TabStop = false;
            this.logoDark.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "A simple downloader app.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(157, 79);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://nikkums.io";
            // 
            // logoLight
            // 
            this.logoLight.Image = ((System.Drawing.Image)(resources.GetObject("logoLight.Image")));
            this.logoLight.Location = new System.Drawing.Point(12, 7);
            this.logoLight.Name = "logoLight";
            this.logoLight.Size = new System.Drawing.Size(98, 98);
            this.logoLight.TabIndex = 6;
            this.logoLight.TabStop = false;
            this.logoLight.Visible = false;
            // 
            // AboutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 155);
            this.Controls.Add(this.logoLight);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoDark);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.csmmNameLabel);
            this.Controls.Add(this.aboutOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "AboutPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About URLfriend";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.logoDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboutOKButton;
        private System.Windows.Forms.Label csmmNameLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.PictureBox logoDark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox logoLight;
    }
}