using STORE_X.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X.DAL
{
    public class User_DAL
    {
        private string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=STORE_X;Integrated Security=True";
        List<User> users = new List<User>();
        // ham lay danh sach ten nguoi dung
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID, Username, RoleID FROM Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        RoleID = (int)reader["RoleID"]
                    });
                }
            }
            return users;
        }

        // ham them nguoi dung
        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, RoleID) VALUES (@Username, @Password, @RoleID)", conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@RoleID", user.RoleID);
                cmd.ExecuteNonQuery();
            }
        }

        // Hàm cập nhật thông tin người dùng
        public void UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET Username = @Username, Password = @Password, RoleID = @RoleID WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@RoleID", user.RoleID);
                cmd.ExecuteNonQuery();
            }
        }

        // Hàm xóa người dùng
        public void DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
