using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeManagement
{
    public static class Utils
    {
        private static readonly string connectionUrl = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public static MySqlConnection GetConnection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionUrl);
            mySqlConnection.Open();
            return mySqlConnection;
        }
    }
}
