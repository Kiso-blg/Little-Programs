PRINT N'Create database Hotel...'
GO
CREATE DATABASE Hotel
GO

USE Hotel
GO

PRINT N'Create table Employees...'
GO
BEGIN TRANSACTION
CREATE TABLE Employees
(
Id INT NOT NULL IDENTITY UNIQUE,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Title VARCHAR(30) NOT NULL,
Notes VARCHAR(MAX)
CONSTRAINT PK_Employees PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Insert into Employees values...'
GO
BEGIN TRANSACTION
INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES ('Yoana', 'Pesheva', 'housekeeper', 'sexy'),
		('Yoana', 'Pesheva', 'housekeeper', 'sexy'),
		('Yoana', 'Pesheva', 'housekeeper', 'sexy')
COMMIT TRANSACTION
GO

PRINT N'Create table Customers...'
GO
BEGIN TRANSACTION
CREATE TABLE Customers
(
AccountNumber INT NOT NULL,
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
PhoneNumber INT NOT NULL,
EmergencyName VARCHAR(150) NOT NULL,
EmergencyNumber INT NOT NULL,
Notes VARCHAR(MAX)
CONSTRAINT PK_Customers PRIMARY KEY (AccountNumber)
)

PRINT N'Insert into Customers values...'
GO
BEGIN TRANSACTION
INSERT INTO Customers (AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
VALUES (4565, 'Irena', 'Shirokanska', 0896599708, 'Rozalia', 0896624101, 'hybavici'),
		(45625, 'Irena', 'Shirokanska', 0896599708, 'Rozalia', 0896624101, 'hybavici'),
		(45635, 'Irena', 'Shirokanska', 0896599708, 'Rozalia', 0896624101, 'hybavici')
COMMIT TRANSACTION
GO

PRINT N'Create table RoomStatus...'
GO
BEGIN TRANSACTION
CREATE TABLE RoomStatus
(
RoomStatus VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX) NOT NULL
CONSTRAINT PK_RoomStatus PRIMARY KEY (RoomStatus)
)

PRINT N'Insert into RoomStatus values...'
GO
BEGIN TRANSACTION
INSERT INTO RoomStatus (RoomStatus, Notes)
VALUES ('available', 'very good'),
		('busy', 'very good'),
		('cleening', 'very good')
COMMIT TRANSACTION
GO

PRINT N'Create table RoomTypes...'
GO
BEGIN TRANSACTION
CREATE TABLE RoomTypes
(
RoomType VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
CONSTRAINT PK_RoomTypes PRIMARY KEY (RoomType)
)

PRINT N'Insert into RoomTypes values...'
GO
BEGIN TRANSACTION
INSERT INTO RoomTypes (RoomType, Notes)
VALUES ('single', 'TV'),
		('double', 'TV'),
		('flat', 'TV')
COMMIT TRANSACTION
GO

PRINT N'Create table BedTypes...'
GO
BEGIN TRANSACTION
CREATE TABLE BedTypes
(
BedType VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
CONSTRAINT PK_BedTypes PRIMARY KEY (BedType)
)

PRINT N'Insert into BedTypes values...'
GO
BEGIN TRANSACTION
INSERT INTO BedTypes (BedType, Notes)
VALUES ('single bed', 'None'),
		('double bed', 'None'),
		('two beds', 'None')
COMMIT TRANSACTION
GO

PRINT N'Create table Rooms...'
GO
BEGIN TRANSACTION
CREATE TABLE Rooms
(
RoomNumber INT NOT NULL,
CONSTRAINT PK_Rooms PRIMARY KEY (RoomNumber),
RoomType VARCHAR(50) NOT NULL,
CONSTRAINT FK_Rooms_RoomTypes FOREIGN KEY (RoomType)
REFERENCES RoomTypes(RoomType),
BedType VARCHAR(50) NOT NULL,
CONSTRAINT FK_Rooms_BedTypes FOREIGN KEY (BedType)
REFERENCES BedTypes(BedType),
Rate DECIMAL(5, 1),
RoomStatus VARCHAR(50) NOT NULL,
CONSTRAINT FK_Rooms_RoomStatus FOREIGN KEY (RoomStatus)
REFERENCES RoomStatus (RoomStatus),
Notes VARCHAR(MAX)
)
COMMIT TRANSACTION
GO

PRINT N'Insert into Rooms values...'
GO
BEGIN TRANSACTION
INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
VALUES (103, 'single', 'single bed', 5.1, 'available', 'new'),
		(203, 'single', 'single bed', 5.1, 'available', 'new'),
		(113, 'single', 'single bed', 5.1, 'available', 'new')
COMMIT TRANSACTION
GO

PRINT N'Create table Payments...'
GO
BEGIN TRANSACTION
CREATE TABLE Payments
(
Id INT NOT NULL IDENTITY,
CONSTRAINT PK_Payments PRIMARY KEY (Id),
EmployeeId INT NOT NULL,
CONSTRAINT FK_Payments_Employees FOREIGN KEY (EmployeeId)
REFERENCES Employees (Id),
PaymentDate DATE NOT NULL,
AccountNumber INT NOT NULL,
CONSTRAINT FK_Payments_Customers FOREIGN KEY (AccountNumber)
REFERENCES Customers (AccountNumber),
FirstDateOccupied DATE NOT NULL,
LastDateOccupied DATE NOT NULL,
TotalDays INT NOT NULL,
AmountCharged DECIMAL(10, 2) NOT NULL,
TaxRate DECIMAL(5, 1) NOT NULL,
TaxAmount DECIMAL(10, 2) NOT NULL,
PaymentTotal DECIMAL (10, 2) NOT NULL,
Notes VARCHAR(MAX)
)
COMMIT TRANSACTION
GO

PRINT N'Insert into Payments values...'
GO
BEGIN TRANSACTION
INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, 
								TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
VALUES (1, '2017-01-30', 45625, '2017-01-20', '2017-01-30', 10, 250.02, 10.0, 50.00, 300.02, 'None'),
		(2, '2017-01-30', 45625, '2017-01-20', '2017-01-30', 10, 250.02, 10.0, 50.00, 300.02, 'None'),
		(3, '2017-01-30', 45625, '2017-01-20', '2017-01-30', 10, 250.02, 10.0, 50.00, 300.02, 'None')
COMMIT TRANSACTION
GO

PRINT N'Create table Occupancies...'
GO
BEGIN TRANSACTION
CREATE TABLE Occupancies
(
Id INT NOT NULL IDENTITY,
CONSTRAINT PK_Occupancies PRIMARY KEY (Id),
EmployeeId INT NOT NULL,
CONSTRAINT FK_Occupancies_Employees FOREIGN KEY (EmployeeId)
REFERENCES Employees (Id),
DateOccupied DATE NOT NULL,
AccountNumber INT NOT NULL,
CONSTRAINT FK_Occupancies_Customers FOREIGN KEY (AccountNumber)
REFERENCES Customers (AccountNumber),
RoomNumber INT NOT NULL,
CONSTRAINT FK_Occupancies_Rooms FOREIGN KEY (RoomNumber)
REFERENCES Rooms (RoomNumber),
RateApplied DECIMAL(5, 2),
PhoneCharge DECIMAL(10, 2) DEFAULT 0,
Notes VARCHAR(MAX)
)
COMMIT TRANSACTION
GO

PRINT N'Insert into Occupancies values...'
GO
BEGIN TRANSACTION
INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
VALUES (1, '2017-01-30', 45625, 103, 10.0, NULL, 'ZXC'),
		(2, '2017-01-30', 45625, 103, 10.0, NULL, 'ZXC'),
		(3, '2017-01-30', 45625, 103, 10.0, NULL, 'ZXC')
COMMIT TRANSACTION
GO

PRINT N'Update TaxRate in Payments...'
GO
BEGIN TRANSACTION
UPDATE Payments
SET TaxRate = TaxRate * 0.97
COMMIT TRANSACTION
GO 

SELECT TaxRate
FROM Payments
GO

TRUNCATE TABLE Occupancies
GO