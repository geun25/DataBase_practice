﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AppConfiguration
{
    public class ConfigurationMgr
    {
        private static ConfigurationMgr instance;

        public string ConnectionString { get; set; }

        IDbConnection connection;

        public IDbConnection Connection
        {
            get
            {
                if (connection == null)
                    connection = new SqlConnection(ConnectionString);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                return connection;
            }
            private set
            {

            }
        }

        private ConfigurationMgr()
        {
            LoadConfiguration();
        }
     
        private void LoadConfiguration()
        {
            Configuration currentconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionString = currentconfig.ConnectionStrings.ConnectionStrings["WinConnection"].ConnectionString; ;
        }

        public static ConfigurationMgr Instance()
        {
            if (instance == null)
                instance = new ConfigurationMgr();
            return instance;
        }
    }
}
