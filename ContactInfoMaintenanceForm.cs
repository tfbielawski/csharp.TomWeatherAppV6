/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/20/2020
 * COP2360C Project 6: Weather App
 * Contact Info Maintenance Form
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
using System.IO;

namespace TomWeatherApp
{
    /// <summary>
    /// Contact Info Maintenance Form
    /// </summary>
    public partial class ContactInfoMaintenanceForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public ContactInfoMaintenanceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to clear the form's text boxes of any mis-entered data
        /// </summary>
        private void clearTextBoxes()
        {
            //Clear the labels
            contactPersonNameTextBox.Clear();
            compNameTextBox.Clear();
            compAddressTextBox.Clear();
            compCityTextBox.Clear();
            compStateTextBox.Clear();
            compZipTextBox.Clear();
            userMessageLabel.ResetText();
            contPersCompNameTextBox.Clear();
            contPersCompStreetTextBox.Clear();
            contPersCompCityTextBox.Clear();
            contPersCompStateTextBox.Clear();
            contPersCompZipTextBox.Clear();

            //Return the focus
            contactPersonNameTextBox.Focus();
            
            //Inform the user
            userMessageLabel.Text = "All text boxes cleared. " +
                Environment.NewLine + "The data was not saved." +
                Environment.NewLine + "You are free to edit and try again." +
                Environment.NewLine + "To make changes: enter your data and click SAVE DATA." +
                Environment.NewLine + "To clear the fields click CLEAR." +
                Environment.NewLine + "To reload the last saved data, click RELOAD DATA." +
                Environment.NewLine + "Click EXIT to quit.";

        }

        
        /// <summary>
        /// Method to count the digits in a string. 
        /// </summary>
        /// <param name="s"></param>
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
        /// Method to count the letters in a string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int NumberLetters(string str)
        {
            int letters = 0;
            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                {
                    letters++;
                }
            }
            return letters;
        }

      
       /// <summary>
       /// Save Data button event handler
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void saveDataButton_Click(object sender, EventArgs e)
        {           
           
            //Try catch block for data validation and exception handling
            try
            {
                //Assign values to strings for subsequent input validation
                string stateCode = compStateTextBox.Text.ToString();                
                string zipCode = compZipTextBox.Text.ToString();

                string companyContactState = contPersCompStateTextBox.Text.ToString();                
                string contactZip = contPersCompZipTextBox.Text.ToString();

                               
                //Detect if contact person text box has no data
                if (contactPersonNameTextBox.Text.Length == 0)
                {
                    //Warn the user, return the focus
                    userMessageLabel.Text = "Please enter the contact person's name.";
                    contactPersonNameTextBox.SelectAll();
                    contactPersonNameTextBox.Focus();
                }

                //Deteect if company name text has no data
                else if (compNameTextBox.Text.Length == 0)
                {
                    //Warn the user, return the focus
                    userMessageLabel.Text = "Please enter company name.";
                    compNameTextBox.SelectAll();
                    compNameTextBox.Focus();
                }

                //Detect if company address has no data               
                else if (compAddressTextBox.Text.Length == 0)
                {
                    //Warn the user, return the focus
                    userMessageLabel.Text = "Please enter company address.";
                    compAddressTextBox.SelectAll();
                    compAddressTextBox.Focus();
                }

                //Detect if company city has no data
                else if (compCityTextBox.Text.Length == 0)
                {
                    //Warn the user, return the focus
                    userMessageLabel.Text = "Please enter company city.";
                    compCityTextBox.SelectAll();
                    compCityTextBox.Focus();
                }

                //Detect if state code holds data, ensure data consists of two characters that are letters only
                else if (stateCode == string.Empty || NumberLetters(stateCode) != 2 )
                {
                    //Warn the user, return the focus
                    userMessageLabel.Text = "Please enter company state. " +
                        Environment.NewLine + "Enter TWO letters only and NO digits." +
                        Environment.NewLine + "You entered " + NumberLetters(stateCode) + " letters" +
                        Environment.NewLine + "You entered " + NumberDigits(stateCode) + " digits.";
                        
                    compStateTextBox.SelectAll();
                    compStateTextBox.Focus();
                                        
                }

                //Detect if the zip code holds data, ensure the data consists of 5 charaters that are digits only
                else if (zipCode == string.Empty || NumberDigits(zipCode) != 5)
                {
                    //Warn the user, return the focus
                    userMessageLabel.Text = "Please enter company zip code. " +
                        Environment.NewLine + "Enter FIVE digits only and NO letters." +
                        Environment.NewLine + "You entered " + NumberDigits(zipCode) + " digits." +
                        Environment.NewLine + "You entered " + NumberLetters(zipCode) + " letters";

                    compZipTextBox.SelectAll();
                    compZipTextBox.Focus();
                }

                else if (contPersCompNameTextBox.Text.Length == 0)
                {
                    //Warn the user, return the focus
                    userMessageLabel.Text = "Please enter the contact company's name.";
                    contPersCompNameTextBox.SelectAll();
                    contPersCompNameTextBox.Focus();
                }


                else
                {
                    //Instantiate object of Company Address Class
                    ContactClass contactClass = new ContactClass();

                    //Call the class methods to get and desplay the data entered through inheritance
                   
                    contactClass.CompanyName = compNameTextBox.Text;
                    contactClass.CompanyStreetAdress = compAddressTextBox.Text;
                    contactClass.CompanyCity = compCityTextBox.Text;

                    //Convert state code data to upper case as object captures the data
                    contactClass.CompanyState = stateCode.ToUpper();
                    contactClass.CompanyZipCode = int.Parse(compZipTextBox.Text);

                    
                    //Call the class methods to get and desplay the data entered through composition
                    contactClass.ContactPersonName = contactPersonNameTextBox.Text;
                    contactClass.ContactPersonCompanyName = contPersCompNameTextBox.Text;
                    contactClass.ContactPersonCompanyStreetAddress = contPersCompStreetTextBox.Text;
                    contactClass.ContactPersonCompanyCity = contPersCompCityTextBox.Text;
                    contactClass.ContactPersonCompanyState = companyContactState.ToUpper();
                    contactClass.ContactPersonCompanyZipCode = int.Parse(contPersCompZipTextBox.Text);

                    //Declare the stream reader object
                    StreamWriter writer = new StreamWriter("WeatherContact.txt");

                    //Write the validated values to the file
                    writer.WriteLine(contactPersonNameTextBox.Text.Trim());
                    writer.WriteLine(compNameTextBox.Text.Trim());
                    writer.WriteLine(compAddressTextBox.Text.Trim());
                    writer.WriteLine(compCityTextBox.Text.Trim());
                    writer.WriteLine(stateCode);
                    writer.WriteLine(compZipTextBox.Text.Trim());

                    writer.WriteLine(contPersCompNameTextBox.Text.Trim());
                    writer.WriteLine(contPersCompStreetTextBox.Text.Trim());
                    writer.WriteLine(contPersCompCityTextBox.Text.Trim());
                    writer.WriteLine(companyContactState);
                    writer.WriteLine();
                    writer.WriteLine(contPersCompZipTextBox.Text.Trim());


                    //Close the file so it can be reopened again if necessary.
                    writer.Close();

                    //Inform the user
                    userMessageLabel.Text = "The data you entered was:" +
                       Environment.NewLine + contactClass.ToString() +
                       Environment.NewLine + Environment.NewLine + "The file was saved and closed." +
                       Environment.NewLine + "Click CLEAR or RELOAD DATA to continue, or press EXIT to quit.";

                }
                
            }

            catch (Exception ex)
            {
                string readError = " File open error! ";
                userMessageLabel.Text = ex.Message + readError;
               
            }
        }


        /// <summary>
        /// Clear button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Call the clearTextBoxes() function
            clearTextBoxes();

        }

        /// <summary>
        /// Exit button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            Close();
        }

        /// <summary>
        /// Form load event handler to populate the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactInfoMaintenanceForm_Load(object sender, EventArgs e)
        {
            //Instantiate stream reder object to populate the boxes upon form load
            StreamReader reader = new StreamReader("WeatherContact.txt");

            //Reading the lines from the file into the text boxes
            contactPersonNameTextBox.Text = reader.ReadLine();//contact.ContactPersonName;
            compNameTextBox.Text = reader.ReadLine();
            compAddressTextBox.Text = reader.ReadLine();
            compCityTextBox.Text = reader.ReadLine();
            compStateTextBox.Text = reader.ReadLine();
            compZipTextBox.Text = reader.ReadLine();

            contPersCompNameTextBox.Text = reader.ReadLine();
            contPersCompStreetTextBox.Text = reader.ReadLine();
            contPersCompCityTextBox.Text = reader.ReadLine();
            contPersCompStateTextBox.Text = reader.ReadLine();
            contPersCompZipTextBox.Text = reader.ReadLine();

            //Close the text file so it can be opened by the stream writer object later.
            reader.Close();

        }

        /// <summary>
        /// Reload Data event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloadDataButton_Click(object sender, EventArgs e)
        {
            //Clear all the text boxes before reloading the data
            clearTextBoxes();

            //Instantiate a new stream reader object
            StreamReader reader2 = new StreamReader("WeatherContact.txt");

            //Populate the text boxes from the reader object
            contactPersonNameTextBox.Text = reader2.ReadLine();

            compNameTextBox.Text = reader2.ReadLine();
            compAddressTextBox.Text = reader2.ReadLine();
            compCityTextBox.Text = reader2.ReadLine();
            compStateTextBox.Text = reader2.ReadLine();
            compZipTextBox.Text = reader2.ReadLine();

            contPersCompNameTextBox.Text = reader2.ReadLine();
            contPersCompStreetTextBox.Text = reader2.ReadLine();
            contPersCompCityTextBox.Text = reader2.ReadLine();
            contPersCompStateTextBox.Text = reader2.ReadLine();
            contPersCompZipTextBox.Text = reader2.ReadLine();


            //Close the text file so it can be used by stream writer later.
            reader2.Close();

            //Inform the user
            userMessageLabel.Text = "Data Reloaded." +
                Environment.NewLine + "Previous changes (if any) are in effect." +
                Environment.NewLine + "To make changes: enter your data and click SAVE DATA." +
                Environment.NewLine + "To clear the fields click CLEAR." +
                Environment.NewLine + "To reload the last saved data, click RELOAD DATA." +
                Environment.NewLine + "Click EXIT to quit.";

        }
    }
}
