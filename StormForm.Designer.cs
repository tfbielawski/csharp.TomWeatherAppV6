namespace TomWeatherApp
{
    partial class StormForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StormForm));
            this.stormNameTextBox = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.longTextBox = new System.Windows.Forms.TextBox();
            this.windSpeedTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stormResultsLabel = new System.Windows.Forms.Label();
            this.topInfoLabel = new System.Windows.Forms.Label();
            this.viewResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.windSpeedGroupBox = new System.Windows.Forms.GroupBox();
            this.longitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.lattitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.stormNameGroupBox = new System.Windows.Forms.GroupBox();
            this.viewResultsGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.windSpeedGroupBox.SuspendLayout();
            this.longitudeGroupBox.SuspendLayout();
            this.lattitudeGroupBox.SuspendLayout();
            this.stormNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stormNameTextBox
            // 
            this.stormNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stormNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.stormNameTextBox.Name = "stormNameTextBox";
            this.stormNameTextBox.Size = new System.Drawing.Size(270, 20);
            this.stormNameTextBox.TabIndex = 1;
            // 
            // latTextBox
            // 
            this.latTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latTextBox.Location = new System.Drawing.Point(6, 19);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(266, 20);
            this.latTextBox.TabIndex = 1;
            // 
            // longTextBox
            // 
            this.longTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.longTextBox.Location = new System.Drawing.Point(8, 19);
            this.longTextBox.Name = "longTextBox";
            this.longTextBox.Size = new System.Drawing.Size(266, 20);
            this.longTextBox.TabIndex = 1;
            // 
            // windSpeedTextBox
            // 
            this.windSpeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windSpeedTextBox.Location = new System.Drawing.Point(8, 19);
            this.windSpeedTextBox.Name = "windSpeedTextBox";
            this.windSpeedTextBox.Size = new System.Drawing.Size(264, 20);
            this.windSpeedTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(85, 412);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(156, 47);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "S&UBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(85, 485);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 57);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(166, 485);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 57);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&XIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stormResultsLabel
            // 
            this.stormResultsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.stormResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stormResultsLabel.Location = new System.Drawing.Point(0, 16);
            this.stormResultsLabel.Name = "stormResultsLabel";
            this.stormResultsLabel.Size = new System.Drawing.Size(139, 133);
            this.stormResultsLabel.TabIndex = 1;
            // 
            // topInfoLabel
            // 
            this.topInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topInfoLabel.Location = new System.Drawing.Point(85, 23);
            this.topInfoLabel.Name = "topInfoLabel";
            this.topInfoLabel.Size = new System.Drawing.Size(301, 52);
            this.topInfoLabel.TabIndex = 1;
            this.topInfoLabel.Text = "Tom\'s C# Weather App\r\nStorm Form";
            this.topInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewResultsGroupBox
            // 
            this.viewResultsGroupBox.Controls.Add(this.stormResultsLabel);
            this.viewResultsGroupBox.Location = new System.Drawing.Point(247, 396);
            this.viewResultsGroupBox.Name = "viewResultsGroupBox";
            this.viewResultsGroupBox.Size = new System.Drawing.Size(139, 152);
            this.viewResultsGroupBox.TabIndex = 8;
            this.viewResultsGroupBox.TabStop = false;
            this.viewResultsGroupBox.Text = "View Results";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 89);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n10/4/2020\r\nCOP2360C FSCJ Professo" +
    "r Gehrig\r\nModified 11/25/2020";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.windSpeedGroupBox);
            this.controlGroupBox.Controls.Add(this.longitudeGroupBox);
            this.controlGroupBox.Controls.Add(this.lattitudeGroupBox);
            this.controlGroupBox.Controls.Add(this.stormNameGroupBox);
            this.controlGroupBox.Location = new System.Drawing.Point(85, 101);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(301, 269);
            this.controlGroupBox.TabIndex = 2;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Storm Form Controls";
            // 
            // windSpeedGroupBox
            // 
            this.windSpeedGroupBox.Controls.Add(this.windSpeedTextBox);
            this.windSpeedGroupBox.Location = new System.Drawing.Point(11, 205);
            this.windSpeedGroupBox.Name = "windSpeedGroupBox";
            this.windSpeedGroupBox.Size = new System.Drawing.Size(278, 53);
            this.windSpeedGroupBox.TabIndex = 4;
            this.windSpeedGroupBox.TabStop = false;
            this.windSpeedGroupBox.Text = "Enter the Storm\'s Wind Speed";
            // 
            // longitudeGroupBox
            // 
            this.longitudeGroupBox.Controls.Add(this.longTextBox);
            this.longitudeGroupBox.Location = new System.Drawing.Point(11, 147);
            this.longitudeGroupBox.Name = "longitudeGroupBox";
            this.longitudeGroupBox.Size = new System.Drawing.Size(278, 53);
            this.longitudeGroupBox.TabIndex = 3;
            this.longitudeGroupBox.TabStop = false;
            this.longitudeGroupBox.Text = "Enter the Longitude";
            // 
            // lattitudeGroupBox
            // 
            this.lattitudeGroupBox.Controls.Add(this.latTextBox);
            this.lattitudeGroupBox.Location = new System.Drawing.Point(11, 88);
            this.lattitudeGroupBox.Name = "lattitudeGroupBox";
            this.lattitudeGroupBox.Size = new System.Drawing.Size(278, 53);
            this.lattitudeGroupBox.TabIndex = 2;
            this.lattitudeGroupBox.TabStop = false;
            this.lattitudeGroupBox.Text = "Enter the Lattitude";
            // 
            // stormNameGroupBox
            // 
            this.stormNameGroupBox.Controls.Add(this.stormNameTextBox);
            this.stormNameGroupBox.Location = new System.Drawing.Point(9, 29);
            this.stormNameGroupBox.Name = "stormNameGroupBox";
            this.stormNameGroupBox.Size = new System.Drawing.Size(278, 53);
            this.stormNameGroupBox.TabIndex = 1;
            this.stormNameGroupBox.TabStop = false;
            this.stormNameGroupBox.Text = "Enter the Storm\'s Name";
            // 
            // StormForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(492, 665);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.viewResultsGroupBox);
            this.Controls.Add(this.topInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.DoubleBuffered = true;
            this.Name = "StormForm";
            this.Text = "Storm Form";
            this.viewResultsGroupBox.ResumeLayout(false);
            this.controlGroupBox.ResumeLayout(false);
            this.windSpeedGroupBox.ResumeLayout(false);
            this.windSpeedGroupBox.PerformLayout();
            this.longitudeGroupBox.ResumeLayout(false);
            this.longitudeGroupBox.PerformLayout();
            this.lattitudeGroupBox.ResumeLayout(false);
            this.lattitudeGroupBox.PerformLayout();
            this.stormNameGroupBox.ResumeLayout(false);
            this.stormNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox stormNameTextBox;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.TextBox longTextBox;
        private System.Windows.Forms.TextBox windSpeedTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label stormResultsLabel;
        private System.Windows.Forms.Label topInfoLabel;
        private System.Windows.Forms.GroupBox viewResultsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.GroupBox windSpeedGroupBox;
        private System.Windows.Forms.GroupBox longitudeGroupBox;
        private System.Windows.Forms.GroupBox lattitudeGroupBox;
        private System.Windows.Forms.GroupBox stormNameGroupBox;
    }
}