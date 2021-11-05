using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomWeatherApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Edit this line to determine which form loads when the program runs
            //Application.Run(new WeatherAppForm());
            //Uncomment to load Storm Name Maintenance Form first
            //Application.Run(new stormNameMaintenanceForm());
            //Application.Run(new LogInForm());
            //Application.Run(new StormDataMaintenanceForm());
            //Application.Run(new StormDataForm());
            //Application.Run(new StormForm());
            //Application.Run(new StormArchiveForm());
            //Application.Run(new StormLocationForm());
            //Application.Run(new ContactInfoForm());
            Application.Run(new ContactInfoMaintenanceForm());
        }
    }
}
