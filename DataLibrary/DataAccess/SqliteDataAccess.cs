using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using DataLibrary.Models;

namespace DataLibrary.DataAccess
{
    public static class SqliteDataAccess
    {
        public static string GetConnectionString(string connectionName = "Default")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }
    }
}
