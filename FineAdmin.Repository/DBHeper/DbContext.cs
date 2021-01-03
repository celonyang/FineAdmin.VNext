using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.SqlClient;

namespace FineAdmin.Repository
{

    public class DbContext
    {
        public IConfiguration configuration { set; get; }

        public System.Data.IDbConnection GetConnection()
        {
            System.Data.IDbConnection connection = null;
            string connectionString = configuration.GetValue<string>("ConnectionStrings:sqlconn");
            //获取数据库类型
            string type = configuration.GetValue<string>("ConnectionStrings:type");
            if (type == "MySQL")
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            if (type == "Oracle")
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
                return connection;
            }
            if (type == "SqlServer")
            {
                //#if SQLSERVER
                connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            else
                throw new Exception("数据库类型错误");
        }

    }
}
