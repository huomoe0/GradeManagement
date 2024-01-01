using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace GradeDAL
{
    public class SqlHelper
    {
        private static readonly string connectionUrl = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        private static MySqlConnection GetConnection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionUrl);
            mySqlConnection.Open();
            return mySqlConnection;
        }
        /// <summary>
        /// 封装配置MySqlCommand
        /// </summary>
        private static void ConfigureCommand(MySqlCommand cmd, CommandType commandType, MySqlParameter[]? parameters)
        {
            cmd.CommandType = commandType;
            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
        }

        /// <summary>
        /// 执行一个查询，并返回查询结果
        /// </summary>
        public static DataTable ExecuteDataTable(string commandText, CommandType commandType, MySqlParameter[]? parameters)
        {
            using MySqlConnection conn = GetConnection();
            using MySqlCommand cmd = new MySqlCommand(commandText, conn);
            ConfigureCommand(cmd, commandType, parameters);
            DataSet ds = new();
            MySqlDataAdapter mda = new(cmd);
            mda.Fill(ds);
            return ds.Tables[0];
        }
        /// <summary>
        /// 执行一个查询，并返回查询结果
        /// </summary>
        public static DataTable ExecuteDataTable(string commandText)
        {
            return ExecuteDataTable(commandText, CommandType.Text, null);
        }
        /// <summary>
        /// 将CommandText发送到Connection并生成一个MySqlDataReader
        /// </summary>
        public static MySqlDataReader ExecuteReader (string commandText, CommandType commandType, MySqlParameter[]? parameters)
        {
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new(commandText, conn);
            ConfigureCommand(cmd, commandType, parameters);
            // 关闭Reader时也关闭Connection
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        /// <summary>
        /// 将CommandText发送到Connection并生成一个MySqlDataReader
        /// </summary>
        public static MySqlDataReader ExecuteReader(string commandText)
        {
            return ExecuteReader(commandText, CommandType.Text, null);
        }
        /// <summary>
        /// 将CommandText发送到Connection并生成一个MySqlDataReader
        /// </summary>
        public static MySqlDataReader ExecuteReader(string commandText, CommandType commandType)
        {
            return ExecuteReader(commandText, commandType, null);
        }
        /// <summary>
        /// 从数据库中检索出单个值
        /// </summary>
        public static Object ExecuteScalar(string commandText, CommandType commandType = CommandType.Text, MySqlParameter[]? parameters = null)
        {
            using MySqlConnection conn = GetConnection();
            using MySqlCommand cmd = new(commandText, conn);
            ConfigureCommand(cmd, commandType, parameters);
            object? res = cmd.ExecuteScalar();
            return res;
        }
        /// <summary>
        /// 增删改操作
        /// </summary>
        public static int ExecuteNonQuery(string commandText, CommandType commandType = CommandType.Text, MySqlParameter[]? parameters = null)
        {
            using MySqlConnection conn = GetConnection();
            using MySqlCommand cmd = new(commandText, conn);
            ConfigureCommand(cmd, commandType, parameters);
            int count = cmd.ExecuteNonQuery();
            return count;
        }
    }
}
