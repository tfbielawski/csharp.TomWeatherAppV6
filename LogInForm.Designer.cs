namespace TomWeatherApp
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logInTopLabel = new System.Windows.Forms.Label();
            this.devCreditLabel = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(19, 182);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(71, 76);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "S&UBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(96, 182);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 33);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(6, 31);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.HideSelection = false;
            this.passwordTextBox.Location = new System.Drawing.Point(6, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(143, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(97, 225);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(78, 33);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "CL&OSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginGroupBox.Controls.Add(this.groupBox3);
            this.loginGroupBox.Controls.Add(this.groupBox2);
            this.loginGroupBox.Controls.Add(this.groupBox1);
            this.loginGroupBox.Controls.Add(this.closeButton);
            this.loginGroupBox.Controls.Add(this.submitButton);
            this.loginGroupBox.Controls.Add(this.clearButton);
            this.loginGroupBox.Location = new System.Drawing.Point(33, 148);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(362, 264);
            this.loginGroupBox.TabIndex = 2;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Log In";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultsLabel);
            this.groupBox3.Location = new System.Drawing.Point(180, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 236);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log-in Results";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.resultsLabel.Location = new System.Drawing.Point(6, 16);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(143, 217);
            this.resultsLabel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Location = new System.Drawing.Point(19, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Name";
            // 
            // logInTopLabel
            // 
            this.logInTopLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logInTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logInTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInTopLabel.Location = new System.Drawing.Point(33, 22);
            this.logInTopLabel.Name = "logInTopLabel";
            this.logInTopLabel.Size = new System.Drawing.Size(354, 88);
            this.logInTopLabel.TabIndex = 1;
            this.logInTopLabel.Text = "Tom\'s C# Weather App\r\nLog-In Form\r\nAdministrators Only!";
            this.logInTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devCreditLabel
            // 
            this.devCreditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.devCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devCreditLabel.Location = new System.Drawing.Point(130, 416);
            this.devCreditLabel.Name = "devCreditLabel";
            this.devCreditLabel.Size = new System.Drawing.Size(176, 95);
            this.devCreditLabel.TabIndex = 3;
            this.devCreditLabel.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n11/13/2020\r\nCOP2360C FSCJ Profess" +
    "or Gehrig\r\nUpdated 11/25/2020";
            this.devCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 520);
            this.Controls.Add(this.devCreditLabel);
            this.Controls.Add(this.logInTopLabel);
            this.Controls.Add(this.loginGroupBox);
            this.DoubleBuffered = true;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-In Form";
            this.loginGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label logInTopLabel;
        private System.Windows.Forms.Label devCreditLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label resultsLabel;
    }
}