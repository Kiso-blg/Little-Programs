USE master
GO

PRINT N'Create database Table_Relations...'
GO
CREATE DATABASE Table_Relations
GO

PRINT N'Use database Table_Relations...'
GO
USE Table_Relations
GO

--1
PRINT N'Create table Passports...'
GO
CREATE TABLE Passports
(
PassportID INT NOT NULL,
PassportNumber VARCHAR(50) NOT NULL,
CONSTRAINT PK_Passports
PRIMARY KEY (PassportID)
)

PRINT N'Inserto values into Passports...'
GO
INSERT INTO Passports (PassportID, PassportNumber)
VALUES (101, 'N34FG21B'),
		(102, 'K65LO4R7'),
		(103, 'ZE657QP2')

PRINT N'Create table Persons...'
GO
CREATE TABLE Persons
(
PersonID INT NOT NULL,
FirstName VARCHAR(30) NOT NULL,
Salary DECIMAL(8, 2),
PassportID INT UNIQUE,
CONSTRAINT PK_PersonID
PRIMARY KEY (PersonID),
CONSTRAINT FK_Persons_Passports
FOREIGN KEY (PassportID)
REFERENCES Passports(PassportID)
)

PRINT N'Inserto values into Persons...'
GO
INSERT INTO Persons (PersonID, FirstName, Salary, PassportID)
VALUES (1, 'Roberto', 43300.00, 102),
		(2, 'Tom', 56100.00, 103), 
		(3, 'Yana', 60200.00, 101)

--2
PRINT N'Create table Manufacturers...'
GO
CREATE TABLE Manufacturers
(
ManufacturerID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
EstablishedOn DATE
CONSTRAINT PK_ManufacturerID
PRIMARY KEY (ManufacturerID)
)

PRINT N'Inserto values into Manufacturers...'
GO
INSERT INTO Manufacturers (ManufacturerID, Name, EstablishedOn)
VALUES (1, 'BMW', '07-03-1916'),
	   (2, 'Tesla', '01-01-2003'),
	   (3, 'Lada', '01-05-1966')

PRINT N'Create table Models...'
GO
CREATE TABLE Models
(
ModelID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
ManufacturerID INT NOT NULL,
CONSTRAINT PK_ModelID
PRIMARY KEY (ModelID),
CONSTRAINT FK_ModelID_ManufacturerID
FOREIGN KEY (ManufacturerID)
REFERENCES Manufacturers(ManufacturerID)
)

PRINT N'Inserto values into Models...'
GO
INSERT INTO Models (ModelID, Name, ManufacturerID)
VALUES (101, 'X1', 1),
		(102, 'i6', 1),
		(103, 'Model S', 2),
		(104, 'Model X', 2),
		(105, 'Model 3', 2),
		(106, 'Nova', 3)

--3
PRINT N'Create table Students...'
GO
CREATE TABLE Students
(
StudentID INT NOT NULL,
Name VARCHAR(30) NOT NULL,
CONSTRAINT PK_StudentID
PRIMARY KEY (StudentID)
)
GO

PRINT N'Inserto values into Students...'
GO
INSERT INTO Students (StudentID, Name)
VALUES (1, 'Mila'),
		(2, 'Toni'),
		(3, 'Ron')
GO

PRINT N'Create table Exams...'
GO
CREATE TABLE Exams
(
ExamID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
CONSTRAINT PK_ExamID
PRIMARY KEY (ExamID)
)
GO

PRINT N'Inserto values into Exams...'
GO
INSERT INTO Exams (ExamID, Name)
VALUES (101, 'SpringMVC'),
		(102, 'Neo4j'),
		(103, 'Oracle 11g')
GO

PRINT N'Create table StudentsExams...'
GO
CREATE TABLE StudentsExams
(
StudentID INT NOT NULL,
ExamID INT NOT NULL,
CONSTRAINT PK_StudentsExams
PRIMARY KEY (StudentID, ExamID),
CONSTRAINT FK_StudentsExams_StudentID
FOREIGN KEY (StudentID)
REFERENCES Students(StudentID),
CONSTRAINT FK_StudentsExams_ExamID
FOREIGN KEY (ExamID)
REFERENCES Exams(ExamID)
)
GO

PRINT N'Inserto values into StudentsExams...'
GO
INSERT INTO StudentsExams (StudentID, ExamID)
VALUES (1, 101),
		(1, 102),
		(2, 101),
		(3, 103),
		(2, 102),
		(2, 103)
GO

--4
PRINT N'Create table Teachers...'
GO
CREATE TABLE Teachers
(
TeacherID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
ManagerID INT,
CONSTRAINT PK_Teachers
PRIMARY KEY (TeacherID),
CONSTRAINT FK_Teachers
FOREIGN KEY (ManagerID)
REFERENCES Teachers(TeacherID)
)
GO

