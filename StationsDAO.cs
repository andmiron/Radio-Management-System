using Microsoft.Data.SqlClient;

namespace PublicUtilities
{
    internal class StationsDAO
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();

        public void BindStationsData(DataGridView dataGridView)
        {
            BindingSource stationsBindingSource = new BindingSource();
            List<Station> stations = this.GetAllStations();
            stationsBindingSource.DataSource = stations;
            dataGridView.DataSource = stationsBindingSource;
        }

        public List<Station> GetAllStations()
        {
            List<City> cities = new();
            string query = "SELECT * FROM Stations";

            return databaseHelper.GetAllEntities(query, reader => new Station
            {
                Id = (int)reader["id"],
                CityId = (int)reader["city_id"],
                Frequency = (decimal)reader["frequency"],
                Name = reader["name"].ToString()
            });
        }

        public int AddStation(Station station)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Stations (city_id, frequency, name) VALUES (@CityId, @Frequency, @Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CityId", station.CityId);
                        command.Parameters.AddWithValue("@Frequency", station.Frequency);
                        command.Parameters.AddWithValue("@Name", station.Name);
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

        public List<Station> SearchStations(int? id, int? cityId, decimal? frequency, string? name)
        {
            List<Station> stations = new List<Station>();
            string initialQuery = "SELECT * FROM Stations WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (id.HasValue)
            {
                initialQuery += " AND id = @Id";
                parameters.Add(new SqlParameter("Id", id));
            }
            
            if (cityId.HasValue)
            {
                initialQuery += " AND city_id = @CityId";
                parameters.Add(new SqlParameter("CityId", cityId));
            }

            if (frequency.HasValue)
            {
                initialQuery += " AND frequency = @Frequency";
                parameters.Add(new SqlParameter("Frequency", frequency));
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
                                Station station = new Station
                                {
                                    Id = (int)reader["id"],
                                    CityId = (int)reader["city_id"],
                                    Frequency = (decimal)reader["frequency"],
                                    Name = reader["name"].ToString()
                                };
                                stations.Add(station);
                            }
                        }
                    }
                }
                return stations;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return stations;
            }
        }

        public int EditStation(Station station)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    string query = "UPDATE Stations SET city_id = @CityId, frequency = @Frequency, name = @Name WHERE id = @Id";
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable))
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", station.Id);
                                command.Parameters.AddWithValue("CityId", station.CityId);
                                command.Parameters.AddWithValue("Frequency", station.Frequency);
                                command.Parameters.AddWithValue("@Name", station.Name);
                                int updatedRows = command.ExecuteNonQuery();

                                transaction.Commit();
                                return updatedRows;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}", "Updating Station", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public int DeleteStation(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Stations WHERE id = @Id";

                    using (SqlTransaction transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable))
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Id", id);
                                int deletedRows = command.ExecuteNonQuery();

                                transaction.Commit();
                                return deletedRows;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}", "Deleting Station", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
