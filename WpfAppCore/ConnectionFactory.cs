using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

namespace WpfAppCore
{
    public static class ConnectionFactory
    {
        public static string GetConnectionString()
        {
            var dbFilePath = Directory.GetCurrentDirectory();
            var executingAssemblyLocation = Assembly.GetExecutingAssembly().Location;
            var appSettingsSection = ConfigurationManager.OpenExeConfiguration(executingAssemblyLocation).AppSettings;
            var connectionStringsSection = ConfigurationManager.OpenExeConfiguration(executingAssemblyLocation).ConnectionStrings;

            var dbFileName = connectionStringsSection.ConnectionStrings["chinook"].ConnectionString;
            
            return $@"Data Source={dbFilePath}\{dbFileName}";
        }
        
    }
}
