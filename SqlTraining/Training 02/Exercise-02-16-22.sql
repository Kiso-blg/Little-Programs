PRINT N'Create database SoftUni...'
GO
CREATE DATABASE SoftUni
GO

USE SoftUni
GO

PRINT N'Create table Towns...'
GO
CREATE TABLE Towns
(
Id INT NOT NULL IDENTITY(1, 1) UNIQUE,
Name VARCHAR(50) NOT NULL
CONSTRAINT PK_Towns PRIMARY KEY (Id)
)

PRINT N'Create table Addresses...'
GO
CREATE TABLE Addresses
(
Id INT NOT NULL IDENTITY(1, 1),
CONSTRAINT PK_Addresses PRIMARY KEY (Id),
AddressText VARCHAR(300) NOT NULL,
TownId INT NOT NULL
CONSTRAINT FK_Addresses_Towns FOREIGN KEY (TownId)
REFERENCES Towns (Id)
)
GO

PRINT N'Create table Departments...'
GO
CREATE TABLE Departments
(
Id INT NOT NULL IDENTITY(1, 1),
CONSTRAINT PK_Departments PRIMARY KEY (Id),
Name VARCHAR(100) NOT NULL
)
GO

PRINT N'Create table Employees...'
GO
CREATE TABLE Employees
(
Id INT NOT NULL IDENTITY(1, 1),
CONSTRAINT PK_Employees PRIMARY KEY (Id),
FirstName VARCHAR(50) NOT NULL,
MiddleName VARCHAR(50),
LastName VARCHAR(50) NOT NULL,
JobTitle VARCHAR(100) NOT NULL,
DepartmentId INT NOT NULL,
CONSTRAINT FK_Employees_Departments FOREIGN KEY (DepartmentId)
REFERENCES Departments (Id),
HireDate DATE NOT NULL,
Salary DECIMAL(10, 2) NOT NULL,
AddressId INT,
CONSTRAINT FK_Employees_Addresses FOREIGN KEY (AddressId)
REFERENCES Addresses (Id)
)
GO

PRINT N'Insert into Towns values...'
BEGIN TRANSACTION
INSERT INTO Towns (Name)
VALUES ('Sofia'), ('Plovdiv'), ('Varna'), ('Burgas'), ('Sofia')
COMMIT TRANSACTION
GO

PRINT N'Insert into Departments values...'
BEGIN TRANSACTION
INSERT INTO Departments (Name)
VALUES ('Engineering'), ('Sales'), ('Marketing'), ('Software Development'), ('Quality Assurance')
COMMIT TRANSACTION
GO

PRINT N'Insert into Employees values...'
BEGIN TRANSACTION
INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary)
VALUES ('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00),
		('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00),
		('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25),
		('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00),
		('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88)
COMMIT TRANSACTION
GO

SELECT * FROM Towns

SELECT * FROM Departments 

SELECT * FROM Employees 

SELECT * FROM Towns
ORDER BY Name ASC

SELECT * FROM Departments 
ORDER BY Name ASC

SELECT * FROM Employees 
ORDER BY Salary DESC

SELECT Name
FROM Towns 
ORDER BY Name ASC

SELECT Name
FROM Departments 
ORDER BY Name ASC

SELECT FirstName, LastName, JobTitle, Salary
FROM Employees 
ORDER BY Salary DESC

PRINT N'Update Employees salary...'
GO
BEGIN TRANSACTION
UPDATE Employees
SET Salary = Salary * 1.1
COMMIT TRANSACTION
GO

SELECT Salary
FROM Employees