/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/25/2020
 * COP2360C Project 6: Weather App
 * Contact Info Form
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
    /// Contact Info Form
    /// </summary>
    public partial class ContactInfoForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public ContactInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to clear the form's fields
        /// </summary>
        private void clearFields()
        {
            //Clear the labels
            contactPersonLabel.ResetText();
            compNameLabel.ResetText();
            compAddresslabel.ResetText();
            compCityLabel.ResetText();
            compStateLabel.ResetText();
            compZipLabel.ResetText();
            userMessageLabel.ResetText();
            contPersCompNamelabel.ResetText();
            contPersCompStreetLabel.ResetText();
            contPersCompCityLabel.ResetText();
            contPersCompStateLabel.ResetText();
            contPersCompZipLabel.ResetText();

            //Return the focus
            compNameLabel.Focus();

            //Inform the user
            userMessageLabel.Text = "Form cleared." +
                Environment.NewLine + "Click READ DATA to reload the form." +
                Environment.NewLine + "Click EXIT to quit.";

        }

        /// <summary>
        /// Function to check if the file exists already.
        /// </summary>
        private void FileExistsAlready()
        {
            if (File.Exists("WeatherContact.txt"))
            {
                userMessageLabel.Text = "File Loaded." +
                    Environment.NewLine + "Results displayed in the fields above." +
                    Environment.NewLine + "Click CLEAR to clear the form. " +
                    Environment.NewLine + "Click READ DATA to reload the form." +
                    Environment.NewLine + "Click EXIT to quit.";
            }

            else
            {
                userMessageLabel.Text = "File does not exist in the current directory!";
            }

            
        }

             
        /// <summary>
        /// Read Data event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Declare the stream reader object
                StreamReader inPutFile = File.OpenText("WeatherContact.txt");
                

                //Call the file exists function to see if it's already open.
                FileExistsAlready();
                //System.IO.File.Exists("WeatherContact.Txt");

                //Read the contents of the file into the appropriate labels               
                contactPersonLabel.Text = inPutFile.ReadLine();
                compNameLabel.Text = inPutFile.ReadLine();
                compAddresslabel.Text = inPutFile.ReadLine();
                compCityLabel.Text = inPutFile.ReadLine();
                compStateLabel.Text = inPutFile.ReadLine();
                compZipLabel.Text = inPutFile.ReadLine();

                contPersCompNamelabel.Text = inPutFile.ReadLine();
                contPersCompStreetLabel.Text = inPutFile.ReadLine();
                contPersCompCityLabel.Text = inPutFile.ReadLine();
                contPersCompStateLabel.Text = inPutFile.ReadLine();
                contPersCompZipLabel.Text = inPutFile.ReadLine();


                //Close the file.
                inPutFile.Close();
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
            clearFields();

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

    }
}
