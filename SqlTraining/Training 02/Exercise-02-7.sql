PRINT N'Creating Database People...'
GO
CREATE DATABASE People
GO

USE People
GO

PRINT N'Creating Table People...'
GO
CREATE TABLE People 
(
Id int UNIQUE IDENTITY,
Name nvarchar(200) NOT NULL,
Picture varbinary(max),
Height decimal(38,2),
Weight decimal(38,2),
Gender varchar(1) NOT NULL,
Birthdate date NOT NULL,
Biography nvarchar(max)
)
GO

PRINT N'Add primary key constraint to Id...'
GO
BEGIN TRANSACTION
ALTER TABLE People
ADD PRIMARY KEY(Id)
COMMIT TRANSACTION
GO

PRINT N'Add CH_Picture constraint...'
GO
BEGIN TRANSACTION
ALTER TABLE People
ADD CONSTRAINT CH_Picture
CHECK (DATALENGTH(Picture) < 2000 * 1024)
COMMIT TRANSACTION
GO

PRINT N'Add CH_Biography constraint...'
GO
BEGIN TRANSACTION
ALTER TABLE People
ADD CONSTRAINT CH_Biography
CHECK (DATALENGTH(Biography) < 1000000 * 1024)
COMMIT TRANSACTION
GO

PRINT N'Add CH_Gender constraint...'
GO
BEGIN TRANSACTION
ALTER TABLE People
ADD CONSTRAINT CH_Gender
CHECK (Gender = 'm' or Gender = 'f')
COMMIT TRANSACTION
GO

PRINT N'Insert values...'
GO
BEGIN TRANSACTION
INSERT INTO People (Name, Picture, Height, Weight, Gender, Birthdate, Biography)
VALUES ('Avram', NULL, 163.22, 73.6, 'm', '1985-11-16', 'text'),
('Avramka', NULL, 168.3, 63.1, 'f', '1995-01-31', 'text'),
('Snejha', NULL, 158.82, 50.6, 'f', '1989-06-15', 'text'),
('Kirilka', NULL, 183.40, 56.8, 'f', '1990-04-09', 'text'),
('Shafka', NULL, 168.98, 52.6, 'f', '1988-02-26', 'text')
COMMIT TRANSACTION
GO