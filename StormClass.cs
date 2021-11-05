/* TomWeatherApp.cs
 * Tom Bielawski
 * 10/4/2020
 * COP2360C Project 6: Storm Class
 * Modified 11/25/2020
 * FSCJ Professor Gehrig*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


namespace TomWeatherApp
{

    /// <summary>
    /// Class Storm gets storm name, lattitude, longitude, and wind speed from user
    /// and displays it
    /// </summary>
    class Storm
    {
        #region Fields
        private string _stormName;
        private decimal _latitude, _longitude;
        private double _windSpeed;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor with default values
        /// </summary>
        //Storm Constructor, initialize fields with default values
        public Storm()
        {
            _stormName = " ";
            _latitude = 0m;
            _longitude = 0m;
            _windSpeed = 0.0;
        }
        #endregion


        #region Properties
        /// <summary>
        /// This property gets the storm name entered by the user
        /// </summary>
        //Name Properties
        public string StormName
        {
            get { return _stormName; }
            set { _stormName = value.Trim(); }

        }


        /// <summary>
        /// This property gets the lattitude entered by the user
        /// </summary>
        //lattitude property
        public decimal Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        /// <summary>
        /// This property gets the longitude entered by the user
        /// </summary>
        //longitude property
        public decimal Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }


        /// <summary>
        /// This property gets the Wind Speed entered by the user
        /// </summary>
        //Wind Speed property
        public double WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; }
        }

        /// <summary>
        /// This method returns the information to the user
        /// </summary>
        //ToString Method to print results
        public override string ToString()
        {
            string message;
            message = StormName + Environment.NewLine + WindSpeed + " MPH" + Environment.NewLine + Latitude + " degrees" + Environment.NewLine
                + Longitude + " degrees";
            return message;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// This is the destructor to free up RAM
        /// </summary>
        //Destructor
        ~Storm()
        {
            _stormName = null;

        } 
        #endregion




    }
}
