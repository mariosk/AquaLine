using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Aqua.Library;

namespace Aqua.User
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String ipAddress = ConfigurationSettings.AppSettings["mssqlIpAddress"].ToString();
            String dbName = ConfigurationSettings.AppSettings["mssqlDbName"].ToString();
            String comPort = ConfigurationSettings.AppSettings["comPort"].ToString();

            MainLibrary library = new MainLibrary("AquaAdmin.log", ipAddress, dbName, comPort);
            Application.EnableVisualStyles();
            Application.Run(new WashForm(library));
        }
    }
}