PRINT N'Create database Movies...'
GO
CREATE DATABASE Movies
GO

USE Movies
GO

PRINT N'Create table Directors...'
GO
BEGIN TRANSACTION
CREATE TABLE Directors
(
Id int NOT NUll IDENTITY UNIQUE,
DirectorName nvarchar(100) NOT NULL,
Notes nvarchar(max)
CONSTRAINT PK_Directors PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Create table Genres...'
GO
BEGIN TRANSACTION
CREATE TABLE Genres
(
Id int NOT NULL IDENTITY UNIQUE,
GenreName nvarchar(100) NOT NULL,
Notes nvarchar(max)
CONSTRAINT PK_Genres PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Create table Categories...'
GO
BEGIN TRANSACTION
CREATE TABLE Categories
(
Id int NOT NULL IDENTITY UNIQUE,
CategoryName nvarchar(100) NOT NULL,
Notes nvarchar(max)
CONSTRAINT PK_Categories PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Create table Movies...'
GO
BEGIN TRANSACTION
CREATE TABLE Movies
(
Id int NOT NULL IDENTITY UNIQUE,
Title nvarchar(200) NOT NULL,
DirectorId int NOT NULL,
CopyrightYear date ,
Length time,
GerneId int NOT NULL,
CategoryId int NOT NULL,
Raiting float,
Notes nvarchar(max)
CONSTRAINT PK_Movies PRIMARY KEY (Id)
)
COMMIT TRANSACTION
GO

PRINT N'Add FK_Movies_Directors...'
GO
BEGIN TRANSACTION
ALTER TABLE Movies
ADD CONSTRAINT FK_Movies_Directors FOREIGN KEY (DirectorId)
REFERENCES Directors (Id)
COMMIT TRANSACTION
GO

PRINT N'Add FK_Movies_Genres...'
GO
BEGIN TRANSACTION
ALTER TABLE Movies
ADD CONSTRAINT FK_Movies_Genres FOREIGN KEY (GerneId)
REFERENCES Genres (Id)
COMMIT TRANSACTION
GO

PRINT N'Add FK_Movies_Categories...'
GO
BEGIN TRANSACTION
ALTER TABLE Movies
ADD CONSTRAINT FK_Movies_Categories FOREIGN KEY (CategoryId)
REFERENCES Categories (Id)
COMMIT TRANSACTION
GO

PRINT N'Insert values into Directors...'
GO
BEGIN TRANSACTION
INSERT INTO Directors (DirectorName, Notes)
VALUES ('Valio', 'debil'),
	   ('Monika', 'gotina'),
	   ('Kiso', 'nishto'),
	   ('Asen Haralampiev Kupeikov', NULL),
	   ('Kuzmanka Kalpachka', NULL)
COMMIT TRANSACTION
GO

PRINT N'Insert values into Genres...'
GO
BEGIN TRANSACTION
INSERT INTO Genres (GenreName, Notes)
VALUES ('Ujas', 'mnogo iak'),
	   ('Drama', 'tup'),
	   ('Ekshun', 'ole-male'),
	   ('Komedia', 'stava'),
	   ('Musical', NULL)
COMMIT TRANSACTION
GO

PRINT N'Insert values into Categories...'
GO
BEGIN TRANSACTION
INSERT INTO Categories (CategoryName, Notes)
VALUES ('Nov', 'bla'),
	   ('Star', 'asd'),
	   ('Skup', 'ne si stryva'),
	   ('Evtin', 'pak ne si stryva'),
	   ('Ne znam', NULL)
COMMIT TRANSACTION
GO

PRINT N'Insert values into Movies...'
GO
BEGIN TRANSACTION
INSERT INTO Movies (Title, DirectorId, CopyRightYear, Length, GerneId, CategoryId, Raiting, Notes)
VALUES ('Koshmar', 3, '1996', '1:36', 1, 5, 5, 'mnogo hubav'),
	   ('Film', 1, '2002', '1:28', 2, 4, 3.2, 'a'),
	   ('Stulbata', 2, '2006', '1:42', 3, 3, 1, 'adfqwerzdfdasfggy'),
	   ('Utia', 5, '1986', '1:30', 4, 2, 4.8, 'mnogo hubav'),
	   ('Salam', 4, '2016', '1:36', 5, 1, 4, NULL)
COMMIT TRANSACTION
GO