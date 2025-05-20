using Microsoft.Data.SqlClient;
using System.Data;
using PublicUtilities;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PublicUtilitiesLoginScreen
{
    public partial class RADIO : Form
    {
        CitiesDAO citiesDAO = new CitiesDAO();
        StationsDAO stationsDAO = new StationsDAO();
        ProgrammesDAO programmesDAO = new ProgrammesDAO();

        public RADIO()
        {
            InitializeComponent();
        }

        private void RADIO_Load(object sender, EventArgs e)
        {
            citiesDAO.BindCitiesData(CitiesDataGridView);
            stationsDAO.BindStationsData(StationsDataGridView);
            programmesDAO.BindProgrammesData(ProgrammesDataGridView);
            GetUserLogs();
        }

        private void GetUserLogs()
        {
            string query = "SELECT * FROM UserActivityLog";

            using (SqlConnection connection = new SqlConnection(citiesDAO.databaseHelper.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                UserLogsDataGridView.DataSource = dataTable;
            }
        }

        private void StationsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddNewStationComboBox.DataSource = citiesDAO.BindCitiesData(CitiesDataGridView).DataSource;
            AddNewStationComboBox.DisplayMember = "Name";
            AddNewStationComboBox.ValueMember = "Id";
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            string cityName = AddCityInput.Text;

            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            City newCity = new City
            {
                Name = cityName,
            };

            int result = citiesDAO.AddCity(newCity);

            if (result > 0)
            {
                MessageBox.Show("New city added!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                citiesDAO.BindCitiesData(CitiesDataGridView);
                AddCityInput.Text = "";
            }
        }

        private void FilterCitiesButton_Click(object sender, EventArgs e)
        {
            int? id = string.IsNullOrEmpty(FilterCityIdInput.Text) ? null : int.Parse(FilterCityIdInput.Text);
            string name = string.IsNullOrEmpty(FilterCityNameInput.Text) ? null : FilterCityNameInput.Text;

            if (id.HasValue ||
                !string.IsNullOrEmpty(name))
            {
                List<City> cities = citiesDAO.SearchCities(id, name);

                if (cities.Count > 0)
                {
                    CitiesDataGridView.DataSource = cities;
                }
                else
                {
                    MessageBox.Show("There are no cities matching the search!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                citiesDAO.BindCitiesData(CitiesDataGridView);
            }
        }

        private void EditCityButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = CitiesDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = CitiesDataGridView.Rows[selectedRowIndex];

            City editedCity = new City
            {
                Id = (int)selectedRow.Cells["Id"].Value,
                Name = selectedRow.Cells["Name"].Value.ToString()
            };

            if (MessageBox.Show("Edit selected city?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = citiesDAO.EditCity(editedCity);

                if (result > 0)
                {
                    MessageBox.Show("City updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    citiesDAO.BindCitiesData(CitiesDataGridView);
                }
            }
        }

        private void DeleteCityButton_Click(object sender, EventArgs e)
        {
            if (CitiesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a city to delete.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedGridRow = CitiesDataGridView.CurrentRow.Index;

            int cityId = (int)CitiesDataGridView.Rows[selectedGridRow].Cells[0].Value;

            if (MessageBox.Show("Delete this city?", "Deleteion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = citiesDAO.DeleteCity(cityId);

                if (result > 0)
                {
                    MessageBox.Show("City deleted!", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    citiesDAO.BindCitiesData(CitiesDataGridView);
                }
            }
        }

        private void AddNewStationButton_Click(object sender, EventArgs e)
        {
            int cityId = (int)AddNewStationComboBox.SelectedValue;
            string name = AddNewStationNameInput.Text;
            decimal frequency;

            if (!decimal.TryParse(AddNewStationFrequencyInput.Text, out frequency))
            {
                MessageBox.Show("Invalid frequency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Station newStation = new Station
            {
                CityId = cityId,
                Frequency = frequency,
                Name = name
            };

            int result = stationsDAO.AddStation(newStation);

            if (result > 0)
            {
                MessageBox.Show("New station added!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stationsDAO.BindStationsData(StationsDataGridView);
            }
        }

        private void FilterStationsButton_Click(object sender, EventArgs e)
        {
            int? id = string.IsNullOrEmpty(FilterStationsIdInput.Text) ? null : int.Parse(FilterStationsIdInput.Text);
            int? cityId = string.IsNullOrEmpty(FilterStationsCityInput.Text) ? null : int.Parse(FilterStationsCityInput.Text);
            decimal? frequency = string.IsNullOrEmpty(FilterStationsFrequencyInput.Text) ? null : decimal.Parse(FilterStationsFrequencyInput.Text);
            string? name = string.IsNullOrEmpty(FilterStationsNameInput.Text) ? null : FilterStationsNameInput.Text;

            if (id.HasValue ||
                cityId.HasValue ||
                frequency.HasValue ||
                !string.IsNullOrEmpty(name))
            {
                List<Station> stations = stationsDAO.SearchStations(id, cityId, frequency, name);

                if (stations.Count > 0)
                {
                    StationsDataGridView.DataSource = stations;
                }
                else
                {
                    MessageBox.Show("There are no stations matching the search!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                stationsDAO.BindStationsData(StationsDataGridView);
            }
        }

        private void EditStationButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = StationsDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = StationsDataGridView.Rows[selectedRowIndex];

            Station editedStation = new Station
            {
                Id = (int)selectedRow.Cells["Id"].Value,
                CityId = (int)selectedRow.Cells["CityId"].Value,
                Frequency = (decimal)selectedRow.Cells["Frequency"].Value,
                Name = selectedRow.Cells["Name"].Value.ToString()
            };

            if (MessageBox.Show("Edit selected station?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = stationsDAO.EditStation(editedStation);

                if (result > 0)
                {
                    MessageBox.Show("Station updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stationsDAO.BindStationsData(StationsDataGridView);
                }
            }
        }

        private void DeleteStationButton_Click(object sender, EventArgs e)
        {
            if (StationsDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a station to delete.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedGridRow = StationsDataGridView.CurrentRow.Index;
            int stationId = (int)StationsDataGridView.Rows[selectedGridRow].Cells[0].Value;

            if (MessageBox.Show("Delete this station?", "Deleteion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = stationsDAO.DeleteStation(stationId);

                if (result > 0)
                {
                    MessageBox.Show("Station deleted!", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    stationsDAO.BindStationsData(StationsDataGridView);
                }
            }
        }

        private void AddProgrammeButton_Click(object sender, EventArgs e)
        {
            int stationId = int.Parse(AddProgrammeStationId.Text);
            string name = AddProgrammeName.Text;
            DateTime startTime = AddProgrammeStartTime.Value;
            DateTime endTime = AddProgrammeEndTime.Value;

            Programme programme = new Programme
            {
                StationId = stationId,
                Name = name,
                StartTime = startTime,
                EndTime = endTime
            };

            int result = programmesDAO.AddProgramme(programme);

            if (result > 0)
            {
                MessageBox.Show("New programme added!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                programmesDAO.BindProgrammesData(ProgrammesDataGridView);
            }
        }

        private void FilterProgrammesButton_Click(object sender, EventArgs e)
        {
            int? stationId = string.IsNullOrEmpty(FilterProgrammesStationId.Text) ? null : int.Parse(FilterProgrammesStationId.Text);
            string? name = string.IsNullOrEmpty(FilterProgrammesName.Text) ? null : FilterProgrammesName.Text;
            DateTime? time = FilterProgrammesDatePicker.Checked ? FilterProgrammesDatePicker.Value : null;


            if (stationId.HasValue ||
                time.HasValue ||
                !string.IsNullOrEmpty(name))
            {
                List<Programme> programmes = programmesDAO.SearchProgrammes(stationId, time, name);

                if (programmes.Count > 0)
                {
                    ProgrammesDataGridView.DataSource = programmes;
                }
                else
                {
                    MessageBox.Show("There are no programmes matching the search!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                programmesDAO.BindProgrammesData(ProgrammesDataGridView);
            }
        }

        private void EditProgrammeButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = ProgrammesDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = ProgrammesDataGridView.Rows[selectedRowIndex];

            Programme editedProgramme = new Programme
            {
                Id = (int)selectedRow.Cells["Id"].Value,
                StationId = (int)selectedRow.Cells["StationId"].Value,
                Name = selectedRow.Cells["Name"].Value.ToString(),
                StartTime = (DateTime)selectedRow.Cells["StartTime"].Value,
                EndTime = (DateTime)selectedRow.Cells["EndTime"].Value
            };

            if (MessageBox.Show("Edit selected programme?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = programmesDAO.EditProgramme(editedProgramme);

                if (result > 0)
                {
                    MessageBox.Show("Programme updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    programmesDAO.BindProgrammesData(ProgrammesDataGridView);
                }
            }
        }

        private void DeleteProgrammeButton_Click(object sender, EventArgs e)
        {
            if (ProgrammesDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a programme to delete.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedGridRow = ProgrammesDataGridView.CurrentRow.Index;
            int id = (int)ProgrammesDataGridView.Rows[selectedGridRow].Cells[0].Value;

            if (MessageBox.Show("Delete this programme?", "Deleteion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = programmesDAO.DeleteProgamme(id);

                if (result > 0)
                {
                    MessageBox.Show("Programme deleted!", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    programmesDAO.BindProgrammesData(ProgrammesDataGridView);
                }
            }
        }

        private void RefreshUserLogs_Click(object sender, EventArgs e)
        {
            GetUserLogs();
        }

        private void ReportsCalendar_DateSelected(object sender, EventArgs e)
        {
            DateTime selectedDate = ReportsCalendar.SelectionStart;

            try
            {
                using (SqlConnection connection = new SqlConnection(citiesDAO.databaseHelper.connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            c.name AS CityName,
                            s.name AS StationName,
                            s.frequency AS StationFrequency,
                            p.name AS ProgrammeName,
                            p.start_time AS StartTime,
                            p.end_time AS EndTime
                        FROM 
                            Programmes p
                        INNER JOIN 
                            Stations s ON p.station_id = s.id
                        INNER JOIN 
                            Cities c ON s.city_id = c.id
                        WHERE 
                            CONVERT(DATE, p.start_time) = @SelectedDate
                        ORDER BY 
                            c.name, s.name, p.start_time";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    ReportsDataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not get the programmes data!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportToExcelEPPlus(DataGridView dataGridView, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {
                var worksheet = excel.Workbook.Worksheets.Add("RadioProgrammes");

                // Add headers
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                }

                // Add data
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                // Autofit columns
                worksheet.Cells.AutoFitColumns();

                // Save to file
                FileInfo file = new FileInfo(filePath);
                excel.SaveAs(file);
            }

            MessageBox.Show("Data exported successfully to " + filePath, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReportsSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Save as Excel File",
                FileName = "RadioProgrammes_" + DateTime.Now.ToString("ddMMyyyy")
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelEPPlus(ReportsDataGridView, saveFileDialog.FileName);
            }
        }

        private void PrintDataGridView(DataGridView dataGridView)
        {
            PrintDocument printDoc = new PrintDocument();

            printDoc.PrintPage += (sender, e) => PrintPage(sender, e, dataGridView);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 600,
                Height = 800,
                StartPosition = FormStartPosition.CenterScreen
            };

            printPreviewDialog.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e, DataGridView dataGridView)
        {
            int startX = 10;
            int startY = 10;
            int cellHeight = 40;
            int cellWidth = 150;
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font textFont = new Font("Arial", 9);

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                e.Graphics.DrawString(
                    dataGridView.Columns[i].HeaderText,
                    headerFont,
                    Brushes.Black,
                    startX + (i * cellWidth),
                    startY
                );
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    string cellValue = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                    e.Graphics.DrawString(
                        cellValue,
                        textFont,
                        Brushes.Black,
                        startX + (j * cellWidth),
                        startY + ((i + 1) * cellHeight)
                    );
                }
            }
            e.HasMorePages = false;
        }


        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            PrintDataGridView(ReportsDataGridView);
        }
    }
}
