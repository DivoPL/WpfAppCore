using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WpfAppCore
{
    public static class ConnectionFactory
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
        }
        
    }
}
