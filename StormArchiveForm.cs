/* TomWeatherApp.cs
 * Tom Bielawski
 * Modified 11/13/2020
 * COP2360C Project 6: Weather App Storm Archive Form
 * Modified 11/25/2020
 * FSCJ Professor Gehrig*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomWeatherApp
{
    /// <summary>
    /// Storm Archive Form
    /// </summary>
    public partial class StormArchiveForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public StormArchiveForm()
        {
            InitializeComponent();

            //Focus on the Storm Name Text Box
            archivedStormNameTextBox.Focus();
        }


        /// <summary>
        ///  Method to find the number of digits in a string
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
        /// Method to find if string is all digits
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }


        /// <summary>
        /// Archived Storm Name Button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void archivedStormName_Enter(object sender, EventArgs e)
        {
            archivedStormNameTextBox.SelectAll();
        }

        
        /// <summary>
        /// Clear Button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clearing the text and list boxes
            archivedStormNameTextBox.Clear();
            listMonths.ClearSelected();
            listDays.ClearSelected();
            listYears.ClearSelected();
            listMonthsEnd.ClearSelected();
            listDaysEnd.ClearSelected();
            listYearsEnd.ClearSelected();
            maxWindSpeedTextBox.Clear();
            archiveStormResultsLabel.ResetText();
            archivedStormNameTextBox.Focus();
        }

        /// <summary>
        /// Close button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }


        /// <summary>
        /// Submit Button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Convert storm name into string for data validation            
            string stormName = archivedStormNameTextBox.ToString();
                      
            //Validate if storm name has been entered
            //Validate if storm name has number of digits greater than 0, trigger warning
            if (archivedStormNameTextBox.Text.Trim().Length == 0 || NumberDigits(stormName) > 0)
            {
                archiveStormResultsLabel.Text = "Please enter the storm name. Use letters only.";
                archivedStormNameTextBox.SelectAll();
                archivedStormNameTextBox.Focus();
            }

            //Validate if start month has been selected
            else if (listMonths.SelectedIndex == -1)
            {
                archiveStormResultsLabel.Text = "Please select a storm start month.";

            }

            //Validate if start day has been selected
            else if (listDays.SelectedIndex == -1)
            {
                archiveStormResultsLabel.Text = "Please select a storm start day.";
            }

            //Validate if start year has been selected
            else if (listYears.SelectedIndex == -1)
            {
                archiveStormResultsLabel.Text = "Please select a storm start year.";
            }

            //Validate if end month has been selected
            else if (listMonthsEnd.SelectedIndex == -1)
            {
                archiveStormResultsLabel.Text = "Please select a storm end month.";

            }

            //Validate if end day has been selected
            else if (listDaysEnd.SelectedIndex == -1)
            {
                archiveStormResultsLabel.Text = "Please select a storm end day.";
            }

            //Validate if end year has been selected
            else if (listYearsEnd.SelectedIndex == -1)
            {
                archiveStormResultsLabel.Text = "Please select a storm end year.";
            }

           
            else
            {
                //Try-catch for exception handling
                try
                {
                    //Instantiate the newArchive class
                    StormArchiveClass newArchive = new StormArchiveClass();

                    //Convert the start listbox values to string
                    int selectedStartMonth = int.Parse(listMonths.SelectedItem.ToString());
                    int selectedStartDay = int.Parse(listDays.SelectedItem.ToString());
                    int selectedStartYear = int.Parse(listYears.SelectedItem.ToString());
                    
                    //Create date-time object using start date values
                    DateTime selectedStartDate = new DateTime(selectedStartYear, selectedStartMonth, selectedStartDay);

                    //Convert end date list values to string
                    int selectedEndMonth = int.Parse(listMonthsEnd.SelectedItem.ToString());
                    int selectedEndDay = int.Parse(listDaysEnd.SelectedItem.ToString());
                    int selectedEndYear = int.Parse(listYearsEnd.SelectedItem.ToString());

                    //Create date-time object using end date values
                    DateTime selectedEndDate = new DateTime(selectedEndYear, selectedEndMonth, selectedEndDay);

                    //Get the start date
                    newArchive.BeginDate = selectedStartDate;

                    //Get the end date
                    newArchive.EndDate = selectedEndDate;

                    //Get the storm name
                    newArchive.ArchiveStormName = archivedStormNameTextBox.Text;

                    //Get the maximum wind speed
                    newArchive.MaxWindSpeed = maxWindSpeedTextBox.Text;

                    //Covert wind speed to string
                    string maxWindSpeed = maxWindSpeedTextBox.Text.ToString();
                    
                    //Declare variable for classification
                    string stormClassification;

                    //Check wind speed to ensure it is all digits, if not warn user
                                        
                    if (maxWindSpeedTextBox.Text.Trim().Length == 0)
                    {
                        archiveStormResultsLabel.Text = "Please enter a windspeed in digits.";
                    }
                    
                    else if (IsAllDigits(maxWindSpeed) == false)
                    {
                        archiveStormResultsLabel.Text = "Please enter the windspeed in digits.";
                    }


                    try
                    {
                        //Convert wind speed to double for category evaluation
                        double windSpeed = double.Parse(maxWindSpeedTextBox.Text);

                        //Compare windspeed to determine what category the storm is
                        //Get the storm category
                        if (windSpeed >= 0 && windSpeed <= 38)
                        {
                            stormClassification = "Tropical Depression";
                            newArchive.StormCategory = stormClassification;
                        }

                        else if (windSpeed >= 39 && windSpeed <= 74)
                        {
                            stormClassification = "Tropical Storm";
                            newArchive.StormCategory = stormClassification;
                        }

                        else if (windSpeed >= 75 && windSpeed <= 95)
                        {
                            stormClassification = "Category 1 Hurricane";
                            newArchive.StormCategory = stormClassification;
                        }

                        else if (windSpeed >= 95 && windSpeed <= 110)
                        {
                            stormClassification = "Category 2 Hurricane";
                            newArchive.StormCategory = stormClassification;
                        }

                        else if (windSpeed >= 111 && windSpeed <= 129)
                        {
                            stormClassification = "Category 3 Hurricane";
                            newArchive.StormCategory = stormClassification;
                        }

                        else if (windSpeed >= 129 && windSpeed <= 156)
                        {
                            stormClassification = "Category 4 Hurricane";
                            newArchive.StormCategory = stormClassification;
                        }

                        else if (windSpeed > 156)
                        {
                            stormClassification = "Category 5 Hurricane";
                            newArchive.StormCategory = stormClassification;
                        }

                        //Call the toString Method
                        archiveStormResultsLabel.Text = newArchive.ToString();
                    }

                    //Wind speed exception.
                    catch (Exception ex)
                    {

                        archiveStormResultsLabel.Text = "Invalid entry:" + ex.Message + ". Please enter a wind speed using digits only.";
                    }


                }

                catch (Exception ex)
                {

                    archiveStormResultsLabel.Text = "Invalid entry:" + ex.Message;
                }

            }
          
            
        }

        /// <summary>
        /// Form Load event fills list boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_Load(object sender, EventArgs e)
        {
            //Fill both month list boxes
            int index = 1;
            while (index <= 12)
            {
                listMonths.Items.Add(index);
                listMonthsEnd.Items.Add(index);
                index += 1; 
            }

            //Fill both day list boxes
            index = 1;
            do
            {
                listDays.Items.Add(index);
                listDaysEnd.Items.Add(index);
                index += 1;
            }
            while (index <= 31);

            //Fill both year list boxes
            for (index = 1950; index <= 2020; index++)
            {
                listYears.Items.Add(index);
                listYearsEnd.Items.Add(index);
            }
        }

        
    }
}