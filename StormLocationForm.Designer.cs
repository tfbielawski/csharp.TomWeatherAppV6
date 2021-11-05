namespace TomWeatherApp
{
    partial class StormLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StormLocationForm));
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topInfoLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.longitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.latitudeGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsGroupBox.SuspendLayout();
            this.longitudeGroupBox.SuspendLayout();
            this.latitudeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.latitudeTextBox.Location = new System.Drawing.Point(6, 30);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(181, 20);
            this.latitudeTextBox.TabIndex = 1;
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.longitudeTextBox.Location = new System.Drawing.Point(6, 29);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(181, 20);
            this.longitudeTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(147, 316);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(192, 47);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "S&UBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(345, 316);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 47);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(432, 316);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 47);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "E&XIT";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsLabel.Location = new System.Drawing.Point(6, 16);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(149, 137);
            this.resultsLabel.TabIndex = 1;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 95);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n9/12/2020\r\nCOP2360C FSCJ Professo" +
    "r Gehrig\r\nModified 11/25/2020";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topInfoLabel
            // 
            this.topInfoLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topInfoLabel.Location = new System.Drawing.Point(147, 27);
            this.topInfoLabel.Name = "topInfoLabel";
            this.topInfoLabel.Size = new System.Drawing.Size(360, 52);
            this.topInfoLabel.TabIndex = 1;
            this.topInfoLabel.Text = "Tom\'s C# Weather App\r\nStorm Location Form";
            this.topInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultsLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(346, 127);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(161, 165);
            this.resultsGroupBox.TabIndex = 7;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "View Results";
            // 
            // longitudeGroupBox
            // 
            this.longitudeGroupBox.Controls.Add(this.longitudeTextBox);
            this.longitudeGroupBox.Location = new System.Drawing.Point(147, 217);
            this.longitudeGroupBox.Name = "longitudeGroupBox";
            this.longitudeGroupBox.Size = new System.Drawing.Size(193, 75);
            this.longitudeGroupBox.TabIndex = 3;
            this.longitudeGroupBox.TabStop = false;
            this.longitudeGroupBox.Text = "Enter Longitude";
            // 
            // latitudeGroupBox
            // 
            this.latitudeGroupBox.Controls.Add(this.latitudeTextBox);
            this.latitudeGroupBox.Location = new System.Drawing.Point(147, 127);
            this.latitudeGroupBox.Name = "latitudeGroupBox";
            this.latitudeGroupBox.Size = new System.Drawing.Size(193, 75);
            this.latitudeGroupBox.TabIndex = 2;
            this.latitudeGroupBox.TabStop = false;
            this.latitudeGroupBox.Text = "Enter Latitude";
            // 
            // StormLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(631, 531);
            this.Controls.Add(this.latitudeGroupBox);
            this.Controls.Add(this.longitudeGroupBox);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.topInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.DoubleBuffered = true;
            this.Name = "StormLocationForm";
            this.Text = "Location Form";
            this.resultsGroupBox.ResumeLayout(false);
            this.longitudeGroupBox.ResumeLayout(false);
            this.longitudeGroupBox.PerformLayout();
            this.latitudeGroupBox.ResumeLayout(false);
            this.latitudeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label topInfoLabel;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.GroupBox longitudeGroupBox;
        private System.Windows.Forms.GroupBox latitudeGroupBox;
    }
}