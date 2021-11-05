
/* TomWeatherApp.cs
 * Tom Bielawski
 * 10/4/2020 
 * COP2360C Project 6: Weather App Main Form
 * Modified 11/25/2020
 * FSCJ Professor Gherig*/


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
    /// WeatherAppForm class load
    /// </summary>
    public partial class WeatherAppForm : Form
    {
       
        /// <summary>
        /// Main Form constructor
        /// </summary>
        public WeatherAppForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Location button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locationButton_Click(object sender, EventArgs e)
        {
            //Clear the log out message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Intialize the new form 
            StormLocationForm locationForm = new StormLocationForm();

            //show the form
            locationForm.ShowDialog();
            
        }


        /// <summary>
        /// Exit Button-Click event handler to close the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application
            Close();
        }

        /// <summary>
        /// Storm Button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stormButton_Click(object sender, EventArgs e)
        {
            //Clear the log out message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Initialize new form 
            StormForm stormForm = new StormForm();

            //Show the form
            stormForm.ShowDialog();
        }

        /// <summary>
        /// Archive button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void archiveButton_Click(object sender, EventArgs e)
        {
            //Clear the logout message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Initialize new form 
            StormArchiveForm stormArchive = new StormArchiveForm();

            //Show the form
            stormArchive.ShowDialog();
           
        }

        /// <summary>
        /// Storm data button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stormDataButton_Click(object sender, EventArgs e)
        {
            //Clear the logout message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Initialize new form and tirgger its appearance
            StormDataForm stormDataForm = new StormDataForm();

            //Show the form
            stormDataForm.ShowDialog();

        }

        /// <summary>
        /// Contact info button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactInfobutton_Click(object sender, EventArgs e)
        {
            //Clear the logout message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Initialize the form and trigger its appearance
            ContactInfoForm contactInfoForm = new ContactInfoForm();

            //Show the form
            contactInfoForm.ShowDialog();

        }

        /// <summary>
        /// About Menu Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutThisProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear the logout message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Initialize the about box form 
            aboutThisAppForm aboutThisAppForm = new aboutThisAppForm();

            //Show the about box form
            aboutThisAppForm.ShowDialog();

        }

        /// <summary>
        /// Log In Tool Strip Menu Item Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Clear the logout message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Create the login form
            LogInForm logInForm = new LogInForm();

            //Make main form owner of login form
            logInForm.Owner = this;

            //Show the login form
            logInForm.ShowDialog();
                       

        }

        /// <summary>
        /// Contact info Tool Strip Menu Item Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear the logout message if user logged out before clicking this button
            userMessageLabel.ResetText();

            //Instantiate the contact info maintenance form and show it
            ContactInfoMaintenanceForm contactInfoMaintenanceForm = new ContactInfoMaintenanceForm();
            contactInfoMaintenanceForm.ShowDialog();
                        
        }

        /// <summary>
        /// Form Load event handler to disable specified menu items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeatherAppForm_Load(object sender, EventArgs e)
        {
            //Disable these menu items on form load
            contactInfoToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Enabled = false;
            stormDataMaintenanceToolStripMenuItem.Enabled = false;
            stormNameMaintenanceToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Logout Tool Strip Menu Item Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Disable these menu items after log-out
            contactInfoToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Enabled = false;
            stormDataMaintenanceToolStripMenuItem.Enabled = false;
            stormNameMaintenanceToolStripMenuItem.Enabled = false;
            userMessageLabel.Text = "You are now logged out." +
                Environment.NewLine + "You must log in again to access features in the Maintenance Menu.";
        }
    }
}
