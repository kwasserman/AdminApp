global using Serilog;
using static AdminSetting.Globals;
using static AdminSetting.ConnectionSettings;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using AdminSetting;



namespace AdminApp
{
    internal static class Program
    {
         
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        

        static void Main()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().WriteTo.File("C:\\Users\\krist\\OneDrive\\Desktop\\adminapp\\AdminApp\\logs\\events.txt").CreateLogger();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            login loginForm = new();


            if (loginForm.IsValid)
            {
                Application.Run(new MenuForm());
                
            }
            else
            {
                Application.Run(new login());
            }
          
            
            
        }
        
    }
}