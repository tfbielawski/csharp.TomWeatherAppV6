/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/13/2020
 * COP2360C Project 6: Weather App Storm Data Maintenance Form
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
    /// Storm Data Maintenance Form
    /// </summary>
    public partial class StormDataMaintenanceForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public StormDataMaintenanceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to find unauthorized characters (AM/PM, am/pm, :, /) in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool charFinder(string str)
        {

            if (str.Contains("/") || str.Contains("-") || str.Contains(":") || 
                str.Contains("a") || str.Contains("A") || str.Contains("p") || str.Contains("P") )
                return true;
            return false;
        }

        /// <summary>
        /// Method to validate string contains only letters and no digits
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int NumberDigits(string str)
        {
            int digits = 0;
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    digits++;
                }
            }
            return digits;
        }

        /// <summary>
        /// Method to validate if string contains only digits
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Check if entry is a valid latitude degree range
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        bool isValidLatDegree(int str)
        {
            if (str >= -90 && str <= 90)
            { return true; }
            return false;
        }

        /// <summary>
        /// Check if entry is a valid longitude degree range
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        bool isValidLongDegree(int str)
        {
            if (str >= -180 && str <= 180)
            { return true; }
            return false;
        }

        /// <summary>
        /// Add New Item Button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.storms2BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cDInventory_20171_BackupDataSet);
            }

            catch (Exception ex)
            {
                userInfoLabel.Text = ex.Message;
            }
        }



        /// <summary>
        /// Save Item Button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storms2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                //Instantiate the storm data class object
                StormDataClass stormData = new StormDataClass();

                //Declare variables and initialize with text box values
                string slashDashFinder = stormDateTextBox.Text.Trim();
                string colonFinder = stormTimeTextBox.Text.Trim();
                string digitFinder = indicatorTextBox.Text.Trim();
                string nextDigitFinder = stormStatusTextBox.Text.Trim();
                string latAllDigits = latTextBox.Text.Trim();
                int latDegreeFinder = int.Parse(latTextBox.Text.Trim());
                int longDegreeFinder = int.Parse(lonTextBox.Text.Trim());
                string windSpeedDigits = windspeedTextBox.Text.Trim();
                string pressureDigits = pressureTextBox.Text.Trim();
                string stormID = stormIDTextBox.Text.Trim();
                
                //Validate that the date has no slashes or dashes, numbers only
                if (charFinder(slashDashFinder) == true)
                {
                    userInfoLabel.Text = "Please enter the date without slashes '/' or dashes '-'. User digits only.";
                }

                //Validate that the time has no colon
                else if(charFinder(colonFinder) ==  true)
                {
                    userInfoLabel.Text = "Please enter the time without colon ':' and without AM or PM. Use digits only.";
                }

                //Validate that indicator is letter only and not more than one character
                else if (NumberDigits(digitFinder) > 0 || digitFinder.Length > 1)
                {
                    userInfoLabel.Text = "Please enter the Storm Indicator as a single letter only. Do not use digits.";
                }

                //Validate that status is letters only and not more than two characters
                else if(NumberDigits(nextDigitFinder) > 0 || nextDigitFinder.Length > 2)
                {
                    userInfoLabel.Text = "Please enter the Storm Status as two letter code only. Do not use digits.";
                }

                //Validate that the Latitude is entered in degrees between -90 to 90 and that it is all digits
                else if(IsAllDigits (latAllDigits) == false || isValidLatDegree(latDegreeFinder) == false)
                {
                    userInfoLabel.Text = "Please enter a latitude between -90 and 90 degrees using numbers only.";
                }

                //Validate that the Latitude is entered in degrees between -180 to 180 and that it is all digits
                else if (IsAllDigits(latAllDigits) == false || isValidLongDegree(longDegreeFinder) == false)
                {
                    userInfoLabel.Text = "Please enter a longitude between -180 and 180 degrees using numbers only.";
                }

                //Validate that the windspeed is only digits
                else if (IsAllDigits(windSpeedDigits) == false )
                {
                    userInfoLabel.Text = "Please enter the windspeed using digits only.";
                }

                //Validate that the barometric pressure is only digits
                else if (IsAllDigits(pressureDigits) == false)
                {
                    userInfoLabel.Text = "Please enter the barometric pressure using digits only.";
                }

                //Validate that the StormID has no more than 8 characters
                else if (stormID.Length > 8)
                {
                    userInfoLabel.Text = "The Storm ID can only be letters and numbers and not more than 8 characters.";
                }

                else 
                {
                    this.Validate();
                    this.storms2BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.cDInventory_20171_BackupDataSet);

                        
                                        
                    //Call the class methods
                    stormData.StormDateOfOccurrence = long.Parse(stormDateTextBox.Text);
                    stormData.StormTime = int.Parse(stormTimeTextBox.Text);
                    stormData.StormIndicator = indicatorTextBox.Text;
                    stormData.StormStatus = stormStatusTextBox.Text;
                    int stormLatitude = int.Parse(latTextBox.Text.ToString());
                        
                    stormData.StormLatitude = stormLatitude;
                    stormData.StormLongitude = decimal.Parse(lonTextBox.Text);
                    stormData.StormWindSpeed = int.Parse(windspeedTextBox.Text);
                    stormData.StormBaroPressure = int.Parse(pressureTextBox.Text);
                    stormData.StormID = stormIDTextBox.Text;

                    //Call the to string method                
                    userInfoLabel.Text = stormData.ToString();
                }
            }

            catch (Exception ex)
            {

                userInfoLabel.Text = ex.Message;
            }

        }


        /// <summary>
        /// Load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StormMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDInventory_20171_BackupDataSet.Storms2' table. You can move, or remove it, as needed.
            //Exception handler for loading the database
            try
            {
                this.storms2TableAdapter.Fill(this.cDInventory_20171_BackupDataSet.Storms2);

            }

            catch (Exception ex)
            {
                userInfoLabel.Text = "Unable to open the database. Database Error " + ex.Message + " Database Error! ";
            }
                       

           
        }

         /// <summary>
         /// Clear Button event handler
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all the fields
            stormDateTextBox.Clear();
            stormTimeTextBox.Clear();
            indicatorTextBox.Clear();
            stormStatusTextBox.Clear();
            latTextBox.Clear();
            lonTextBox.Clear();
            windspeedTextBox.Clear();
            pressureTextBox.Clear();
            stormIDTextBox.Clear();
            userInfoLabel.ResetText();

            //Return the focus
            stormDateTextBox.Focus();
        }

        /// <summary>
        /// Close button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form and return to the main form

            Close();

        }
    }
}
