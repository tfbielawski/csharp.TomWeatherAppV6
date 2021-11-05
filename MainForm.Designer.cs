namespace TomWeatherApp
{
    partial class WeatherAppForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherAppForm));
            this.topInfoLabel = new System.Windows.Forms.Label();
            this.userMessageLabel = new System.Windows.Forms.Label();
            this.locationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.devCreditLabel = new System.Windows.Forms.Label();
            this.stormButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.stormDataButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stormFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stormArchiveFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stormDataFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stormLocationFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stormNameMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stormDataMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contactInfobutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.viewResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topInfoLabel
            // 
            this.topInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topInfoLabel.Location = new System.Drawing.Point(108, 49);
            this.topInfoLabel.Name = "topInfoLabel";
            this.topInfoLabel.Size = new System.Drawing.Size(350, 54);
            this.topInfoLabel.TabIndex = 2;
            this.topInfoLabel.Text = "Tom\'s C# Weather App\r\nMain Form";
            this.topInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userMessageLabel
            // 
            this.userMessageLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userMessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userMessageLabel.Location = new System.Drawing.Point(13, 16);
            this.userMessageLabel.Name = "userMessageLabel";
            this.userMessageLabel.Size = new System.Drawing.Size(165, 174);
            this.userMessageLabel.TabIndex = 1;
            this.userMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationButton
            // 
            this.locationButton.Location = new System.Drawing.Point(189, 332);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(75, 52);
            this.locationButton.TabIndex = 6;
            this.locationButton.Text = "STORM LO&CATION";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(189, 396);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 52);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&XIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // devCreditLabel
            // 
            this.devCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devCreditLabel.Location = new System.Drawing.Point(186, 518);
            this.devCreditLabel.Name = "devCreditLabel";
            this.devCreditLabel.Size = new System.Drawing.Size(181, 73);
            this.devCreditLabel.TabIndex = 10;
            this.devCreditLabel.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n9/12/2020\r\nCOP2360C FSCJ Professo" +
    "r Gehrig\r\nUpdated 11/24/2020";
            this.devCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stormButton
            // 
            this.stormButton.Location = new System.Drawing.Point(108, 255);
            this.stormButton.Name = "stormButton";
            this.stormButton.Size = new System.Drawing.Size(75, 52);
            this.stormButton.TabIndex = 3;
            this.stormButton.Text = "S&TORM";
            this.stormButton.UseVisualStyleBackColor = true;
            this.stormButton.Click += new System.EventHandler(this.stormButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(189, 255);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(75, 52);
            this.archiveButton.TabIndex = 4;
            this.archiveButton.Text = "STORM A&RCHIVE";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // stormDataButton
            // 
            this.stormDataButton.Location = new System.Drawing.Point(108, 332);
            this.stormDataButton.Name = "stormDataButton";
            this.stormDataButton.Size = new System.Drawing.Size(75, 52);
            this.stormDataButton.TabIndex = 5;
            this.stormDataButton.Text = "ST&ORM DATA";
            this.stormDataButton.UseVisualStyleBackColor = true;
            this.stormDataButton.Click += new System.EventHandler(this.stormDataButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFormToolStripMenuItem
            // 
            this.openFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stormFormToolStripMenuItem1,
            this.stormArchiveFormToolStripMenuItem,
            this.stormDataFormToolStripMenuItem,
            this.stormLocationFormToolStripMenuItem});
            this.openFormToolStripMenuItem.Name = "openFormToolStripMenuItem";
            this.openFormToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openFormToolStripMenuItem.Text = "Open Form";
            // 
            // stormFormToolStripMenuItem1
            // 
            this.stormFormToolStripMenuItem1.Name = "stormFormToolStripMenuItem1";
            this.stormFormToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.stormFormToolStripMenuItem1.Text = "Storm Form";
            this.stormFormToolStripMenuItem1.Click += new System.EventHandler(this.stormButton_Click);
            // 
            // stormArchiveFormToolStripMenuItem
            // 
            this.stormArchiveFormToolStripMenuItem.Name = "stormArchiveFormToolStripMenuItem";
            this.stormArchiveFormToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.stormArchiveFormToolStripMenuItem.Text = "Storm Archive Form";
            this.stormArchiveFormToolStripMenuItem.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // stormDataFormToolStripMenuItem
            // 
            this.stormDataFormToolStripMenuItem.Name = "stormDataFormToolStripMenuItem";
            this.stormDataFormToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.stormDataFormToolStripMenuItem.Text = "Storm Data Form";
            this.stormDataFormToolStripMenuItem.Click += new System.EventHandler(this.stormDataButton_Click);
            // 
            // stormLocationFormToolStripMenuItem
            // 
            this.stormLocationFormToolStripMenuItem.Name = "stormLocationFormToolStripMenuItem";
            this.stormLocationFormToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.stormLocationFormToolStripMenuItem.Text = "Storm Location Form";
            this.stormLocationFormToolStripMenuItem.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisProgramToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutThisProgramToolStripMenuItem
            // 
            this.aboutThisProgramToolStripMenuItem.Name = "aboutThisProgramToolStripMenuItem";
            this.aboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutThisProgramToolStripMenuItem.Text = "About this Program";
            this.aboutThisProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutThisProgramToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem1,
            this.logOutToolStripMenuItem,
            this.contactInfoToolStripMenuItem,
            this.stormNameMaintenanceToolStripMenuItem,
            this.stormDataMaintenanceToolStripMenuItem});
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.logInToolStripMenuItem.Text = "Maintenance";
            // 
            // logInToolStripMenuItem1
            // 
            this.logInToolStripMenuItem1.Name = "logInToolStripMenuItem1";
            this.logInToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.logInToolStripMenuItem1.Text = "Log-In";
            this.logInToolStripMenuItem1.Click += new System.EventHandler(this.logInToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.logOutToolStripMenuItem.Text = "Log-Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // contactInfoToolStripMenuItem
            // 
            this.contactInfoToolStripMenuItem.Name = "contactInfoToolStripMenuItem";
            this.contactInfoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contactInfoToolStripMenuItem.Text = "Contact Info";
            this.contactInfoToolStripMenuItem.Click += new System.EventHandler(this.contactInfoToolStripMenuItem_Click);
            // 
            // stormNameMaintenanceToolStripMenuItem
            // 
            this.stormNameMaintenanceToolStripMenuItem.Name = "stormNameMaintenanceToolStripMenuItem";
            this.stormNameMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.stormNameMaintenanceToolStripMenuItem.Text = "Storm Name Maintenance";
            // 
            // stormDataMaintenanceToolStripMenuItem
            // 
            this.stormDataMaintenanceToolStripMenuItem.Name = "stormDataMaintenanceToolStripMenuItem";
            this.stormDataMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.stormDataMaintenanceToolStripMenuItem.Text = "Storm Data Maintenance";
            // 
            // viewResultsGroupBox
            // 
            this.viewResultsGroupBox.Controls.Add(this.userMessageLabel);
            this.viewResultsGroupBox.Location = new System.Drawing.Point(270, 255);
            this.viewResultsGroupBox.Name = "viewResultsGroupBox";
            this.viewResultsGroupBox.Size = new System.Drawing.Size(188, 193);
            this.viewResultsGroupBox.TabIndex = 9;
            this.viewResultsGroupBox.TabStop = false;
            this.viewResultsGroupBox.Text = "View Results";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contactInfobutton
            // 
            this.contactInfobutton.Location = new System.Drawing.Point(108, 396);
            this.contactInfobutton.Name = "contactInfobutton";
            this.contactInfobutton.Size = new System.Drawing.Size(75, 52);
            this.contactInfobutton.TabIndex = 7;
            this.contactInfobutton.Text = "CONTACT IN&FO";
            this.contactInfobutton.UseVisualStyleBackColor = true;
            this.contactInfobutton.Click += new System.EventHandler(this.contactInfobutton_Click);
            // 
            // WeatherAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(558, 617);
            this.Controls.Add(this.contactInfobutton);
            this.Controls.Add(this.viewResultsGroupBox);
            this.Controls.Add(this.stormDataButton);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.stormButton);
            this.Controls.Add(this.devCreditLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.topInfoLabel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WeatherAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tom\'s Weather App";
            this.Load += new System.EventHandler(this.WeatherAppForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.viewResultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topInfoLabel;
        private System.Windows.Forms.Label userMessageLabel;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label devCreditLabel;
        private System.Windows.Forms.Button stormButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button stormDataButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisProgramToolStripMenuItem;
        private System.Windows.Forms.GroupBox viewResultsGroupBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stormFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stormArchiveFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stormDataFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stormLocationFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button contactInfobutton;
        public System.Windows.Forms.ToolStripMenuItem contactInfoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem stormNameMaintenanceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem stormDataMaintenanceToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

