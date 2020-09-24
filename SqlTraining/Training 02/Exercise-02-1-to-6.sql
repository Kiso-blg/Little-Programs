CREATE DATABASE Minions
GO

USE Minions
GO

CREATE TABLE Minions(
	Id int NOT NULL,
	Name nvarchar(100) NOT NULL,
	Age int
)
GO

CREATE TABLE Towns (
	Id int NOT NULL,
	Name nvarchar(100) NOT NULL
)
GO

ALTER TABLE Minions
ADD PRIMARY KEY (Id)
GO

ALTER TABLE Towns
ADD PRIMARY KEY (Id)
GO

ALTER TABLE Minions
ADD TownId int
GO

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)
GO

INSERT INTO Towns 
VALUES (1, 'Sofia'),
	   (2, 'Plovdiv'),
	   (3, 'Varna')
GO

INSERT INTO Minions 
VALUES (1, 'Kevin', 22, 1),
	   (2, 'Bob', 15, 3),
	   (3, 'Steward', NULL, 2)
GO

TRUNCATE TABLE Minions
GO

DROP TABLE Minions
GO

DROP TABLE Towns
GO