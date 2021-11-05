namespace TomWeatherApp
{
    partial class StormArchiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StormArchiveForm));
            this.label1 = new System.Windows.Forms.Label();
            this.archiveStormResultsLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.maxWindSpeedTextBox = new System.Windows.Forms.TextBox();
            this.archivedStormNameTextBox = new System.Windows.Forms.TextBox();
            this.archiveTopLabel = new System.Windows.Forms.Label();
            this.listMonths = new System.Windows.Forms.ListBox();
            this.listDays = new System.Windows.Forms.ListBox();
            this.listYears = new System.Windows.Forms.ListBox();
            this.listMonthsEnd = new System.Windows.Forms.ListBox();
            this.listDaysEnd = new System.Windows.Forms.ListBox();
            this.listYearsEnd = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endDateGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.stormNameGroupBox = new System.Windows.Forms.GroupBox();
            this.windSpeedGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.endDateGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.stormNameGroupBox.SuspendLayout();
            this.windSpeedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n10/18/2020\r\nCOP2360C FSCJ Profess" +
    "or Gehrig\r\nModified 11/25/2020";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // archiveStormResultsLabel
            // 
            this.archiveStormResultsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.archiveStormResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.archiveStormResultsLabel.Location = new System.Drawing.Point(11, 16);
            this.archiveStormResultsLabel.Name = "archiveStormResultsLabel";
            this.archiveStormResultsLabel.Size = new System.Drawing.Size(167, 106);
            this.archiveStormResultsLabel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(195, 550);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(92, 50);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "C&lose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(94, 550);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 50);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(94, 494);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(193, 50);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "S&ubmit Data";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // maxWindSpeedTextBox
            // 
            this.maxWindSpeedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxWindSpeedTextBox.Location = new System.Drawing.Point(31, 35);
            this.maxWindSpeedTextBox.Name = "maxWindSpeedTextBox";
            this.maxWindSpeedTextBox.Size = new System.Drawing.Size(374, 20);
            this.maxWindSpeedTextBox.TabIndex = 1;
            // 
            // archivedStormNameTextBox
            // 
            this.archivedStormNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.archivedStormNameTextBox.Location = new System.Drawing.Point(31, 34);
            this.archivedStormNameTextBox.Name = "archivedStormNameTextBox";
            this.archivedStormNameTextBox.Size = new System.Drawing.Size(374, 20);
            this.archivedStormNameTextBox.TabIndex = 1;
            // 
            // archiveTopLabel
            // 
            this.archiveTopLabel.AutoSize = true;
            this.archiveTopLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.archiveTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.archiveTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveTopLabel.Location = new System.Drawing.Point(195, 45);
            this.archiveTopLabel.Name = "archiveTopLabel";
            this.archiveTopLabel.Size = new System.Drawing.Size(235, 52);
            this.archiveTopLabel.TabIndex = 1;
            this.archiveTopLabel.Text = "Tom\'s C# Weather App\r\nStorm Archive Form";
            this.archiveTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listMonths
            // 
            this.listMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMonths.FormattingEnabled = true;
            this.listMonths.ItemHeight = 16;
            this.listMonths.Location = new System.Drawing.Point(6, 19);
            this.listMonths.Name = "listMonths";
            this.listMonths.Size = new System.Drawing.Size(32, 52);
            this.listMonths.TabIndex = 1;
            // 
            // listDays
            // 
            this.listDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDays.FormattingEnabled = true;
            this.listDays.ItemHeight = 16;
            this.listDays.Location = new System.Drawing.Point(63, 19);
            this.listDays.Name = "listDays";
            this.listDays.Size = new System.Drawing.Size(32, 52);
            this.listDays.TabIndex = 2;
            // 
            // listYears
            // 
            this.listYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listYears.FormattingEnabled = true;
            this.listYears.ItemHeight = 16;
            this.listYears.Location = new System.Drawing.Point(115, 19);
            this.listYears.Name = "listYears";
            this.listYears.Size = new System.Drawing.Size(63, 52);
            this.listYears.TabIndex = 3;
            // 
            // listMonthsEnd
            // 
            this.listMonthsEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMonthsEnd.FormattingEnabled = true;
            this.listMonthsEnd.ItemHeight = 16;
            this.listMonthsEnd.Location = new System.Drawing.Point(6, 19);
            this.listMonthsEnd.Name = "listMonthsEnd";
            this.listMonthsEnd.Size = new System.Drawing.Size(32, 52);
            this.listMonthsEnd.TabIndex = 1;
            // 
            // listDaysEnd
            // 
            this.listDaysEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDaysEnd.FormattingEnabled = true;
            this.listDaysEnd.ItemHeight = 16;
            this.listDaysEnd.Location = new System.Drawing.Point(63, 19);
            this.listDaysEnd.Name = "listDaysEnd";
            this.listDaysEnd.Size = new System.Drawing.Size(32, 52);
            this.listDaysEnd.TabIndex = 2;
            // 
            // listYearsEnd
            // 
            this.listYearsEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listYearsEnd.FormattingEnabled = true;
            this.listYearsEnd.ItemHeight = 16;
            this.listYearsEnd.Location = new System.Drawing.Point(115, 19);
            this.listYearsEnd.Name = "listYearsEnd";
            this.listYearsEnd.Size = new System.Drawing.Size(63, 52);
            this.listYearsEnd.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listYears);
            this.groupBox1.Controls.Add(this.listDays);
            this.groupBox1.Controls.Add(this.listMonths);
            this.groupBox1.Location = new System.Drawing.Point(94, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter the Storm\'s Begin Date";
            // 
            // endDateGroupBox
            // 
            this.endDateGroupBox.Controls.Add(this.listMonthsEnd);
            this.endDateGroupBox.Controls.Add(this.listDaysEnd);
            this.endDateGroupBox.Controls.Add(this.listYearsEnd);
            this.endDateGroupBox.Location = new System.Drawing.Point(321, 371);
            this.endDateGroupBox.Name = "endDateGroupBox";
            this.endDateGroupBox.Size = new System.Drawing.Size(193, 79);
            this.endDateGroupBox.TabIndex = 5;
            this.endDateGroupBox.TabStop = false;
            this.endDateGroupBox.Text = "Enter the Storm\'s End Date";
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.archiveStormResultsLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(321, 476);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(193, 136);
            this.resultsGroupBox.TabIndex = 9;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "View Results";
            // 
            // stormNameGroupBox
            // 
            this.stormNameGroupBox.Controls.Add(this.archivedStormNameTextBox);
            this.stormNameGroupBox.Location = new System.Drawing.Point(94, 151);
            this.stormNameGroupBox.Name = "stormNameGroupBox";
            this.stormNameGroupBox.Size = new System.Drawing.Size(420, 75);
            this.stormNameGroupBox.TabIndex = 2;
            this.stormNameGroupBox.TabStop = false;
            this.stormNameGroupBox.Text = "Enter the Archived Storm\'s Name";
            // 
            // windSpeedGroupBox
            // 
            this.windSpeedGroupBox.Controls.Add(this.maxWindSpeedTextBox);
            this.windSpeedGroupBox.Location = new System.Drawing.Point(94, 265);
            this.windSpeedGroupBox.Name = "windSpeedGroupBox";
            this.windSpeedGroupBox.Size = new System.Drawing.Size(420, 75);
            this.windSpeedGroupBox.TabIndex = 3;
            this.windSpeedGroupBox.TabStop = false;
            this.windSpeedGroupBox.Text = "Enter the Archived Storm\'s Max Windspeed";
            // 
            // StormArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(625, 706);
            this.Controls.Add(this.windSpeedGroupBox);
            this.Controls.Add(this.stormNameGroupBox);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.endDateGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.archiveTopLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.DoubleBuffered = true;
            this.Name = "StormArchiveForm";
            this.Text = "Storm Archive Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.endDateGroupBox.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.stormNameGroupBox.ResumeLayout(false);
            this.stormNameGroupBox.PerformLayout();
            this.windSpeedGroupBox.ResumeLayout(false);
            this.windSpeedGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label archiveStormResultsLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox maxWindSpeedTextBox;
        private System.Windows.Forms.TextBox archivedStormNameTextBox;
        private System.Windows.Forms.Label archiveTopLabel;
        private System.Windows.Forms.ListBox listMonths;
        private System.Windows.Forms.ListBox listDays;
        private System.Windows.Forms.ListBox listYears;
        private System.Windows.Forms.ListBox listMonthsEnd;
        private System.Windows.Forms.ListBox listDaysEnd;
        private System.Windows.Forms.ListBox listYearsEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox endDateGroupBox;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.GroupBox stormNameGroupBox;
        private System.Windows.Forms.GroupBox windSpeedGroupBox;
    }
}