using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace PublicUtilities
{
    internal class CitiesDAO
    {
        public DatabaseHelper databaseHelper = new DatabaseHelper();

        public BindingSource BindCitiesData(DataGridView dataGridView)
        {
            BindingSource citiesBindingSource = new BindingSource();
            List<City> cities = this.GetAllCities();
            citiesBindingSource.DataSource = cities;
            dataGridView.DataSource = citiesBindingSource;

            return citiesBindingSource;
        }

        public List<City> GetAllCities()
        {
            List<City> cities = new List<City>();
            string query = "SELECT * FROM Cities";

            return databaseHelper.GetAllEntities(query, reader => new City
            {
                Id = (int)reader["id"],
                Name = reader["name"].ToString()
            });
        }

        public int AddCity(City city)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Cities (name) VALUES (@Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", city.Name);
                        int newRows = command.ExecuteNonQuery();
                        return newRows;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public List<City> SearchCities(int? id, string? name)
        {
            List<City> cities = new List<City>();
            string initialQuery = "SELECT * FROM Cities WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (id.HasValue)
            {
                initialQuery += " AND id = @Id";
                parameters.Add(new SqlParameter("Id", id));
            }

            if (!string.IsNullOrEmpty(name))
            {
                initialQuery += " AND name = @Name";
                parameters.Add(new SqlParameter("Name", name));
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(initialQuery, connection))
                    {
                        command.Parameters.AddRange(parameters.ToArray());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                City city = new City
                                {
                                    Id = (int)reader["id"],
                                    Name = reader["name"].ToString()
                                };
                                cities.Add(city);
                            }
                        }
                    }
                }
                return cities;
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return cities;
            }
        }

        public int EditCity(City city)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    string query = "UPDATE Cities SET name = @Name WHERE id = @Id";
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable))
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", city.Id);
                                command.Parameters.AddWithValue("@Name", city.Name);
                                int updatedRows = command.ExecuteNonQuery();

                                transaction.Commit();
                                return updatedRows;
                            }
                        }
                        catch (Exception ex)
                        { 
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}", "Updating City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int DeleteCity(int cityId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Cities WHERE id = @Id";

                    using (SqlTransaction transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable))
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", cityId);
                                int deletedRows = command.ExecuteNonQuery();

                                transaction.Commit();
                                return deletedRows;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}", "Deleting City", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Connection Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
