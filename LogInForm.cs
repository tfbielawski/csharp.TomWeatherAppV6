/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/13/2020
 * COP2360C Project 6: Weather App Log-In Form
 * Modified 11/25/2020
 * FSCJ Professor Gehrig*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomWeatherApp
{
    /// <summary>
    /// LogInForm 
    /// </summary>
    public partial class LogInForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public LogInForm()
        {
            InitializeComponent();

            //Populate the information label with user instructions
            resultsLabel.Text = "Please enter your user name and password." +
                Environment.NewLine +
                Environment.NewLine + "Click CLEAR to clear the fields at any time" +
                Environment.NewLine +
                Environment.NewLine + "Click CLOSE to return to the main form.";
            
        }

        /// <summary>
        /// Method to clear fields and return focus
        /// </summary>
        private void clearFields()
        {
            //Clear the fields
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            resultsLabel.ResetText();
            
            //Return the focus
            userNameTextBox.Focus();

            //Inform the user
            resultsLabel.Text = "Form cleared." + 
                Environment.NewLine + "Please enter your user name and password." +
                Environment.NewLine +
                Environment.NewLine + "Click CLEAR to clear the fields at any time" +
                Environment.NewLine +
                Environment.NewLine + "Click CLOSE to return to the main form.";
        }

        /// <summary>
        /// Submit button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Check to see if the user name matches and password does not
                if (userNameTextBox.Text.Trim() == string.Empty || passwordTextBox.Text.Trim() == string.Empty)
                {
                    //Warn the user
                    resultsLabel.Text = "Please enter your user name and your password." +
                        Environment.NewLine +
                        Environment.NewLine + "Do not leave either field blank.";

                    //Clear the user name text box and return the focus
                    userNameTextBox.Clear();
                    passwordTextBox.Clear();
                    userNameTextBox.Focus();
                }


                else if (userNameTextBox.Text.Trim() != "admin" || passwordTextBox.Text.Trim() != "password123")
                {
                    //Warn the user
                    resultsLabel.Text = "Invalid user name or password." +
                        Environment.NewLine +
                        Environment.NewLine + "Please check your entries and try again.";

                    //Clear the user name text box and return the focus
                    passwordTextBox.Clear();
                    userNameTextBox.Clear();
                    userNameTextBox.Focus();

                }


                //If both match
                else
                {
                    //If both user name and password match, enable the Main Form menu items
                    (Owner as WeatherAppForm).contactInfoToolStripMenuItem.Enabled = true;
                    (Owner as WeatherAppForm).logOutToolStripMenuItem.Enabled = true;
                    (Owner as WeatherAppForm).stormDataMaintenanceToolStripMenuItem.Enabled = true;
                    (Owner as WeatherAppForm).stormNameMaintenanceToolStripMenuItem.Enabled = true;

                    //Inform the user.
                    resultsLabel.Text = "You have successfully logged in!" +
                        Environment.NewLine +
                        Environment.NewLine + "You can now access extra Maintenance Menu items on the Main Form." +
                        Environment.NewLine +
                        Environment.NewLine + "Click CLOSE to return to the Main Form";
                }
            }

            catch (Exception ex)
            {
                string warningMessage = "Invalid data entered!";
                resultsLabel.Text = warningMessage + ex.Message;

            }

        }

        /// <summary>
        /// Clear Button Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the fields
            clearFields();

        }

        /// <summary>
        /// Close Button Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
            
        }

        
    }
}
