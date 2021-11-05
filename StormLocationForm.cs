/* TomWeatherApp.cs
 * Tom Bielawski
 * 10/4/2020 - 
 * COP2360C Project 6: Weather App Storm Location Form
 * Modified 11/28/2020
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
    /// StormLocationForm
    /// </summary>
    public partial class StormLocationForm : Form
    {
            
        /// <summary>
        /// Form constructor
        /// </summary>
        public StormLocationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close this form
            Close();
        }

        /// <summary>
        /// This clears the text boxes when "clear" is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the textboxes
            latitudeTextBox.Clear();
            longitudeTextBox.Clear();
            latitudeTextBox.Focus();

            //Return the focus
            latitudeTextBox.Focus();
        }

        /// <summary>
        /// When "Submit" is clicked, the program runs and does the math. Then it outputs results to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert the text entered into a decimal
                decimal newLatDegrees = decimal.Parse(latitudeTextBox.Text.Trim());

                //Convert the text entered into a decimal
                decimal newLongDegrees = decimal.Parse(longitudeTextBox.Text.Trim());

                //Convert to int to remove the decimal portion and establish the degrees.
                int moreLatDegrees = Convert.ToInt32(newLatDegrees);

                //Convert to int to remove the decimal portion and establish the degrees.
                int moreLongDegrees = Convert.ToInt32(newLongDegrees);


                //Modulo to separate the decimal portion from the whole
                newLatDegrees %= 1;

                //Modulo to separate the decimal portion from the whole
                newLongDegrees %= 1;

                //Mulitply by 60 to get the minutes in raw form xx.xx
                decimal newLatMinutes = newLatDegrees *= 60;

                //Mulitply by 60 to get the minutes in raw form xx.xx
                decimal newLongMinutes = newLongDegrees *= 60;

                //Convert to int to drop the decimal portion and get the converted minutes
                int convertedLatMinutes = Convert.ToInt32(newLatMinutes);

                //Convert to int to drop the decimal portion and get the converted minutes
                int convertedLongMinutes = Convert.ToInt32(newLongMinutes);

                //Modulo to separate the decimal portion from the whole
                newLatMinutes %= 1;

                //Modulo to separate the decimal portion from the whole
                newLongMinutes %= 1;

                //Mulitply by 60 to get the seconds in raw form xx.xx
                decimal newLatSeconds = newLatMinutes * 60;

                //Mulitply by 60 to get the seconds in raw form xx.xx
                decimal newLongSeconds = newLongMinutes * 60;

                //Cast to int to get converted seconds
                int convertedLatSeconds = Convert.ToInt32(newLatSeconds);

                //Cast to int to get converted seconds
                int convertedLongSeconds = Convert.ToInt32(newLongSeconds);


                //Convert the output back into string for display to user. Using \n to break the results into two readable lines
                resultsLabel.Text = "Your latitude is: " + moreLatDegrees + " Degrees " + convertedLatMinutes + " Minutes " + convertedLatSeconds + " Seconds." +
                    Environment.NewLine + "Your longitude is" + moreLongDegrees + " Degrees " + convertedLongMinutes + " Minutes " + convertedLongSeconds + " Seconds.";
            }

            catch (Exception ex)
            {
                string locationMessage = "Error. Please check your values!";
                resultsLabel.Text = locationMessage + ex.Message;
            }
               
        }
    }
}
