namespace PublicUtilitiesLoginScreen
{
    partial class RADIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AppTabControl = new TabControl();
            StationsTabPage = new TabPage();
            groupBox9 = new GroupBox();
            EditStationButton = new Button();
            label9 = new Label();
            groupBox10 = new GroupBox();
            FilterStationsCityInput = new TextBox();
            FilterStationsFrequencyInput = new TextBox();
            label16 = new Label();
            label15 = new Label();
            FilterStationsButton = new Button();
            FilterStationsNameInput = new TextBox();
            label10 = new Label();
            FilterStationsIdInput = new TextBox();
            label11 = new Label();
            groupBox11 = new GroupBox();
            AddNewStationFrequencyInput = new TextBox();
            label14 = new Label();
            AddNewStationComboBox = new ComboBox();
            label13 = new Label();
            AddNewStationButton = new Button();
            AddNewStationNameInput = new TextBox();
            label12 = new Label();
            groupBox12 = new GroupBox();
            textBox9 = new TextBox();
            DeleteStationButton = new Button();
            StationsDataGridView = new DataGridView();
            ProgrammesTabPage = new TabPage();
            groupBox8 = new GroupBox();
            DeleteProgrammeButton = new Button();
            label21 = new Label();
            groupBox6 = new GroupBox();
            EditProgrammeButton = new Button();
            label20 = new Label();
            groupBox5 = new GroupBox();
            FilterProgrammesButton = new Button();
            FilterProgrammesName = new TextBox();
            label19 = new Label();
            FilterProgrammesStationId = new TextBox();
            label18 = new Label();
            label17 = new Label();
            FilterProgrammesDatePicker = new DateTimePicker();
            groupBox7 = new GroupBox();
            AddProgrammeStationId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            AddProgrammeName = new TextBox();
            AddProgrammeEndTime = new DateTimePicker();
            label8 = new Label();
            AddProgrammeStartTime = new DateTimePicker();
            AddProgrammeButton = new Button();
            ProgrammesDataGridView = new DataGridView();
            CitiesTabPage = new TabPage();
            groupBox3 = new GroupBox();
            EditCityButton = new Button();
            label4 = new Label();
            groupBox2 = new GroupBox();
            FilterCitiesButton = new Button();
            FilterCityNameInput = new TextBox();
            label3 = new Label();
            FilterCityIdInput = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            AddCityButton = new Button();
            AddCityInput = new TextBox();
            label1 = new Label();
            CitiesDataGridView = new DataGridView();
            groupBox4 = new GroupBox();
            textBox1 = new TextBox();
            DeleteCityButton = new Button();
            tabPage1 = new TabPage();
            RefreshUserLogs = new Button();
            UserLogsDataGridView = new DataGridView();
            tabPage2 = new TabPage();
            label22 = new Label();
            ReportsSaveButton = new Button();
            ReportsCalendar = new MonthCalendar();
            ReportsDataGridView = new DataGridView();
            AppTabControl.SuspendLayout();
            StationsTabPage.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StationsDataGridView).BeginInit();
            ProgrammesTabPage.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProgrammesDataGridView).BeginInit();
            CitiesTabPage.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CitiesDataGridView).BeginInit();
            groupBox4.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserLogsDataGridView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AppTabControl
            // 
            AppTabControl.Controls.Add(StationsTabPage);
            AppTabControl.Controls.Add(ProgrammesTabPage);
            AppTabControl.Controls.Add(CitiesTabPage);
            AppTabControl.Controls.Add(tabPage1);
            AppTabControl.Controls.Add(tabPage2);
            AppTabControl.Location = new Point(12, 12);
            AppTabControl.Name = "AppTabControl";
            AppTabControl.SelectedIndex = 0;
            AppTabControl.Size = new Size(958, 529);
            AppTabControl.TabIndex = 0;
            // 
            // StationsTabPage
            // 
            StationsTabPage.Controls.Add(groupBox9);
            StationsTabPage.Controls.Add(groupBox10);
            StationsTabPage.Controls.Add(groupBox11);
            StationsTabPage.Controls.Add(groupBox12);
            StationsTabPage.Controls.Add(StationsDataGridView);
            StationsTabPage.Location = new Point(4, 29);
            StationsTabPage.Name = "StationsTabPage";
            StationsTabPage.Padding = new Padding(3);
            StationsTabPage.Size = new Size(950, 496);
            StationsTabPage.TabIndex = 0;
            StationsTabPage.Text = "Stations";
            StationsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(EditStationButton);
            groupBox9.Controls.Add(label9);
            groupBox9.Location = new Point(545, 248);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(402, 100);
            groupBox9.TabIndex = 7;
            groupBox9.TabStop = false;
            groupBox9.Text = "Edit station";
            // 
            // EditStationButton
            // 
            EditStationButton.BackColor = Color.PowderBlue;
            EditStationButton.FlatAppearance.BorderSize = 0;
            EditStationButton.FlatStyle = FlatStyle.Flat;
            EditStationButton.Location = new Point(302, 44);
            EditStationButton.Name = "EditStationButton";
            EditStationButton.Size = new Size(94, 29);
            EditStationButton.TabIndex = 4;
            EditStationButton.Text = "Edit";
            EditStationButton.UseVisualStyleBackColor = false;
            EditStationButton.Click += EditStationButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 48);
            label9.Name = "label9";
            label9.Size = new Size(279, 20);
            label9.TabIndex = 0;
            label9.Text = "Edit data in the data grid and press edit: ";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(FilterStationsCityInput);
            groupBox10.Controls.Add(FilterStationsFrequencyInput);
            groupBox10.Controls.Add(label16);
            groupBox10.Controls.Add(label15);
            groupBox10.Controls.Add(FilterStationsButton);
            groupBox10.Controls.Add(FilterStationsNameInput);
            groupBox10.Controls.Add(label10);
            groupBox10.Controls.Add(FilterStationsIdInput);
            groupBox10.Controls.Add(label11);
            groupBox10.Location = new Point(542, 142);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(402, 100);
            groupBox10.TabIndex = 6;
            groupBox10.TabStop = false;
            groupBox10.Text = "Filter stations";
            // 
            // FilterStationsCityInput
            // 
            FilterStationsCityInput.Location = new Point(70, 25);
            FilterStationsCityInput.Name = "FilterStationsCityInput";
            FilterStationsCityInput.Size = new Size(83, 27);
            FilterStationsCityInput.TabIndex = 11;
            // 
            // FilterStationsFrequencyInput
            // 
            FilterStationsFrequencyInput.Location = new Point(264, 24);
            FilterStationsFrequencyInput.Name = "FilterStationsFrequencyInput";
            FilterStationsFrequencyInput.Size = new Size(64, 27);
            FilterStationsFrequencyInput.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(179, 28);
            label16.Name = "label16";
            label16.Size = new Size(79, 20);
            label16.TabIndex = 9;
            label16.Text = "Frequency:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(14, 27);
            label15.Name = "label15";
            label15.Size = new Size(54, 20);
            label15.TabIndex = 7;
            label15.Text = "City Id:";
            // 
            // FilterStationsButton
            // 
            FilterStationsButton.BackColor = Color.PowderBlue;
            FilterStationsButton.FlatAppearance.BorderSize = 0;
            FilterStationsButton.FlatStyle = FlatStyle.Flat;
            FilterStationsButton.Location = new Point(302, 65);
            FilterStationsButton.Name = "FilterStationsButton";
            FilterStationsButton.Size = new Size(94, 29);
            FilterStationsButton.TabIndex = 3;
            FilterStationsButton.Text = "Filter";
            FilterStationsButton.UseVisualStyleBackColor = false;
            FilterStationsButton.Click += FilterStationsButton_Click;
            // 
            // FilterStationsNameInput
            // 
            FilterStationsNameInput.Location = new Point(70, 59);
            FilterStationsNameInput.Name = "FilterStationsNameInput";
            FilterStationsNameInput.Size = new Size(83, 27);
            FilterStationsNameInput.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 62);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 2;
            label10.Text = "Name:";
            // 
            // FilterStationsIdInput
            // 
            FilterStationsIdInput.Location = new Point(210, 59);
            FilterStationsIdInput.Name = "FilterStationsIdInput";
            FilterStationsIdInput.Size = new Size(64, 27);
            FilterStationsIdInput.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(179, 62);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 0;
            label11.Text = "Id:";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(AddNewStationFrequencyInput);
            groupBox11.Controls.Add(label14);
            groupBox11.Controls.Add(AddNewStationComboBox);
            groupBox11.Controls.Add(label13);
            groupBox11.Controls.Add(AddNewStationButton);
            groupBox11.Controls.Add(AddNewStationNameInput);
            groupBox11.Controls.Add(label12);
            groupBox11.Location = new Point(542, 36);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(402, 100);
            groupBox11.TabIndex = 5;
            groupBox11.TabStop = false;
            groupBox11.Text = "Add new station";
            // 
            // AddNewStationFrequencyInput
            // 
            AddNewStationFrequencyInput.Location = new Point(302, 26);
            AddNewStationFrequencyInput.Name = "AddNewStationFrequencyInput";
            AddNewStationFrequencyInput.Size = new Size(94, 27);
            AddNewStationFrequencyInput.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(217, 29);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 5;
            label14.Text = "Frequency:";
            // 
            // AddNewStationComboBox
            // 
            AddNewStationComboBox.FormattingEnabled = true;
            AddNewStationComboBox.ImeMode = ImeMode.Off;
            AddNewStationComboBox.Location = new Point(70, 65);
            AddNewStationComboBox.Name = "AddNewStationComboBox";
            AddNewStationComboBox.Size = new Size(128, 28);
            AddNewStationComboBox.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(24, 68);
            label13.Name = "label13";
            label13.Size = new Size(37, 20);
            label13.TabIndex = 3;
            label13.Text = "City:";
            // 
            // AddNewStationButton
            // 
            AddNewStationButton.BackColor = Color.PowderBlue;
            AddNewStationButton.FlatAppearance.BorderSize = 0;
            AddNewStationButton.FlatStyle = FlatStyle.Flat;
            AddNewStationButton.Location = new Point(302, 65);
            AddNewStationButton.Name = "AddNewStationButton";
            AddNewStationButton.Size = new Size(94, 29);
            AddNewStationButton.TabIndex = 2;
            AddNewStationButton.Text = "Add";
            AddNewStationButton.UseVisualStyleBackColor = false;
            AddNewStationButton.Click += AddNewStationButton_Click;
            // 
            // AddNewStationNameInput
            // 
            AddNewStationNameInput.Location = new Point(70, 26);
            AddNewStationNameInput.Name = "AddNewStationNameInput";
            AddNewStationNameInput.Size = new Size(128, 27);
            AddNewStationNameInput.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 29);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 0;
            label12.Text = "Name:";
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(textBox9);
            groupBox12.Controls.Add(DeleteStationButton);
            groupBox12.Location = new Point(545, 354);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(402, 100);
            groupBox12.TabIndex = 8;
            groupBox12.TabStop = false;
            groupBox12.Text = "Delete station";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(11, 26);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(263, 52);
            textBox9.TabIndex = 5;
            textBox9.Text = "Select the station you want to delete and press delete:";
            // 
            // DeleteStationButton
            // 
            DeleteStationButton.BackColor = Color.PowderBlue;
            DeleteStationButton.FlatAppearance.BorderSize = 0;
            DeleteStationButton.FlatStyle = FlatStyle.Flat;
            DeleteStationButton.Location = new Point(302, 44);
            DeleteStationButton.Name = "DeleteStationButton";
            DeleteStationButton.Size = new Size(94, 29);
            DeleteStationButton.TabIndex = 4;
            DeleteStationButton.Text = "Delete";
            DeleteStationButton.UseVisualStyleBackColor = false;
            DeleteStationButton.Click += DeleteStationButton_Click;
            // 
            // StationsDataGridView
            // 
            StationsDataGridView.AllowUserToOrderColumns = true;
            StationsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            StationsDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            StationsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StationsDataGridView.Location = new Point(6, 6);
            StationsDataGridView.Name = "StationsDataGridView";
            StationsDataGridView.RowHeadersWidth = 51;
            StationsDataGridView.Size = new Size(530, 484);
            StationsDataGridView.TabIndex = 0;
            StationsDataGridView.DataBindingComplete += StationsDataGridView_DataBindingComplete;
            // 
            // ProgrammesTabPage
            // 
            ProgrammesTabPage.Controls.Add(groupBox8);
            ProgrammesTabPage.Controls.Add(groupBox6);
            ProgrammesTabPage.Controls.Add(groupBox5);
            ProgrammesTabPage.Controls.Add(groupBox7);
            ProgrammesTabPage.Controls.Add(ProgrammesDataGridView);
            ProgrammesTabPage.Location = new Point(4, 29);
            ProgrammesTabPage.Name = "ProgrammesTabPage";
            ProgrammesTabPage.Padding = new Padding(3);
            ProgrammesTabPage.Size = new Size(950, 496);
            ProgrammesTabPage.TabIndex = 1;
            ProgrammesTabPage.Text = "Programmes";
            ProgrammesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(DeleteProgrammeButton);
            groupBox8.Controls.Add(label21);
            groupBox8.Location = new Point(542, 418);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(402, 59);
            groupBox8.TabIndex = 8;
            groupBox8.TabStop = false;
            groupBox8.Text = "Delete Programme";
            // 
            // DeleteProgrammeButton
            // 
            DeleteProgrammeButton.BackColor = Color.PowderBlue;
            DeleteProgrammeButton.FlatAppearance.BorderSize = 0;
            DeleteProgrammeButton.FlatStyle = FlatStyle.Flat;
            DeleteProgrammeButton.Location = new Point(302, 19);
            DeleteProgrammeButton.Name = "DeleteProgrammeButton";
            DeleteProgrammeButton.Size = new Size(94, 29);
            DeleteProgrammeButton.TabIndex = 4;
            DeleteProgrammeButton.Text = "Delete";
            DeleteProgrammeButton.UseVisualStyleBackColor = false;
            DeleteProgrammeButton.Click += DeleteProgrammeButton_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 23);
            label21.Name = "label21";
            label21.Size = new Size(248, 20);
            label21.TabIndex = 0;
            label21.Text = "Select programme and press delete:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(EditProgrammeButton);
            groupBox6.Controls.Add(label20);
            groupBox6.Location = new Point(542, 353);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(402, 59);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Edit programme";
            // 
            // EditProgrammeButton
            // 
            EditProgrammeButton.BackColor = Color.PowderBlue;
            EditProgrammeButton.FlatAppearance.BorderSize = 0;
            EditProgrammeButton.FlatStyle = FlatStyle.Flat;
            EditProgrammeButton.Location = new Point(302, 19);
            EditProgrammeButton.Name = "EditProgrammeButton";
            EditProgrammeButton.Size = new Size(94, 29);
            EditProgrammeButton.TabIndex = 4;
            EditProgrammeButton.Text = "Edit";
            EditProgrammeButton.UseVisualStyleBackColor = false;
            EditProgrammeButton.Click += EditProgrammeButton_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 23);
            label20.Name = "label20";
            label20.Size = new Size(279, 20);
            label20.TabIndex = 0;
            label20.Text = "Edit data in the data grid and press edit: ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(FilterProgrammesButton);
            groupBox5.Controls.Add(FilterProgrammesName);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(FilterProgrammesStationId);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(FilterProgrammesDatePicker);
            groupBox5.Location = new Point(542, 200);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(402, 147);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Filter programmes";
            // 
            // FilterProgrammesButton
            // 
            FilterProgrammesButton.BackColor = Color.PowderBlue;
            FilterProgrammesButton.FlatAppearance.BorderSize = 0;
            FilterProgrammesButton.FlatStyle = FlatStyle.Flat;
            FilterProgrammesButton.Location = new Point(302, 112);
            FilterProgrammesButton.Name = "FilterProgrammesButton";
            FilterProgrammesButton.Size = new Size(94, 29);
            FilterProgrammesButton.TabIndex = 10;
            FilterProgrammesButton.Text = "Filter";
            FilterProgrammesButton.UseVisualStyleBackColor = false;
            FilterProgrammesButton.Click += FilterProgrammesButton_Click;
            // 
            // FilterProgrammesName
            // 
            FilterProgrammesName.Location = new Point(85, 110);
            FilterProgrammesName.Name = "FilterProgrammesName";
            FilterProgrammesName.Size = new Size(128, 27);
            FilterProgrammesName.TabIndex = 13;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(27, 113);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 10;
            label19.Text = "Name:";
            // 
            // FilterProgrammesStationId
            // 
            FilterProgrammesStationId.Location = new Point(109, 67);
            FilterProgrammesStationId.Name = "FilterProgrammesStationId";
            FilterProgrammesStationId.Size = new Size(128, 27);
            FilterProgrammesStationId.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(27, 70);
            label18.Name = "label18";
            label18.Size = new Size(76, 20);
            label18.TabIndex = 11;
            label18.Text = "Station Id:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(27, 31);
            label17.Name = "label17";
            label17.Size = new Size(44, 20);
            label17.TabIndex = 10;
            label17.Text = "Date:";
            // 
            // FilterProgrammesDatePicker
            // 
            FilterProgrammesDatePicker.CustomFormat = "dd-MM-yyyy";
            FilterProgrammesDatePicker.Location = new Point(77, 26);
            FilterProgrammesDatePicker.Name = "FilterProgrammesDatePicker";
            FilterProgrammesDatePicker.ShowCheckBox = true;
            FilterProgrammesDatePicker.Size = new Size(200, 27);
            FilterProgrammesDatePicker.TabIndex = 0;
            FilterProgrammesDatePicker.Value = new DateTime(2025, 3, 22, 0, 0, 0, 0);
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(AddProgrammeStationId);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(AddProgrammeName);
            groupBox7.Controls.Add(AddProgrammeEndTime);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(AddProgrammeStartTime);
            groupBox7.Controls.Add(AddProgrammeButton);
            groupBox7.Location = new Point(542, 6);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(402, 188);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Add new programme";
            // 
            // AddProgrammeStationId
            // 
            AddProgrammeStationId.Location = new Point(27, 150);
            AddProgrammeStationId.Name = "AddProgrammeStationId";
            AddProgrammeStationId.Size = new Size(128, 27);
            AddProgrammeStationId.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 127);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 8;
            label7.Text = "Station Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(214, 21);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 7;
            label6.Text = "End time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 21);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 6;
            label5.Text = "Start time:";
            // 
            // AddProgrammeName
            // 
            AddProgrammeName.Location = new Point(27, 97);
            AddProgrammeName.Name = "AddProgrammeName";
            AddProgrammeName.Size = new Size(128, 27);
            AddProgrammeName.TabIndex = 1;
            // 
            // AddProgrammeEndTime
            // 
            AddProgrammeEndTime.CustomFormat = "dd-MM-yyyy | HH:mm";
            AddProgrammeEndTime.Format = DateTimePickerFormat.Custom;
            AddProgrammeEndTime.Location = new Point(214, 44);
            AddProgrammeEndTime.Name = "AddProgrammeEndTime";
            AddProgrammeEndTime.ShowUpDown = true;
            AddProgrammeEndTime.Size = new Size(160, 27);
            AddProgrammeEndTime.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 74);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 0;
            label8.Text = "Name:";
            // 
            // AddProgrammeStartTime
            // 
            AddProgrammeStartTime.CustomFormat = "dd-MM-yyyy | HH:mm";
            AddProgrammeStartTime.Format = DateTimePickerFormat.Custom;
            AddProgrammeStartTime.Location = new Point(27, 44);
            AddProgrammeStartTime.Name = "AddProgrammeStartTime";
            AddProgrammeStartTime.ShowUpDown = true;
            AddProgrammeStartTime.Size = new Size(160, 27);
            AddProgrammeStartTime.TabIndex = 3;
            // 
            // AddProgrammeButton
            // 
            AddProgrammeButton.BackColor = Color.PowderBlue;
            AddProgrammeButton.FlatAppearance.BorderSize = 0;
            AddProgrammeButton.FlatStyle = FlatStyle.Flat;
            AddProgrammeButton.Location = new Point(302, 153);
            AddProgrammeButton.Name = "AddProgrammeButton";
            AddProgrammeButton.Size = new Size(94, 29);
            AddProgrammeButton.TabIndex = 2;
            AddProgrammeButton.Text = "Add";
            AddProgrammeButton.UseVisualStyleBackColor = false;
            AddProgrammeButton.Click += AddProgrammeButton_Click;
            // 
            // ProgrammesDataGridView
            // 
            ProgrammesDataGridView.AllowUserToOrderColumns = true;
            ProgrammesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ProgrammesDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            ProgrammesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProgrammesDataGridView.Location = new Point(6, 6);
            ProgrammesDataGridView.Name = "ProgrammesDataGridView";
            ProgrammesDataGridView.RowHeadersWidth = 51;
            ProgrammesDataGridView.Size = new Size(530, 484);
            ProgrammesDataGridView.TabIndex = 2;
            // 
            // CitiesTabPage
            // 
            CitiesTabPage.Controls.Add(groupBox3);
            CitiesTabPage.Controls.Add(groupBox2);
            CitiesTabPage.Controls.Add(groupBox1);
            CitiesTabPage.Controls.Add(CitiesDataGridView);
            CitiesTabPage.Controls.Add(groupBox4);
            CitiesTabPage.Location = new Point(4, 29);
            CitiesTabPage.Name = "CitiesTabPage";
            CitiesTabPage.Padding = new Padding(3);
            CitiesTabPage.Size = new Size(950, 496);
            CitiesTabPage.TabIndex = 2;
            CitiesTabPage.Text = "Cities";
            CitiesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(EditCityButton);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(542, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(402, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit city";
            // 
            // EditCityButton
            // 
            EditCityButton.BackColor = Color.PowderBlue;
            EditCityButton.FlatAppearance.BorderSize = 0;
            EditCityButton.FlatStyle = FlatStyle.Flat;
            EditCityButton.Location = new Point(302, 44);
            EditCityButton.Name = "EditCityButton";
            EditCityButton.Size = new Size(94, 29);
            EditCityButton.TabIndex = 4;
            EditCityButton.Text = "Edit";
            EditCityButton.UseVisualStyleBackColor = false;
            EditCityButton.Click += EditCityButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 48);
            label4.Name = "label4";
            label4.Size = new Size(279, 20);
            label4.TabIndex = 0;
            label4.Text = "Edit data in the data grid and press edit: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FilterCitiesButton);
            groupBox2.Controls.Add(FilterCityNameInput);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(FilterCityIdInput);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(542, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter cities";
            // 
            // FilterCitiesButton
            // 
            FilterCitiesButton.BackColor = Color.PowderBlue;
            FilterCitiesButton.FlatAppearance.BorderSize = 0;
            FilterCitiesButton.FlatStyle = FlatStyle.Flat;
            FilterCitiesButton.Location = new Point(302, 34);
            FilterCitiesButton.Name = "FilterCitiesButton";
            FilterCitiesButton.Size = new Size(94, 29);
            FilterCitiesButton.TabIndex = 3;
            FilterCitiesButton.Text = "Filter";
            FilterCitiesButton.UseVisualStyleBackColor = false;
            FilterCitiesButton.Click += FilterCitiesButton_Click;
            // 
            // FilterCityNameInput
            // 
            FilterCityNameInput.Location = new Point(191, 36);
            FilterCityNameInput.Name = "FilterCityNameInput";
            FilterCityNameInput.Size = new Size(83, 27);
            FilterCityNameInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 39);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // FilterCityIdInput
            // 
            FilterCityIdInput.Location = new Point(42, 36);
            FilterCityIdInput.Name = "FilterCityIdInput";
            FilterCityIdInput.Size = new Size(64, 27);
            FilterCityIdInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 39);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 0;
            label2.Text = "Id:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddCityButton);
            groupBox1.Controls.Add(AddCityInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(542, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new city";
            // 
            // AddCityButton
            // 
            AddCityButton.BackColor = Color.PowderBlue;
            AddCityButton.FlatAppearance.BorderSize = 0;
            AddCityButton.FlatStyle = FlatStyle.Flat;
            AddCityButton.Location = new Point(302, 32);
            AddCityButton.Name = "AddCityButton";
            AddCityButton.Size = new Size(94, 29);
            AddCityButton.TabIndex = 2;
            AddCityButton.Text = "Add";
            AddCityButton.UseVisualStyleBackColor = false;
            AddCityButton.Click += AddCityButton_Click;
            // 
            // AddCityInput
            // 
            AddCityInput.Location = new Point(90, 33);
            AddCityInput.Name = "AddCityInput";
            AddCityInput.Size = new Size(128, 27);
            AddCityInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "City name:";
            // 
            // CitiesDataGridView
            // 
            CitiesDataGridView.AllowUserToOrderColumns = true;
            CitiesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            CitiesDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            CitiesDataGridView.ColumnHeadersHeight = 29;
            CitiesDataGridView.Location = new Point(3, 6);
            CitiesDataGridView.Name = "CitiesDataGridView";
            CitiesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            CitiesDataGridView.Size = new Size(530, 484);
            CitiesDataGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(DeleteCityButton);
            groupBox4.Location = new Point(542, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(402, 100);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Delete city";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(11, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 52);
            textBox1.TabIndex = 5;
            textBox1.Text = "Select the city you want to delete and press delete:";
            // 
            // DeleteCityButton
            // 
            DeleteCityButton.BackColor = Color.PowderBlue;
            DeleteCityButton.FlatAppearance.BorderSize = 0;
            DeleteCityButton.FlatStyle = FlatStyle.Flat;
            DeleteCityButton.Location = new Point(302, 44);
            DeleteCityButton.Name = "DeleteCityButton";
            DeleteCityButton.Size = new Size(94, 29);
            DeleteCityButton.TabIndex = 4;
            DeleteCityButton.Text = "Delete";
            DeleteCityButton.UseVisualStyleBackColor = false;
            DeleteCityButton.Click += DeleteCityButton_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(RefreshUserLogs);
            tabPage1.Controls.Add(UserLogsDataGridView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(950, 496);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "User action logs";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // RefreshUserLogs
            // 
            RefreshUserLogs.Location = new Point(850, 360);
            RefreshUserLogs.Name = "RefreshUserLogs";
            RefreshUserLogs.Size = new Size(94, 29);
            RefreshUserLogs.TabIndex = 1;
            RefreshUserLogs.Text = "Refresh";
            RefreshUserLogs.UseVisualStyleBackColor = true;
            RefreshUserLogs.Click += RefreshUserLogs_Click;
            // 
            // UserLogsDataGridView
            // 
            UserLogsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserLogsDataGridView.Location = new Point(6, 6);
            UserLogsDataGridView.Name = "UserLogsDataGridView";
            UserLogsDataGridView.RowHeadersWidth = 51;
            UserLogsDataGridView.Size = new Size(938, 348);
            UserLogsDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label22);
            tabPage2.Controls.Add(ReportsSaveButton);
            tabPage2.Controls.Add(ReportsCalendar);
            tabPage2.Controls.Add(ReportsDataGridView);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(950, 496);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Reports";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(286, 194);
            label22.Name = "label22";
            label22.Size = new Size(154, 20);
            label22.TabIndex = 3;
            label22.Text = "To export data below:";
            // 
            // ReportsSaveButton
            // 
            ReportsSaveButton.Location = new Point(446, 190);
            ReportsSaveButton.Name = "ReportsSaveButton";
            ReportsSaveButton.Size = new Size(94, 29);
            ReportsSaveButton.TabIndex = 2;
            ReportsSaveButton.Text = "Save to file";
            ReportsSaveButton.UseVisualStyleBackColor = true;
            ReportsSaveButton.Click += ReportsSaveButton_Click;
            // 
            // ReportsCalendar
            // 
            ReportsCalendar.Location = new Point(12, 12);
            ReportsCalendar.Name = "ReportsCalendar";
            ReportsCalendar.TabIndex = 1;
            ReportsCalendar.DateSelected += ReportsCalendar_DateSelected;
            // 
            // ReportsDataGridView
            // 
            ReportsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportsDataGridView.Location = new Point(6, 228);
            ReportsDataGridView.Name = "ReportsDataGridView";
            ReportsDataGridView.RowHeadersWidth = 51;
            ReportsDataGridView.Size = new Size(938, 262);
            ReportsDataGridView.TabIndex = 0;
            // 
            // RADIO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(AppTabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RADIO";
            Text = "National Radio Management System";
            Load += RADIO_Load;
            AppTabControl.ResumeLayout(false);
            StationsTabPage.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StationsDataGridView).EndInit();
            ProgrammesTabPage.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProgrammesDataGridView).EndInit();
            CitiesTabPage.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CitiesDataGridView).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserLogsDataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReportsDataGridView).EndInit();
            ResumeLayout(false);
        }

        private void CitiesDataGridView_DataBindingComplete1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl AppTabControl;
        private TabPage StationsTabPage;
        private DataGridView StationsDataGridView;
        private TabPage ProgrammesTabPage;
        private TabPage CitiesTabPage;
        private DataGridView CitiesDataGridView;
        private DataGridView ProgrammesDataGridView;
        private GroupBox groupBox1;
        private Button AddCityButton;
        private TextBox AddCityInput;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox FilterCityNameInput;
        private Label label3;
        private TextBox FilterCityIdInput;
        private Label label2;
        private Button FilterCitiesButton;
        private GroupBox groupBox4;
        private Button DeleteCityButton;
        private GroupBox groupBox3;
        private Button EditCityButton;
        private Label label4;
        private TextBox textBox1;
        private GroupBox groupBox9;
        private Button EditStationButton;
        private Label label9;
        private GroupBox groupBox10;
        private Button FilterStationsButton;
        private TextBox FilterStationsNameInput;
        private Label label10;
        private TextBox FilterStationsIdInput;
        private Label label11;
        private GroupBox groupBox11;
        private Label label13;
        private Button AddNewStationButton;
        private TextBox AddNewStationNameInput;
        private Label label12;
        private GroupBox groupBox12;
        private TextBox textBox9;
        private Button DeleteStationButton;
        private GroupBox groupBox7;
        private Button AddProgrammeButton;
        private TextBox AddProgrammeName;
        private Label label8;
        private ComboBox AddNewStationComboBox;
        private TextBox AddNewStationFrequencyInput;
        private Label label14;
        private TextBox FilterStationsFrequencyInput;
        private Label label16;
        private Label label15;
        private TextBox FilterStationsCityInput;
        private DateTimePicker AddProgrammeStartTime;
        private DateTimePicker AddProgrammeEndTime;
        private Label label6;
        private Label label5;
        private TextBox AddProgrammeStationId;
        private Label label7;
        private GroupBox groupBox5;
        private Label label17;
        private DateTimePicker FilterProgrammesDatePicker;
        private TextBox FilterProgrammesStationId;
        private Label label18;
        private Button FilterProgrammesButton;
        private TextBox FilterProgrammesName;
        private Label label19;
        private GroupBox groupBox6;
        private Button EditProgrammeButton;
        private Label label20;
        private GroupBox groupBox8;
        private Button DeleteProgrammeButton;
        private Label label21;
        private TabPage tabPage1;
        private DataGridView UserLogsDataGridView;
        private Button RefreshUserLogs;
        private TabPage tabPage2;
        private MonthCalendar ReportsCalendar;
        private DataGridView ReportsDataGridView;
        private Label label22;
        private Button ReportsSaveButton;
    }
}