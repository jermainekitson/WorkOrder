using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Work_Order_Management_System
{
    public class Work_Order_Table
    {
        string serverAddress = ConfigurationManager.AppSettings.Get("server");
        string databaseName = ConfigurationManager.AppSettings.Get("database"); 
        string username = ConfigurationManager.AppSettings.Get("username");
        string password = ConfigurationManager.AppSettings.Get("password");
        string connectionString;
        public Work_Order_Table()
        {
            connectionString = $"server={serverAddress}; database={databaseName};" +
                               $" user id={username}; " +
                               $"password={password};";
        }
        
    }
}
