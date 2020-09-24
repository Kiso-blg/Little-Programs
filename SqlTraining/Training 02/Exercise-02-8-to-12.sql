PRINT N'Creating Database Users...'
GO
CREATE DATABASE Users
GO

USE Users
GO

PRINT N'Create table Users...'
GO
CREATE TABLE Users
(
Id bigint NOT NULL IDENTITY UNIQUE,
Username nvarchar(30) NOT NULL UNIQUE,
Password nvarchar(26) NOT NULL,
ProfilePicture varbinary(max),
LastLoginTime smalldatetime,
IsDeleted bit,
CONSTRAINT PK_Users PRIMARY KEY (Id)
)
GO

PRINT N'Add CH_ProfilePicture constraint...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
ADD CONSTRAINT CH_ProfilePicture
CHECK (DATALENGTH(ProfilePicture) < 900 * 1024)
COMMIT TRANSACTION
GO

PRINT N'Insert into Users values...'
GO
BEGIN TRANSACTION
INSERT INTO Users (Username, Password, ProfilePicture, LastLoginTime, IsDeleted)
VALUES ('Penka', 'qwe222', NULL, NULL, 0),
	   ('Genka', 'qweqwe', NULL, NULL, 1),
	   ('Semka', '123222', NULL, NULL, 0),
	   ('Benka', 'zxc222', NULL, NULL, 0),
	   ('Ivan', 'aaa222', NULL, NULL, 0)
COMMIT TRANSACTION
GO

PRINT N'Drop constraint PK_Users...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
DROP CONSTRAINT PK_Users
COMMIT TRANSACTION
GO

PRINT N'Add constraint PK_Users...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id, Username)
COMMIT TRANSACTION
GO

PRINT N'Add Password check constraint...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
ADD CONSTRAINT CH_Password
CHECK (LEN(Password) > 4)
COMMIT TRANSACTION
GO

PRINT N'Add default datetime to LastLoginTime...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
ADD DEFAULT GETDATE()
FOR LastLoginTime
COMMIT TRANSACTION
GO

PRINT N'Drop constraint PK_Users...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
DROP CONSTRAINT PK_Users
COMMIT TRANSACTION
GO

PRINT N'Add constraint PK_Users...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id)
COMMIT TRANSACTION
GO

PRINT N'Add CH_Username check constraint...'
GO
BEGIN TRANSACTION
ALTER TABLE Users
ADD CONSTRAINT CH_Username
CHECK (LEN(Username) > 2)
COMMIT TRANSACTION
GO

PRINT N'Insert into Users values test...'
GO
BEGIN TRANSACTION
INSERT INTO Users (Username, Password, ProfilePicture, LastLoginTime, IsDeleted)
VALUES ('Pe', 'qwe47', NULL, NULL, 0)
COMMIT TRANSACTION
GO

PRINT N'Insert into Users values test...'
GO
BEGIN TRANSACTION
INSERT INTO Users (Username, Password, ProfilePicture, LastLoginTime, IsDeleted)
VALUES ('Penkaa', 'qwe', NULL, NULL, 0)
COMMIT TRANSACTION
GO