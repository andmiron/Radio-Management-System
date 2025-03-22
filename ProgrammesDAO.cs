using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PublicUtilities
{
    internal class ProgrammesDAO
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();

        public void BindProgrammesData(DataGridView dataGridView)
        {
            BindingSource programmesBindingSource = new BindingSource();
            List<Programme> stations = this.GetAllProgrammes();
            programmesBindingSource.DataSource = stations;
            dataGridView.DataSource = programmesBindingSource;
        }

        public List<Programme> GetAllProgrammes()
        {
            List<City> cities = new List<City>();
            string query = "SELECT * FROM Programmes ORDER BY start_time ASC";

            return databaseHelper.GetAllEntities(query, reader => new Programme
            {
                Id = (int)reader["id"],
                StationId = (int)reader["station_id"],
                StartTime = (DateTime)reader["start_time"],
                EndTime = (DateTime)reader["end_time"],
                Name = reader["name"].ToString()
            });
        }

        public int AddProgramme(Programme programme)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Programmes (station_id, start_time, end_time, name) VALUES (@StationId, @StartTime, @EndTime, @Name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("StationId", programme.StationId);
                        command.Parameters.AddWithValue("StartTime", programme.StartTime);
                        command.Parameters.AddWithValue("EndTime", programme.EndTime);
                        command.Parameters.AddWithValue("@Name", programme.Name);
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

        public List<Programme> SearchProgrammes(int? stationId, DateTime? time, string? name) 
        {
            List<Programme> programmes = new List<Programme>();
            string initialQuery = "SELECT * FROM Programmes WHERE 1 = 1";
            List<SqlParameter> parameters = new List<SqlParameter>();
            
            if (stationId.HasValue)
            {
                initialQuery += " AND station_id = @StationId";
                parameters.Add(new SqlParameter("StationId", stationId));
            }

            if (time.HasValue) 
            {
                initialQuery += " AND CAST(start_time AS DATE) = @Time";
                parameters.Add(new SqlParameter("Time", time));
            }

            if (!string.IsNullOrEmpty(name))
            {
                initialQuery += " AND name = @Name";
                parameters.Add(new SqlParameter("Name", name));
            }

            initialQuery += " ORDER BY start_time ASC";

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
                                Programme programme = new Programme
                                {
                                    Id = (int)reader["id"],
                                    StationId = (int)reader["station_id"],
                                    StartTime = (DateTime)reader["start_time"],
                                    EndTime = (DateTime)reader["end_time"],
                                    Name = reader["name"].ToString()
                                };
                                programmes.Add(programme);
                            }
                        }
                    }
                }
                return programmes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Loading data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return programmes;
            }
        }

        public int EditProgramme(Programme programme)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    string query = "UPDATE Programmes SET station_id = @StationId, start_time = @StartTime, end_time = @EndTime, name = @Name WHERE id = @Id";
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable))
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@StationId", programme.StationId);
                                command.Parameters.AddWithValue("@StartTime", programme.StartTime);
                                command.Parameters.AddWithValue("@EndTime", programme.EndTime);
                                command.Parameters.AddWithValue("@Name", programme.Name);
                                command.Parameters.AddWithValue("@Id", programme.Id);
                                int updatedRows = command.ExecuteNonQuery();

                                transaction.Commit();
                                return updatedRows;
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error: {ex.Message}", "Updating Programme", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public int DeleteProgamme(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(databaseHelper.connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Programmes WHERE id = @Id";

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
                            MessageBox.Show($"Error: {ex.Message}", "Deleting City", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
