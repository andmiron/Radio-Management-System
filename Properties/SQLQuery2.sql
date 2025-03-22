CREATE TABLE Cities (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(255) NOT NULL UNIQUE
)

GO 

CREATE TABLE Stations (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	city_id INT NOT NULL,
	frequency DECIMAL(5,2) NOT NULL,
	name VARCHAR(255) NOT NULL,
	UNIQUE (city_id, frequency)
)

GO 

CREATE TABLE Programmes (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	station_id INT NOT NULL,
	start_time DATETIME NOT NULL,
	end_time DATETIME NOT NULL,
	name VARCHAR(255) NOT NULL,
	UNIQUE(station_id, start_time, end_time),
	UNIQUE(station_id, name)
)

GO

ALTER TABLE Programmes
ADD FOREIGN KEY (station_id) 
REFERENCES Stations(id)
ON DELETE CASCADE
ON UPDATE CASCADE

GO

ALTER TABLE Stations
ADD FOREIGN KEY (city_id)
REFERENCES Cities(id)
ON DELETE CASCADE
ON UPDATE CASCADE

GO

CREATE TABLE Users (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(50) NOT NULL UNIQUE,
	password VARCHAR(50) NOT NULL,
	role VARCHAR(20) NOT NULL CHECK (role IN ('user','admin')) DEFAULT 'user'
)

GO 

INSERT INTO Users (username, password, role)
VALUES ('admin', 'admin', 'admin')

GO

INSERT INTO Users (username, password)
VALUES ('user', 'user')

GO 

CREATE FUNCTION dbo.CheckProgrammeOverlap(
    @id INT,
    @station_id INT,
    @start_time DATETIME,
    @end_time DATETIME
)
RETURNS BIT
AS
BEGIN
    DECLARE @hasOverlap BIT = 0;
    
    IF EXISTS (
        SELECT 1
        FROM Programmes
        WHERE station_id = @station_id
          AND start_time < @end_time 
          AND end_time > @start_time
          AND id != @id -- Skip the row being checked (for updates)
    )
        SET @hasOverlap = 1;
        
    RETURN @hasOverlap;
END;

GO 

ALTER TABLE Programmes
ADD CONSTRAINT CK_NoOverlap CHECK (dbo.CheckProgrammeOverlap(id, station_id, start_time, end_time) = 0);

GO 

CREATE TABLE UserActivityLog (
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(50),
    command VARCHAR(255),
    table_name VARCHAR(50),
    executed_at DATETIME DEFAULT GETDATE()
);

GO 

CREATE TRIGGER AfterActionLog
ON Programmes
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @command VARCHAR(50)

    IF EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted)
        SET @command = 'UPDATE'
    ELSE IF EXISTS (SELECT * FROM inserted)
        SET @command = 'INSERT'
    ELSE
        SET @command = 'DELETE'

    INSERT INTO UserActivityLog (username, command, table_name)
    VALUES (SUSER_NAME(), @command, 'Programmes')
END;

GO 

-- Insert Cities (30 records)
INSERT INTO Cities (name) VALUES 
('New York'), ('Los Angeles'), ('Chicago'), ('Houston'), ('Phoenix'),
('Philadelphia'), ('San Antonio'), ('San Diego'), ('Dallas'), ('San Jose'),
('Austin'), ('Jacksonville'), ('Fort Worth'), ('Columbus'), ('Charlotte'),
('San Francisco'), ('Indianapolis'), ('Seattle'), ('Denver'), ('Washington'),
('Boston'), ('El Paso'), ('Nashville'), ('Detroit'), ('Portland'),
('Las Vegas'), ('Memphis'), ('Louisville'), ('Baltimore'), ('Milwaukee');

GO

-- Insert Stations (10 records, linking cities)
INSERT INTO Stations (city_id, frequency, name) VALUES 
(1, 101.1, 'NYC Rock FM'),
(2, 102.5, 'LA Hits Radio'),
(3, 99.9, 'Chicago Vibes'),
(4, 104.7, 'Houston Country'),
(5, 88.3, 'Phoenix Jazz'),
(6, 96.2, 'Philly Pop'),
(7, 103.3, 'San Antonio Mix'),
(8, 98.7, 'San Diego Talk'),
(9, 105.5, 'Dallas Beats'),
(10, 107.9, 'San Jose Classics');

GO

-- Insert Programmes (30 records across the stations)
INSERT INTO Programmes (station_id, start_time, end_time, name) VALUES 
(1, '2025-03-21 06:00', '2025-03-21 09:00', 'Morning Drive'),
(1, '2025-03-21 09:00', '2025-03-21 12:00', 'Classic Rock Hour'),
(1, '2025-03-21 12:00', '2025-03-21 15:00', 'Lunchtime Tunes'),
(1, '2025-03-21 15:00', '2025-03-21 18:00', 'Evening Rock'),
(2, '2025-03-21 06:00', '2025-03-21 10:00', 'LA Morning Hits'),
(2, '2025-03-21 10:00', '2025-03-21 14:00', 'Top 40 Countdown'),
(2, '2025-03-21 14:00', '2025-03-21 18:00', 'Afternoon Vibes'),
(3, '2025-03-21 06:00', '2025-03-21 09:00', 'Windy City Wakeup'),
(3, '2025-03-21 09:00', '2025-03-21 12:00', 'Chicago Blues Hour'),
(3, '2025-03-21 12:00', '2025-03-21 15:00', 'Afternoon Chill'),
(4, '2025-03-21 06:00', '2025-03-21 09:00', 'Houston Sunrise Show'),
(4, '2025-03-21 09:00', '2025-03-21 12:00', 'Country Classics'),
(4, '2025-03-21 12:00', '2025-03-21 15:00', 'BBQ Tunes'),
(5, '2025-03-21 06:00', '2025-03-21 09:00', 'Smooth Jazz Morning'),
(5, '2025-03-21 09:00', '2025-03-21 12:00', 'Jazz Legends'),
(5, '2025-03-21 12:00', '2025-03-21 15:00', 'Afternoon Sax'),
(6, '2025-03-21 06:00', '2025-03-21 09:00', 'Philly Morning Show'),
(6, '2025-03-21 09:00', '2025-03-21 12:00', 'Pop Throwbacks'),
(6, '2025-03-21 12:00', '2025-03-21 15:00', 'Midday Hits'),
(7, '2025-03-21 06:00', '2025-03-21 09:00', 'San Antonio Sunrise'),
(7, '2025-03-21 09:00', '2025-03-21 12:00', 'Latin Hour'),
(7, '2025-03-21 12:00', '2025-03-21 15:00', 'Fiesta Beats'),
(8, '2025-03-21 06:00', '2025-03-21 09:00', 'San Diego Morning Talk'),
(8, '2025-03-21 09:00', '2025-03-21 12:00', 'Political Roundtable'),
(8, '2025-03-21 12:00', '2025-03-21 15:00', 'Comedy Hour'),
(9, '2025-03-21 06:00', '2025-03-21 09:00', 'Dallas Morning Beats'),
(9, '2025-03-21 09:00', '2025-03-21 12:00', 'Hip-Hop Hour'),
(9, '2025-03-21 12:00', '2025-03-21 15:00', 'Afternoon Rap'),
(10, '2025-03-21 06:00', '2025-03-21 09:00', 'San Jose Classics Morning'),
(10, '2025-03-21 09:00', '2025-03-21 12:00', 'Golden Oldies'),
(10, '2025-03-21 12:00', '2025-03-21 15:00', '80s Hour');
