/* TomWeatherApp.cs
 * Tom Bielawski
 * 11/5/2020
 * COP2360C Project 6: Storm Identifier Class
 * Modified 11/28/2020
 * FSCJ Professor Gehrig*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomWeatherApp
{
    /// <summary>
    /// New class to gather the storm's name and ID  
    /// </summary>

    class StormIdentifierClass
    {

        #region Fields
        //Storm ID is an alphanumeric number referencing a storm beginning with a
        //AL followed by six digits. 
        private string _stormID;
        private string _stormName;
        #endregion


        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public StormIdentifierClass() { }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="pStormName">Storm Name</param>
        /// <param name="pStormID">Storm ID Number</param>
        public StormIdentifierClass(string pStormName, string pStormID)
        {
            StormID = pStormID;
            StormName = pStormName;
        }
        #endregion



        #region Class Properties
        /// <summary>
        /// Class method to get the alphanumeric storm ID
        /// </summary>
        public string StormID
        {
            get { return _stormID.Trim(); }
            set { _stormID = value; }
        }

        /// <summary>
        /// Class method to get the storm's name
        /// </summary>
        public string StormName
        {
            get { return _stormName.Trim(); }
            set { _stormName = value; }
        }

        /// <summary>
        /// overriden ToString() method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string message;
            message = "Storm name is " + StormName +
                Environment.NewLine + "Storm ID  is " + StormID;

            return message;
        }
        #endregion


        #region Destructor
        /// <summary>
        /// Destructor to release memory
        /// </summary>
        ~StormIdentifierClass()
        {
            _stormID = null;
            _stormName = null;
        } 
        #endregion


    }
}
