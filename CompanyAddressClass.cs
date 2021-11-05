/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/20/2020
 * COP2360C Project 6: Weather App
 * Company Address Class
 * Modified 11/25/2020
 * FSCJ Professor Gehrig*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TomWeatherApp
{
    /// <summary>
    /// Class to obtain the company address information
    /// </summary>
    class CompanyAddressClass
    {
        #region Private Fields
        private string _companyName;
        private string _companyStreetAddress;
        private string _companyCity;
        private string _companyState;
        private int _companyZipCode;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public CompanyAddressClass() { }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="pCompanyName">The company name</param>
        /// <param name="pCompanyStreetAddress">The company address</param>
        /// <param name="pCompanyCity">The company city</param>
        /// <param name="pCompanyState">The company state</param>
        /// <param name="pCompanyZipCode">The company zip code</param>
        public CompanyAddressClass(string pCompanyName, string pCompanyStreetAddress, string pCompanyCity,
            string pCompanyState, int pCompanyZipCode)
        {
            CompanyName = pCompanyName;
            CompanyStreetAdress = pCompanyStreetAddress;
            CompanyCity = pCompanyCity;
            CompanyState = pCompanyState;
            CompanyZipCode = pCompanyZipCode;

        }
        #endregion

        #region Properties / Class Methods

        /// <summary>
        /// Method to get the company name
        /// </summary>
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value.Trim(); }
        }

        /// <summary>
        /// Method to get the street address
        /// </summary>
        public string CompanyStreetAdress
        {
            get { return _companyStreetAddress; }
            set { _companyStreetAddress = value.Trim(); }
        }

        /// <summary>
        /// Method to get the company city
        /// </summary>
        public string CompanyCity
        {
            get { return _companyCity; }
            set { _companyCity = value.Trim(); }
        }

        /// <summary>
        /// Method to get the company state
        /// </summary>
        public string CompanyState
        {
            get { return _companyState; }
            set { _companyState = value.Trim(); }
        }

        /// <summary>
        /// Method to get the company zip code
        /// </summary>
        public int CompanyZipCode
        {
            get { return _companyZipCode; }
            set { _companyZipCode = value; }
        }

        /// <summary>
        /// ToString Method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message;
            message = Environment.NewLine + "Company Name: " + CompanyName +
                Environment.NewLine + "Street Address " + CompanyStreetAdress +
                Environment.NewLine + "City: " + CompanyCity +
                Environment.NewLine + "State: " + CompanyState +
                Environment.NewLine + "Zip Code: " + CompanyZipCode;

            return message;
        }
        #endregion

        #region Destructors
        /// <summary>
        /// Class Destructort to release memory
        /// </summary>
        ~CompanyAddressClass()
        {
            _companyName = null;
            _companyStreetAddress = null;
            _companyCity = null;
            _companyState = null;

        } 
        #endregion

    }

}