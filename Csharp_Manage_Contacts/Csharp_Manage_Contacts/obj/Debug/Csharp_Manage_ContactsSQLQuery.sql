CREATE DATABASE Contacts_DB
GO

USE Contacts_DB
GO

CREATE TABLE [User_Table]
(
UserId INT NOT NULL IDENTITY(1, 1),
FirstName VARCHAR(100) NOT NULL,
LastName VARCHAR(100) NOT NULL,
Username VARCHAR(100) NOT NULL UNIQUE,
Password VARCHAR(20) NOT NULL,
Picture VARBINARY(MAX)
CONSTRAINT PK_User_Table
PRIMARY KEY (UserId)
)
GO

CREATE PROCEDURE [uspSelectCurrentUsername]
(
	@Username VARCHAR(100)
)
AS
BEGIN
SELECT Username
FROM [User_Table]
WHERE Username = @Username
END
GO

CREATE PROCEDURE [uspInsertUser]
(
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@Username VARCHAR(100),
	@Password VARCHAR(20),
	@Picture VARBINARY(MAX)
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [User_Table] (FirstName, LastName, Username, Password, Picture)
VALUES (@FirstName, @LastName, @Username, @Password, @Picture)
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [uspLogin]
(
	@Username VARCHAR(100),
	@Password VARCHAR(20)
)
AS
BEGIN
BEGIN TRANSACTION
SELECT * 
FROM [User_Table]
WHERE Username = @Username AND Password = @Password
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [uspSelectUsernameAndPicture]
(
	@UserId INT
)
AS
BEGIN
BEGIN TRANSACTION
SELECT Username, Picture
FROM [User_Table]
WHERE UserId = @UserId
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [uspSelectAllFromUsers]
(
	@UserId INT
)
AS
BEGIN
SELECT *
FROM [User_Table]
WHERE UserId = UserId
END
GO

CREATE PROCEDURE [uspEditUser]
(
	@FirstName VARCHAR(100),
	@LastName VARCHAR(100),
	@Username VARCHAR(100),
	@Password VARCHAR(20),
	@Picture VARBINARY(MAX),
	@UserId INT
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [User_Table]
SET [FirstName] = @FirstName, [LastName] = @LastName, [Username] = @Username, [Password] = @Password, [Picture] = @Picture
WHERE UserId = @UserId
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [uspEditCurrentUsername]
(
	@Username VARCHAR(100),
	@UserId INT
)
AS
BEGIN
SELECT Username
FROM [User_Table]
WHERE Username = @Username AND UserId <> @UserId 
END
GO

CREATE TABLE [Groups_Table]
(
GroupId INT NOT NULL IDENTITY(1, 1),
GroupName VARCHAR (100) NOT NULL,
UserId INT NOT NULL,
CONSTRAINT PK_Groups_Table
PRIMARY KEY (GroupId),
CONSTRAINT FK_Groups_Users
FOREIGN KEY (UserId)
REFERENCES [User_Table] (UserId)
ON DELETE CASCADE 
ON UPDATE CASCADE
)
GO

CREATE PROCEDURE [SelectGroupNameAndId]
(
	@GroupName VARCHAR (100),
	@UserId INT
)
AS
BEGIN
SELECT *
FROM [Groups_Table]
WHERE GroupName = @GroupName AND UserId = @UserId
END
GO

CREATE PROCEDURE [InsertNewGroup]
(
	@GroupName VARCHAR (100),
	@UserId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Groups_Table] (GroupName, UserId)
VALUES (@GroupName, @UserId)
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectNamesOfTheGroups]
(
	@UserId INT
)
AS
BEGIN
SELECT GroupId, GroupName
FROM [Groups_Table]
WHERE UserId = @UserId
END
GO

CREATE PROCEDURE [UpdateGroupName]
(
	@GroupName VARCHAR (100),
	@GroupId INT
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [Groups_Table]
SET GroupName = @GroupName
WHERE GroupId = @GroupId
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectAllFromGroupsTable]
(
	@GroupName VARCHAR (100),
	@UserId INT,
	@GroupId INT
)
AS
BEGIN
SELECT *
FROM [Groups_Table]
WHERE GroupName = @GroupName AND UserId = @UserId AND GroupId <> @GroupId
END
GO

CREATE PROCEDURE [DeleteGroupById]
(
	@GroupId INT
)
AS
BEGIN
BEGIN TRANSACTION
DELETE
FROM [Groups_Table]
WHERE GroupId = @GroupId
COMMIT TRANSACTION
END
GO

CREATE TABLE [Contacts_Table]
(
ContactId INT NOT NULL IDENTITY(1, 1),
FirstName VARCHAR(50) NOT NULL,
LastName VARCHAR(50),
GroupId INT,
Phone VARCHAR(20) NOT NULL,
Email VARCHAR(30),
Address TEXT,
Picture VARBINARY(MAX),
UserId INT NOT NULL,
CONSTRAINT PK_Contacts_Table
PRIMARY KEY (ContactId),
CONSTRAINT FK_Contacts_Groups
FOREIGN KEY (GroupId)
REFERENCES [Groups_Table] (GroupId)
ON DELETE CASCADE 
ON UPDATE CASCADE,
CONSTRAINT FK_Contacts_Users
FOREIGN KEY (UserId)
REFERENCES [User_Table] (UserId)
)
GO

CREATE PROCEDURE [InserContact]
(
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@GroupId INT,
	@Phone VARCHAR(20),
	@Email VARCHAR(30),
	@Address TEXT,
	@Picture VARBINARY(MAX),
	@UserId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Contacts_Table] (FirstName, LastName, GroupId, Phone, Email, Address, Picture, UserId)
VALUES (@FirstName,
		CASE
			WHEN @LastName = '' THEN NULL
			ELSE @LastName
		END,		
		CASE
			WHEN @GroupId < 0 THEN NULL
			ELSE @GroupId
		END,
		@Phone,
		CASE
			WHEN @Email = '' THEN NULL
			ELSE @Email
		END,
		CASE
			WHEN @Address LIKE '' THEN NULL
			ELSE @Address
		END,
		@Picture,
		@UserId)
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [UpdateContact]
(
	@ContactId INT,
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@GroupId INT,
	@Phone VARCHAR(20),
	@Email VARCHAR(30),
	@Address TEXT,
	@Picture VARBINARY(MAX)
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [Contacts_Table] 
SET FirstName = @FirstName,
				LastName = (CASE
								WHEN @LastName = '' THEN NULL
								ELSE  @LastName
							END),
				GroupId = (CASE
								WHEN @GroupId < 0 THEN NULL
								ELSE @GroupId
							END),
				Phone = @Phone,
				Email = (CASE
							WHEN @Email = '' THEN NULL
							ELSE @Email
						END),
				Address = (CASE
								WHEN @Address LIKE '' THEN NULL
								ELSE @Address
							END),
				Picture = @Picture
WHERE ContactId = @ContactId
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectContactsByGroup]
(
	@UserId INT
)
AS
BEGIN
SELECT ContactId, FirstName, LastName, GroupId AS [Group_Id]
FROM [Contacts_Table]
WHERE UserId = @UserId
END
GO

CREATE PROCEDURE [SelectContactsByContactId]
(
	@ContactId INT
)
AS
BEGIN
SELECT *
FROM [Contacts_Table]
WHERE ContactId = @ContactId
END
GO

CREATE PROCEDURE [DeleteContactByContactId]
(
	@ContactId INT
)
AS
BEGIN
BEGIN TRANSACTION
DELETE
FROM [Contacts_Table]
WHERE ContactId = @ContactId
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectAll]
(
	@UserId INT
)
AS
BEGIN
SELECT CT.FirstName AS [First Name],
		CT.LastName AS [Last Name],
		CASE
			WHEN GT.GroupName = NULL THEN 'No Group'
			ELSE GT.GroupName
		END AS [Group Name],
		CT.Phone,
		CT.Email,
		CT.Address,
		CT.Picture AS [Picture]
