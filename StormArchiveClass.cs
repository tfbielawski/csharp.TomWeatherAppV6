/* TomWeatherApp.cs
 * Tom Bielawski
 * 10/18/2020
 * COP2360C Weather App Version 6
 * Storm Archive Class 
 * Modified 11/25/2020
 * FSCJ Professor Gehrig*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomWeatherApp
{
    /// <summary>
    /// Storm Archive Class to gather historical storm data
    /// and return the storm category
    /// </summary>
    class StormArchiveClass
    {
        #region Fields
        //Declare private fields
        private string _stormArchiveName;
        private string _stormCategory;
        private DateTime _stormBeginDate, _stormEndDate;
        private string _maxWindSpeed;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor no arguments
        /// </summary>
        public StormArchiveClass() { }

        /// <summary>
        /// Overloaded constructor accepting 5 arguments
        /// </summary>
        /// <param name="pStormArchiveName">Archived storm name</param>
        /// <param name="pStormCategory">Storm category</param>
        /// <param name="pStormBeginDate">Storm Begin Date</param>
        /// <param name="pStormEndDate">Storm End Date</param>
        /// <param name="pMaxWindSpeed">Maximum wind speed</param>
        public StormArchiveClass(string pStormArchiveName, string pStormCategory, DateTime pStormBeginDate, DateTime pStormEndDate, string pMaxWindSpeed)
        {
            ArchiveStormName = pStormArchiveName;
            StormCategory = pStormCategory;
            BeginDate = pStormBeginDate;
            EndDate = pStormEndDate;
            MaxWindSpeed = pMaxWindSpeed;

        }
        #endregion


        #region Class Properties
        /// <summary>
        /// method to get the storm's name
        /// </summary>
        public string ArchiveStormName
        {
            get { return _stormArchiveName; }
            set { _stormArchiveName = value.Trim(); }

        }

        /// <summary>
        /// Method to get the storm's begin date
        /// </summary>
        public DateTime BeginDate
        {
            get { return _stormBeginDate; }
            set { _stormBeginDate = value; }
        }

        /// <summary>
        /// Method to get the storm's end date
        /// </summary>
        public DateTime EndDate
        {
            get { return _stormEndDate; }
            set { _stormEndDate = value; }
        }

        /// <summary>
        /// Method to get the category 
        /// </summary>
        public string StormCategory
        {
            get { return _stormCategory; }
            set { _stormCategory = value.Trim(); }
        }

        /// <summary>
        /// Method to get the storm's maximum sustained wind speed
        /// </summary>
        public string MaxWindSpeed
        {
            get { return _maxWindSpeed; }
            set { _maxWindSpeed = value.Trim(); }
        }

        /// <summary>
        /// To String method to provide required output to user
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message;
            message = "storm name = " + ArchiveStormName +
                Environment.NewLine + "nstorm begin date = " + BeginDate +
                Environment.NewLine + "storm end date = " + EndDate +
                Environment.NewLine + "windspeed = " + MaxWindSpeed + "MPH" +
                Environment.NewLine + "category = " + StormCategory;

            return message;
        }
        #endregion


        #region Destructor
        /// <summary>
        /// Destructor to release memory
        /// </summary>
        ~StormArchiveClass()
        {
            _stormArchiveName = null;
            _maxWindSpeed = null;
            _stormCategory = null;
        } 
        #endregion
    }
    
}
