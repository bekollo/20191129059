using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace satis_core.Helpers
{
    public class DatabaseHelper
    {
        private static string ConnectionString = "Server=localhost,1433; Database=satis_db; User Id=SA; Password=!satis2021";

        public static IDbConnection Connection => new SqlConnection(ConnectionString);
    }
}
