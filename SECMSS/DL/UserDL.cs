using SECMSS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace SECMSS.DL
{
    class UserDL
    {
        public bool SignUpReporter(UserModel user)
        {

            using (SqlConnection conn = DbConfig.GetConnection())
            {

                string query = "INSERT INTO Users (Name, Age, Email, Password, Role) " +
                               "VALUES (@Name, @Age, @Email, @Password, 'Reporter')";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Age", user.Age);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }


        }
        public bool IsEmailExists(string email)
        {
            using (SqlConnection conn = DbConfig.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public UserModel Login(string email, string password)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string roleFromDB = reader["Role"].ToString();
                        

                        UserModel user;
                      
                        if (roleFromDB.Equals("Admin", StringComparison.OrdinalIgnoreCase)) user = new Admin();
                        else if (roleFromDB.Equals("Supervisor", StringComparison.OrdinalIgnoreCase)) user = new Supervisor();
                        else user = new Reporter();

                        user.UserId = (int)reader["UserId"];
                        user.Name = reader["Name"].ToString();
                        user.Role = roleFromDB;
                        return user;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Connection Error: " + ex.Message);
                return null;
            }
        }
        

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> userList = new List<UserModel>();
            using (SqlConnection conn = DbConfig.GetConnection())
            {
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    UserModel user;

                    if (role == "Admin") user = new Admin();
                    else if (role == "Supervisor") user = new Supervisor();
                    else user = new Reporter();

                    user.UserId = (int)reader["UserId"];
                    user.Name = reader["Name"].ToString();
                    user.Age = (int)reader["Age"];
                    user.Email = reader["Email"].ToString();
                    user.Role = role;

                    userList.Add(user);
                }
            }
            return userList;
        }
        public bool DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection conn = DbConfig.GetConnection())
                {
                    string query = "DELETE FROM Users WHERE UserId = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("SQL ERROR: " + ex.Message);
                return false;
            }
        }
     
        public List<Reporter> GetAllReporters()
        {
            List<Reporter> reporters = new List<Reporter>();
            using (SqlConnection conn = DbConfig.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Role = 'Reporter'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reporters.Add(new Reporter(
                        (int)reader["UserId"], reader["Name"].ToString(),
                        (int)reader["Age"], reader["Email"].ToString(),
                        "", "Reporter"
                    ));
                }
            }
            return reporters;
        }


    }
}


