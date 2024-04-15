using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAB_EDP_Csharp_DemoProgram
{
    internal class DBManager
    {
        private readonly string connectionString = "server=localhost; database=hr; uid=root; pwd=mike;";
        
        public bool AuthenticateUser(string username, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            
            {
                conn.Open();
                var query = $"SELECT COUNT(1) FROM accounts WHERE Username=@Username AND Pass=@Password";
                using (var cmd = new MySqlCommand(query, conn))
                
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); 
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return count == 1;
                
                }
                
            }
            
        }
        public void InsertUser(string username, string password, string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "INSERT INTO Accounts (Username, Pass, Email) VALUES (@Username, @Pass, @Email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Pass", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void UpdateUser(string username, string password, string email)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "UPDATE Accounts SET Pass = @Password, Email = @Email WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void DeleteUser(string username)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "DELETE FROM accounts WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT UserID, Username, pass as Password, Email FROM accounts";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();   
            }
            return dt;
        }
        public User SearchUserByUsername(string username)
        {
            User user = null;
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT Username, Pass, Email FROM Accounts WHERE Username = @Username";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User()
                            {
                                //UserId = reader.GetInt32("UserId"),
                                Username = reader["Username"].ToString(),
                                password = reader["Pass"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                conn.Close();
                }
            }
            return user;
        }
        public class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string password { get; set; }
            public string Email { get; set; }
        }
    }
}
