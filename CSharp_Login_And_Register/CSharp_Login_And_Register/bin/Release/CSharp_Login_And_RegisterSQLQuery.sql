CREATE DATABASE [CSharp_Users_DB]
GO

USE [CSharp_Users_DB]
GO

CREATE TABLE [Users]
(
[UserId] INT IDENTITY(0, 1),
[FirstName] VARCHAR(50),
[LastName] VARCHAR(50),
[Email] VARCHAR(100),
[Username] VARCHAR(100) NOT NULL,
[Password] VARCHAR(50) NOT NULL,
CONSTRAINT PK_Users
PRIMARY KEY (UserId)
)
GO

CREATE PROCEDURE [SelectAllFromUsers]
(
	@Username VARCHAR(100),
	@Password VARCHAR(50)
)
AS
BEGIN
SELECT *
FROM [Users]
WHERE [Username] = @Username AND [Password] = @Password
END
GO

CREATE PROCEDURE [InsertNewUser]
(
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@Email VARCHAR(100),
	@Username VARCHAR(100),
	@Password VARCHAR(50)
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Users] (FirstName, LastName, Email, Username, Password)
VALUES (CASE
			WHEN @FirstName = '' THEN NULL
			ELSE @FirstName
		END,
		CASE
			WHEN @LastName = '' THEN NULL
			ELSE @LastName
		END,
		CASE
			WHEN @Email = '' THEN NULL
			ELSE @Email
		END,
		@Username,
		@Password)
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectUserByUsername]
(
	@Username VARCHAR(100)
)
AS
BEGIN
SELECT [Username]
FROM [Users]
WHERE [Username] = @Username
END
GO