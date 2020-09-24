PRINT N'Create database CarRental...'
GO
CREATE DATABASE CarRental
GO

USE CarRental
GO

PRINT N'Create table Categories...'
GO
BEGIN TRANSACTION
CREATE TABLE Categories
(
Id int NOT NULL IDENTITY UNIQUE,
CategoryName nvarchar(100) NOT NULL,
DailyRate decimal(8, 1),
WeeklyRate decimal(8, 1),
MonthlyRate decimal(8, 1),
WeekendRate decimal(8, 1),
CONSTRAINT PK_Categories PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Create table Cars...'
GO
BEGIN TRANSACTION
CREATE TABLE Cars
(
Id int NOT NULL IDENTITY UNIQUE,
PlateNumber nvarchar(30) NOT NULL,
Manufacturer nvarchar(50) NOT NULL,
Model varchar(100) NOT NULL,
CarYear date,
CategoryId int,
Doors int,
Picture varbinary(8000),
Condition varchar(20),
Available varbinary NOT NULL
CONSTRAINT PK_Cars PRIMARY KEY (Id),
CONSTRAINT FK_Cars_Categories FOREIGN KEY (CategoryId)
REFERENCES Categories (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Create table Employees...'
GO
BEGIN TRANSACTION
CREATE TABLE Employees
(
Id int NOT NULL IDENTITY UNIQUE,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
Title nvarchar(20),
Notes nvarchar(max)
CONSTRAINT PK_Employees PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Create table Customers...'
GO
BEGIN TRANSACTION
CREATE TABLE Customers
(
Id int NOT NULL IDENTITY UNIQUE,
DriverLicenceNumber int NOT NULL,
FullName nvarchar(150) NOT NULL,
Address nvarchar(200) NOT NULL,
City nvarchar(100) NOT NULL,
ZIPCode int NOT NULL,
Notes nvarchar(max)
CONSTRAINT PK_Customers PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Create table RentalOrders...'
GO
BEGIN TRANSACTION
CREATE TABLE RentalOrders
(
Id int NOT NULL IDENTITY UNIQUE,
EmployeeId int NOT NULL,
CustomerId int NOT NULL,
CarId int NOT NULL,
TankLevel int,
KilometrageStart int,
KilometrageEnd int,
TotalKilometrage int,
StartDate date,
EndDate date,
TotalDays int,
RateApplied decimal(5, 1) DEFAULT 0,
TaxRate decimal (5, 1) DEFAULT 0,
OrderStatus varchar(50) NOT NULL,
Notes nvarchar(max)
CONSTRAINT PK_RentalOrders PRIMARY KEY (Id),
CONSTRAINT FK_RentalOrders_Employees FOREIGN KEY (EmployeeId)
REFERENCES Employees (Id),
CONSTRAINT FK_RentalOrders_Customers FOREIGN KEY (CustomerId)
REFERENCES Customers (Id),
CONSTRAINT FK_RentalOrders_Cars FOREIGN KEY (CarId)
REFERENCES Cars (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Insert values in Categories...'
GO
BEGIN TRANSACTION
INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES ('vanagon', 5.1, 6.2, 7.3, 7.2),
		('car', 4.5, 5.5, 6.3, 6.2),
		('suv', 3.1, 4.2, 5.3, 6.2)
COMMIT TRANSACTION
GO

PRINT N'Insert values in Cars...'
GO
BEGIN TRANSACTION
INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, Doors, Picture, Condition, Available)
VALUES ('E 6666 EK', 'VolksWagen', 'Passat', '2019-10-16', 4, NULL, 'New', 1),
		('E 6666 EK', 'VolksWagen', 'Passat', '2019-10-16', 4, NULL, 'New', 1),
		('E 6666 EK', 'VolksWagen', 'Passat', '2019-10-16', 4, NULL, 'New', 1)
COMMIT TRANSACTION
GO

PRINT N'Insert values in Employees...'
GO
BEGIN TRANSACTION
INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES ('Galfonso', 'Nadal', 'clerk', 'invalid'),
		('Galfonso', 'Nadal', 'clerk', 'invalid'),
		('Galfonso', 'Nadal', 'clerk', 'invalid')
COMMIT TRANSACTION 
GO

PRINT N'Insert values in Customers...'
GO
BEGIN TRANSACTION
INSERT INTO Customers (DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes)
VALUES (321, 'Rumen Radev', 'Triada 12', 'Sofia', 1003, 'yellow card'),
		(321, 'Rumen Radev', 'Triada 12', 'Sofia', 1003, 'yellow card'),
		(321, 'Rumen Radev', 'Triada 12', 'Sofia', 1003, 'yellow card')
COMMIT TRANSACTION
GO

PRINT N'Insert values in RentalOrders...'
GO
BEGIN TRANSACTION
INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd,
	TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
VALUES (1, 2, 3, 80, 1000, 2000, 1000, '2020-03-01', '2020-03-31', 30, 8.2, 7.0, 'AVAILABLE', 'New car'),
		(1, 2, 3, 80, 1000, 2000, 1000, '2020-03-01', '2020-03-31', 30, 8.2, 7.0, 'AVAILABLE', 'New car'),
		(1, 2, 3, 80, 1000, 2000, 1000, '2020-03-01', '2020-03-31', 30, 8.2, 7.0, 'AVAILABLE', 'New car')
COMMIT TRANSACTION
GO