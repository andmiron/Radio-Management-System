using System.Text;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace PublicUtilities
{
    internal class AuthService
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NRMSDB"].ConnectionString;

        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT password FROM Users WHERE username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string storedPassword = result.ToString();
                            return storedPassword == password;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
