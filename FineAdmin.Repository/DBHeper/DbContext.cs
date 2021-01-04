using DapperExtensions;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.SqlClient;

namespace FineAdmin.Repository
{

    public  class DbContext<T> where T : class, new()
    {
        public static System.Data.IDbConnection GetConnection()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true);
            var Configuration = builder.Build();

            string connectionString = null;
            string type = null;
            //获取模型类的连接字符串
            ConnStringAttribute constrAtribute = (ConnStringAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(ConnStringAttribute));
            if (constrAtribute == null)
            {
                connectionString = Configuration["ConnectionStrings:default:sqlconn"];
                //获取数据库类型
                type = Configuration["ConnectionStrings:default:type"];
            }
            else
            {
                string atributeProperty = constrAtribute.GetType().GetProperty("ConnName").ToString();
                connectionString = Configuration.GetValue<string>(string.Format("ConnectionStrings:{0}:sqlconn", atributeProperty));
                //获取数据库类型
                type = Configuration.GetValue<string>(string.Format("ConnectionStrings:{0}:type", atributeProperty));
            }
            System.Data.IDbConnection connection = null;

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
