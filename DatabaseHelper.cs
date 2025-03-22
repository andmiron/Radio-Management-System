using Microsoft.Data.SqlClient;

namespace PublicUtilities
{
    internal class DatabaseHelper
    {
        public string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NRMSDB"].ConnectionString;

        public List<T> GetAllEntities<T>(string query, Func<SqlDataReader, T> createEntity) where T : class
        {
            List<T> entities = new List<T>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T entity = createEntity(reader);
                            entities.Add(entity);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return entities;
        }
    }
}
