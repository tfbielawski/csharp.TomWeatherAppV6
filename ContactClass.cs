/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/20/2020
 * COP2360C Project 6: Weather App
 * Contact Class
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
    /// Contact Class to get company name and address
    /// </summary>
    class ContactClass : CompanyAddressClass
    {
        #region Fields
        private string _contactPersonName;
        private string _contactPersonCompanyName;
        private string _contactPersonCompanyStreetAddress;
        private string _contactPersonCompanyCity;
        private string _contactPersonCompanyState;
        private int _contactPersonCompanyZipCode;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// 
        public ContactClass() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pContactPersonName">Contact Person Name</param>
        /// <param name="pContactPersonCompanyName">Contact Person's Company Name</param>
        /// <param name="pContactPersonCompanyStreetAddress">Contact Person's Company Street Adress</param>
        /// <param name="pContactPersonCompanyCity">Contact Person's Company City</param>
        /// <param name="pContactPersonCompanyState">Contact Person's Company State</param>
        /// <param name="pContactPersonCompanyZipCode">Contact Person's Company Zip</param>
        public ContactClass(string pContactPersonName, string pContactPersonCompanyName, string pContactPersonCompanyStreetAddress,
            string pContactPersonCompanyCity, string pContactPersonCompanyState, int pContactPersonCompanyZipCode )
        {
            ContactPersonName = pContactPersonName;
            ContactPersonCompanyName = pContactPersonCompanyName;
            ContactPersonCompanyStreetAddress = pContactPersonCompanyStreetAddress;
            ContactPersonCompanyCity = pContactPersonCompanyCity;
            ContactPersonCompanyState = pContactPersonCompanyState;
            ContactPersonCompanyZipCode = pContactPersonCompanyZipCode;
        }
        #endregion

        #region Properties / Class Methods
        /// <summary>
        /// Method to get the contact Person's name
        /// </summary>
        public string ContactPersonName
        {
            get { return _contactPersonName; }
            set { _contactPersonName = value.Trim(); }
        }

        /// <summary>
        /// Gets the contact person company's name
        /// </summary>
        public string ContactPersonCompanyName
        {
            get { return _contactPersonCompanyName; }
            set { _contactPersonCompanyName = value.Trim(); }
        }

        /// <summary>
        ///  Method to get the contact company's street address
        /// </summary>
        public string ContactPersonCompanyStreetAddress
        {
            get { return _contactPersonCompanyStreetAddress; }
            set { _contactPersonCompanyStreetAddress = value.Trim(); }
        }

        /// <summary>
        /// Method to get the contact company's City
        /// </summary>
        public string ContactPersonCompanyCity
        {
            get { return _contactPersonCompanyCity; }
            set { _contactPersonCompanyCity = value.Trim(); }
        }

        /// <summary>
        ///  Method to get the contact company's state
        /// </summary>
        public string ContactPersonCompanyState
        {
            get { return _contactPersonCompanyState; }
            set { _contactPersonCompanyState = value.Trim(); }
        }

        /// <summary>
        /// Method to get the contact company's zip
        /// </summary>
        public int ContactPersonCompanyZipCode
        {
            get { return _contactPersonCompanyZipCode; }
            set { _contactPersonCompanyZipCode = value; }
        }

        /// <summary>
        /// Override ToString() method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message = "Contact Peron's Name: " + ContactPersonName +
            Environment.NewLine + " Contact Person's Company Name:" + ContactPersonCompanyName +
            Environment.NewLine + " Contact Person's Company Street Address: " + ContactPersonCompanyStreetAddress +
            Environment.NewLine + " Contact Person's Company City: " + ContactPersonCompanyCity +
            Environment.NewLine + " Contact Person's Company State: " + ContactPersonCompanyState +
            Environment.NewLine + " Contact Person's Company Zip Code: " + ContactPersonCompanyZipCode;

            //Return this ToString along with the base.ToString()
            return Environment.NewLine + message + Environment.NewLine + base.ToString();
        }
        #endregion

        #region Destructors
        /// <summary>
        /// Destructor to release memory
        /// </summary>
        ~ContactClass()
        {
            _contactPersonName = null;
            _contactPersonCompanyName = null;
            _contactPersonCompanyStreetAddress = null;
            _contactPersonCompanyCity = null;
            _contactPersonCompanyState = null;
        }
        #endregion
    }
}
