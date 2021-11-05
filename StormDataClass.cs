/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/5/2020
 * COP2360C Weather App Version 6 Storm Data Class 
 * Modified 11/25/2020
 * FSCJ Professor Gherig*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomWeatherApp
{
    /// <summary>
    /// Class to gather more detailed storm information for subsequent
    /// storage in database
    /// </summary>
    class StormDataClass
    {

        #region Fields
        //Declare the private fields
        private long _stormDateOfOccurence;
        private int _stormTime;
        private string _stormIndicator;
        private string _stormStatus;
        private int _stormLatitude;
        private decimal _stormLongitude;
        private int _stormWindSpeed;
        private int _stormBaroPressure;
        private string _stormID;
        #endregion


        #region Constructors
        /// <summary>
        /// Default constructor no parameters
        /// </summary>
        /// 
        public StormDataClass() { }


        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="pStormDateOfOccurrence">Storm Date of Occurrence</param>
        /// <param name="pStormTime">Storm Time of Occurrence</param>
        /// <param name="pStormStatus">Storm Status</param> 
        /// <param name="pStormIndicator">Storm Indicator</param>
        /// <param name="pStormLatitude">Storm Lattitude</param>
        /// <param name="pStormLongitude">Storm Longitude</param>
        /// <param name="pStormWindSpeed">Wind Speed</param>
        /// <param name="pStormBaroPressure">Barometric Pressure</param>
        /// <param name="pStormID">Storm ID</param>
        /// 
        public StormDataClass(long pStormDateOfOccurrence, int pStormTime, string pStormStatus, string pStormIndicator,
            int pStormLatitude, decimal pStormLongitude, int pStormWindSpeed, int pStormBaroPressure, string pStormID)
        {
            StormDateOfOccurrence = pStormDateOfOccurrence;
            StormTime = pStormTime;
            StormLatitude = pStormLatitude;
            StormLongitude = pStormLongitude;
            StormWindSpeed = pStormWindSpeed;
            StormBaroPressure = pStormBaroPressure;
            StormStatus = pStormStatus;
            StormIndicator = pStormIndicator;
            StormID = pStormID;

        }
        #endregion


        #region Clas Properties
        /// <summary>
        /// Class method to get storm date of occurrence
        /// </summary>
        /// 
        public long StormDateOfOccurrence
        {
            get { return _stormDateOfOccurence; }
            set { _stormDateOfOccurence = value; }
        }


        /// <summary>
        /// Class method to get the storm time
        /// </summary>
        /// 
        public int StormTime
        {
            get { return _stormTime; }
            set { _stormTime = value; }
        }

        /// <summary>
        /// Class method to get the lattiude
        /// </summary>
        /// 
        public int StormLatitude
        {
            get { return _stormLatitude; }
            set { _stormLatitude = value; }
        }

        /// <summary>
        /// Class method to get the longitude
        /// </summary>
        /// 
        public decimal StormLongitude
        {
            get { return _stormLongitude; }
            set { _stormLongitude = value; }
        }

        /// <summary>
        /// Class method to get the Wind Speed
        /// </summary>
        /// 
        public int StormWindSpeed
        {
            get { return _stormWindSpeed; }
            set { _stormWindSpeed = value; }
        }

        /// <summary>
        /// Class method to get the Barometric Pressure
        /// </summary>
        /// 
        public int StormBaroPressure
        {
            get { return _stormBaroPressure; }
            set { _stormBaroPressure = value; }
        }

        /// <summary>
        /// Class method to get the two-letter Storm Status
        /// </summary>
        public string StormStatus
        {
            get { return _stormStatus; }
            set { _stormStatus = value.Trim(); }
        }

        /// <summary>
        /// Class method to get the storm one-letter Indicator
        /// </summary>
        public string StormIndicator
        {
            get { return _stormIndicator; }
            set { _stormIndicator = value.Trim(); }
        }

        /// <summary>
        /// Class method to get the storm's alphanumeric ID
        /// </summary>
        public string StormID
        {
            get { return _stormID; }
            set { _stormID = value.Trim(); }
        }

                
        /// <summary>
        /// Overriden ToString() method
        /// </summary>
        /// <returns>returns string representation of class object</returns>
        /// 
        public override string ToString()
        {
            string message;
            message = "Storm date: " + StormDateOfOccurrence +
                Environment.NewLine + "Storm time: " + StormTime +
                Environment.NewLine + "Storm indicator: " + StormIndicator +
                Environment.NewLine + "Storm status: " + StormStatus +
                Environment.NewLine + "Storm lattitude: " + StormLatitude +
                Environment.NewLine + "Storm longitude: " + StormLongitude +
                Environment.NewLine + "Storm windspeed: " + StormWindSpeed + "MPH" +
                Environment.NewLine + "Storm barometric pressure: " + StormBaroPressure + "millibars" +
                Environment.NewLine + "Storm ID: " + StormID;

            return message;
        }
        #endregion

        #region Destructors
        /// <summary>
        /// Destructor to release memory
        /// </summary>
        ~StormDataClass()
        {
            _stormIndicator = null;
            _stormStatus = null;
            _stormID = null;

        } 
        #endregion
    }

    

}