FROM [Contacts_Table] AS CT
FULL OUTER JOIN [Groups_Table] AS GT
ON CT.GroupId = GT.GroupId
WHERE CT.UserId = @UserId;
END
GO

CREATE PROCEDURE [SelectAllByGroup]
(
	@UserId INT,
	@GroupId INT
)
AS
BEGIN
SELECT CT.FirstName AS [First Name],
		CT.LastName AS [Last Name],
		GT.GroupName AS [Group Name],
		CT.Phone,
		CT.Email,
		CT.Address,
		CT.Picture AS [Picture]
FROM [Contacts_Table] AS CT
INNER JOIN [Groups_Table] AS GT
ON CT.GroupId = GT.GroupId
WHERE CT.UserId = @UserId AND GT.GroupId = @GroupId
END
GO

CREATE PROCEDURE [SelectContactsWithoutGroup]
(
	@UserId INT
)
AS
BEGIN
SELECT CT.FirstName AS [First Name],
		CT.LastName AS [Last Name],
		GT.GroupName,
		CT.Phone,
		CT.Email,
		CT.Address,
		CT.Picture AS [Picture]
FROM [Contacts_Table] AS CT
FULL OUTER JOIN [Groups_Table] AS GT
ON CT.GroupId = GT.GroupId
WHERE CT.UserId = @UserId AND GT.GroupName IS NULL;
END
GO