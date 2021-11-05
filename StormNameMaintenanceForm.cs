/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/13/2020
 * COP2360C Project 6: Weather App Storm Name Maintenance Form
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
    /// Storm Name Maintenance 
    /// </summary>
    public partial class stormNameMaintenanceForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public stormNameMaintenanceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save Item event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stormNamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {           

            try
            {
                this.Validate();
                this.stormNamesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cDInventory_20171_BackupDataSet);

                //Instantiate class object
                StormIdentifierClass stormIdentifier = new StormIdentifierClass();

                //Call the class methods
                stormIdentifier.StormName = stormNameTextBox.Text;
                stormIdentifier.StormID = stormIdTextBox.Text;

                //Call the class ToString() to display results
                userInfoLabel.Text = stormIdentifier.ToString();
            }

            catch (Exception ex)
            {
                userInfoLabel.Text = ex.Message;
            }

        }

        /// <summary>
        /// Form Load handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stormNameMaintenanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cDInventory_20171_BackupDataSet.StormNames' table. You can move, or remove it, as needed.
            //Exception handler for loading the database
            try
            {
                this.stormNamesTableAdapter.Fill(this.cDInventory_20171_BackupDataSet.StormNames);
            }

            catch (Exception ex)
            {
                userInfoLabel.Text = "Unable to open the database. Database Error " + ex.Message + " Database Error! ";
            }
        }


        /// <summary>
        /// Clear button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the fields
            stormIdTextBox.Clear();
            stormNameTextBox.Clear();
            userInfoLabel.ResetText();

            //Return the focus
            stormIdTextBox.Focus();

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
    }
}