PRINT N'Inserto values into Teachers...'
GO
INSERT INTO Teachers (TeacherID, Name, ManagerID)
VALUES (101, 'John', NULL),
	   (102, 'John', NULL),
	   (103, 'John', NULL),
	   (104, 'John', NULL),
	   (105, 'John', NULL),
	   (106, 'John', NULL)
GO

--5
PRINT N'Create table Cities...'
GO
CREATE TABLE Cities
(
CityID INT NOT NULL,
Name VARCHAR(50),
CONSTRAINT PK_Cities
PRIMARY KEY (CityID)
)
GO

PRINT N'Create table Customers...'
GO
CREATE TABLE Customers
(
CustomerID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
Birthdate DATE,
CityID INT,
CONSTRAINT PK_Customers
PRIMARY KEY (CustomerID),
CONSTRAINT FK_Customers_Cities
FOREIGN KEY (CityID)
REFERENCES Cities(CityID)
)
GO

PRINT N'Create table Orders...'
GO
CREATE TABLE Orders
(
OrderID INT NOT NULL,
CustomerID INT,
CONSTRAINT PK_Orders
PRIMARY KEY (OrderID),
CONSTRAINT FK_Orders_Customers
FOREIGN KEY (CustomerID)
REFERENCES Customers(CustomerID)
)
GO

PRINT N'Create table ItemTypes...'
GO
CREATE TABLE ItemTypes
(
ItemTypeID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
CONSTRAINT PK_ItemTypes
PRIMARY KEY (ItemTypeID)
)
GO

PRINT N'Create table Items...'
GO
CREATE TABLE Items
(
ItemID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
ItemTypeID INT
CONSTRAINT PK_Items
PRIMARY KEY (ItemID),
CONSTRAINT FK_Items_ItemTypes
FOREIGN KEY (ItemTypeID)
REFERENCES ItemTypes(ItemTypeID)
)
GO

PRINT N'Create table OrderItems...'
GO
CREATE TABLE OrderItems
(
OrderID INT,
ItemID INT,
CONSTRAINT PK_OrderItems
PRIMARY KEY (OrderID, ItemID),
CONSTRAINT FK_OrderItems_Orders
FOREIGN KEY (OrderID)
REFERENCES Orders(OrderID),
CONSTRAINT FK_OrderItems_Items
FOREIGN KEY (ItemID)
REFERENCES Items(ItemID)
)
GO

--6
USE master
GO

CREATE DATABASE University
GO

PRINT N'Create table Majors...'
GO
CREATE TABLE Majors
(
MajorID INT NOT NULL,
Name VARCHAR(50) NOT NULL,
CONSTRAINT PK_Majors
PRIMARY KEY (MajorID)
)

PRINT N'Create table Students...'
GO
CREATE TABLE Students
(
StudentID INT NOT NULL,
StudentNumber INT NOT NULL,
StudentName VARCHAR(50) NOT NULL,
MajorID INT,
CONSTRAINT PK_Students
PRIMARY KEY (StudentID),
CONSTRAINT FK_Students_Majors
FOREIGN KEY (MajorID)
REFERENCES Majors(MajorID)
)
GO

PRINT N'Create table Payments...'
GO
CREATE TABLE Payments
(
PaymentID INT NOT NULL,
PaymentDate DATE NOT NULL,
PaymentAmount DECIMAL(8, 2),
StudentID INT,
CONSTRAINT PK_Payments
PRIMARY KEY(PaymentID),
CONSTRAINT FK_Payments_Students
FOREIGN KEY (StudentID)
REFERENCES Students(StudentID)
)
GO

PRINT N'Create table Subjects...'
GO
CREATE TABLE Subjects
(
SubjectID INT NOT NULL,
SubjectName VARCHAR(50) NOT NULL,
CONSTRAINT PK_Subject
PRIMARY KEY (SubjectID)
)
GO

PRINT N'Create table Agenda...'
GO
CREATE TABLE Agenda
(
StudentID INT NOT NULL,
SubjectID INT NOT NULL,
CONSTRAINT PK_Agenda
PRIMARY KEY (StudentID, SubjectID),
CONSTRAINT FK_Agenda_Students
FOREIGN KEY (StudentID)
REFERENCES Students(StudentID),
CONSTRAINT FK_Agenda_Subjects
FOREIGN KEY (SubjectID)
REFERENCES Subjects(SubjectID)
)
GO

--9
USE Geography
GO

SELECT M.MountainRange, P.PeakName, P.Elevation
FROM Mountains AS M
JOIN Peaks AS P ON P.MountainId = M.Id
WHERE M.MountainRange = 'Rila'
ORDER BY P.Elevation DESC