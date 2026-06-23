
       
using System.Data.SqlClient;  

 class DbConfig
    {
        
        public static string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=SmartEcoCampus;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }


