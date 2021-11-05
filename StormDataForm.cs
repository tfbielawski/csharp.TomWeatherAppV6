/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/13/2020
 * COP2360C Project 6: Weather App Storm Data Form
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
    /// StormDataForm
    /// </summary>
    public partial class StormDataForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public StormDataForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Form Load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StormDataForm_Load(object sender, EventArgs e)
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
        /// Close button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form and return to the main form
            Close();
        }

        
        /// <summary>
        /// Filter By Wind Speed tool strip button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillByWindSpeedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.storms2TableAdapter.FillByWindSpeed(this.cDInventory_20171_BackupDataSet.Storms2, ((int)(System.Convert.ChangeType(windspeedToolStripTextBox.Text, typeof(int)))));
            }
            catch (Exception ex)
            {
                userInfoLabel.Text = "Unable filter by windspeed. " + ex.Message;
            }

        }

        /// <summary>
        /// Fuilter by StormID tool strip button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillByStormIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.storms2TableAdapter.FillByStormID(this.cDInventory_20171_BackupDataSet.Storms2, stormIDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                userInfoLabel.Text = "Unable filter by StormID. " + ex.Message;
            }

        }

        /// <summary>
        /// Show all data tool strip button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillByAllStormDataToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.storms2TableAdapter.FillByAllStormData(this.cDInventory_20171_BackupDataSet.Storms2);
            }

            catch (System.Exception ex)
            {
                userInfoLabel.Text = "Unable to display all data. " + ex.Message;

            }

        }

       
    }
}
