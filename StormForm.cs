
/* TomWeatherApp.cs
 * Tom Bielawski
 * 10/4/2020
 * COP2360C Project 6: Weather App Storm Form
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
    /// StormForm
    /// </summary>
    public partial class StormForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public StormForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Exit button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Clear button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the text boxes and the results label
            stormNameTextBox.Clear();
            latTextBox.Clear();
            longTextBox.Clear();
            windSpeedTextBox.Clear();
            stormResultsLabel.ResetText();

            //Return the focus to Storm Name
            stormNameTextBox.Focus();

        }

        /// <summary>
        /// Submit Button Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Instantiate new Storm object
            Storm myStorm = new Storm();

            //Access the class fields
            myStorm.StormName = stormNameTextBox.Text;
            myStorm.Latitude = decimal.Parse(latTextBox.Text);
            myStorm.Longitude = decimal.Parse(longTextBox.Text);
            myStorm.WindSpeed = double.Parse(windSpeedTextBox.Text);

            //Access storm ToSTring to display results
            stormResultsLabel.Text = myStorm.ToString();

        }
    }
}
