CREATE DATABASE [Library_Management_System_DB]
GO

USE [Library_Management_System_DB]
GO

CREATE TABLE [Administrations_Table]
(
AdministrationId INT NOT NULL IDENTITY(1, 1),
AdministrationName VARCHAR(50) NOT NULL,
ChiefAdministratorLogin VARCHAR(50) NOT NULL,
ChiefAdministratorPassword VARCHAR(50) NOT NULL
CONSTRAINT PK_Administration_Table
PRIMARY KEY (AdministrationId)
)
GO

CREATE PROCEDURE [AddAdministration]
(
	@AdministrationName VARCHAR(50),
	@ChiefAdministratorLogin VARCHAR(50),
	@ChiefAdministratorPassword VARCHAR(50)
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Administrations_Table] (AdministrationName, ChiefAdministratorLogin, ChiefAdministratorPassword)
VALUES (@AdministrationName, @ChiefAdministratorLogin, @ChiefAdministratorPassword)

IF (@@ROWCOUNT <> 1)
	BEGIN
	  ROLLBACK
	  RETURN
	END
ELSE
	BEGIN
	  COMMIT TRANSACTION
	END
END
GO

CREATE TABLE [Administrators_Table]
(
AdministratorId INT NOT NULL IDENTITY(1, 1),
AdministratorLogin VARCHAR(50) NOT NULL,
AdminFirstName VARCHAR(50) NOT NULL,
AdminLastName VARCHAR(50) NOT NULL,
AdminPassword VARCHAR(50) NOT NULL,
AdministrationId INT NOT NULL
CONSTRAINT PK_Administrators_Table
PRIMARY KEY (AdministratorId),
CONSTRAINT FK_Administrators_Administration
FOREIGN KEY (AdministrationId)
REFERENCES [Administrations_Table] (AdministrationId)
ON DELETE CASCADE
)
GO

CREATE PROCEDURE [AddChiefAdministrator]
(
	@AdministratorLogin VARCHAR(50),
	@AdminFirstName VARCHAR(50),
	@AdminLastName VARCHAR(50), 
	@AdminPassword VARCHAR(50)
)
AS
BEGIN 
DECLARE @AdministrationId INT = (SELECT (AdministrationId)
								 FROM [Administrations_Table]
								 WHERE ChiefAdministratorLogin = @AdministratorLogin
								 AND ChiefAdministratorPassword = @AdminPassword)
BEGIN TRANSACTION
INSERT INTO [Administrators_Table] (AdministratorLogin, AdminFirstName, AdminLastName, AdminPassword, AdministrationId)
VALUES (@AdministratorLogin, @AdminFirstName, @AdminLastName, @AdminPassword, @AdministrationId)

IF (@@ROWCOUNT <> 1)
	BEGIN
	  ROLLBACK
	  RETURN
	END
ELSE
	BEGIN
	  COMMIT TRANSACTION
	END
END
GO

CREATE PROCEDURE [SelectfAdministration]
(
	@AdministrationName VARCHAR(50)
)
AS
BEGIN
SELECT AdministrationName
FROM [Administrations_Table]
WHERE AdministrationName = @AdministrationName
END
GO

CREATE PROCEDURE [DeleteAdministration]
(
	@AdministrationName VARCHAR(50),
	@ChiefAdministratorLogin VARCHAR(50),
	@ChiefAdministratorPassword VARCHAR(50)
)
AS
BEGIN
BEGIN TRANSACTION
DELETE
FROM [Administrations_Table]
WHERE AdministrationName = @AdministrationName 
	  AND ChiefAdministratorLogin = @ChiefAdministratorLogin
	  AND ChiefAdministratorPassword = @ChiefAdministratorPassword

IF (@@ROWCOUNT <> 1)
	BEGIN
	  ROLLBACK
	  RETURN
	END
ELSE
	BEGIN
	  COMMIT TRANSACTION
	END
END
GO

CREATE PROCEDURE [SelectAdministrator]
(
	@AdministrationId INT,
	@AdministratorLogin VARCHAR(50)
)
AS
BEGIN 
SELECT AdministratorLogin
FROM [Administrators_Table]
WHERE AdministratorLogin = @AdministratorLogin 
	  AND AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [AddNewAdministrator]
(
	@AdministrationId INT,
	@AdministratorLogin VARCHAR(50),
	@AdminFirstName VARCHAR(50),
	@AdminLastName VARCHAR(50),
	@AdminPassword VARCHAR(50) 
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Administrators_Table]
VALUES (@AdministratorLogin, @AdminFirstName, @AdminLastName, @AdminPassword, @AdministrationId)

IF (@@ROWCOUNT <> 1)
	BEGIN
	  ROLLBACK
	  RETURN
	END
ELSE
	BEGIN
	  COMMIT TRANSACTION
	END
END
GO

CREATE PROCEDURE [DoesChiefAdminExists]
(
	@ChiefAdministratorLogin VARCHAR(50),
	@ChiefAdministratorPassword VARCHAR(50)	
)
AS
BEGIN
DECLARE @AdministrationId INT = (SELECT AdministrationId
								FROM [Administrations_Table]
								WHERE ChiefAdministratorLogin = @ChiefAdministratorLogin
								AND ChiefAdministratorPassword = @ChiefAdministratorPassword)
RETURN @AdministrationId
END
GO

CREATE PROCEDURE [DeleteAdministrator]
(
	@AdministrationId INT,
	@AdministratorLogin VARCHAR(50)
)
AS
BEGIN
BEGIN TRANSACTION
DELETE
FROM [Administrators_Table]
WHERE AdministratorLogin = @AdministratorLogin
	  AND AdministrationId = @AdministrationId

IF (@@ROWCOUNT <> 1)
	BEGIN
	  ROLLBACK
	  RETURN
	END
ELSE
	BEGIN
	  COMMIT TRANSACTION
	END
END
GO

CREATE PROCEDURE [SelectAllAdministrators]
(
	@AdministrationId INT
)
AS
BEGIN
SELECT AdministratorId AS [Administrator Id],
	   AdministratorLogin AS [Administrator Login],
	   AdminFirstName AS [Firs tName],
	   AdminLastName AS [Last Name],
	   AdministrationId AS [Administration Id]
FROM [Administrators_Table]
WHERE AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [DoesAdminExists]
(
	@AdministratorLogin VARCHAR(50),
	@AdministratorPassword VARCHAR(50),
	@AdministrationId INT OUTPUT
)
AS
BEGIN
SELECT @AdministrationId = AdministrationId
FROM [Administrators_Table]
WHERE AdministratorLogin = @AdministratorLogin
AND AdminPassword = @AdministratorPassword
END
GO

CREATE TABLE [Books_Table]
(
BookId INT NOT NULL IDENTITY(1, 1),
BookName VARCHAR(300) NOT NULL,
BookAuthor VARCHAR(250) NOT NULL,
BookPublication VARCHAR(250) NOT NULL,
BookPurchaseDate DATE NOT NULL,
BookPrice MONEY NOT NULL,
BookQuantity INT NOT NULL,
AdministrationId INT NOT NULL,
CONSTRAINT PK_Books
PRIMARY KEY (BookId),
CONSTRAINT FK_Books_Administrations
FOREIGN KEY (AdministrationId)
REFERENCES [Administrations_Table] (AdministrationId)
ON DELETE CASCADE
)
GO

CREATE PROCEDURE [AddNewBook]
(
	@BookName VARCHAR(300),
	@BookAuthor VARCHAR(250),
	@BookPublication VARCHAR(250),
	@BookPurchaseDate DATETIME,
	@BookPrice MONEY,
	@BookQuantity INT,
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Books_Table] (BookName, BookAuthor, BookPublication, BookPurchaseDate, BookPrice, BookQuantity, AdministrationId)
VALUES (@BookName, @BookAuthor, @BookPublication, @BookPurchaseDate, @BookPrice, @BookQuantity, @AdministrationId)

IF @@ROWCOUNT < 1
  BEGIN
   ROLLBACK
   RETURN
  END
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectAllBooks]
(
	@AdministrationId INT
)
AS
BEGIN
SELECT *
FROM [Books_Table]
WHERE AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [SelectBooksById]
(
	@BookId INT,
	@AdministrationId INT
)
AS
BEGIN
SELECT *
FROM [Books_Table]
WHERE BookId = @BookId AND AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [dbo].[SelectBookByBookName]
(
	@BookContainsString VARCHAR(300),
	@AdministrationId INT
)
AS
BEGIN
SELECT * 
FROM [Books_Table]
WHERE [BookName] LIKE CONCAT('%', @BookContainsString, '%') AND AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [UpdateBook]
(
	@BookId INT,
	@BookName VARCHAR(300),
	@BookAuthor VARCHAR(250),
	@BookPublication VARCHAR(250),
	@BookPurchaseDate DATETIME,
	@BookPrice MONEY,
	@BookQuantity INT,
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [Books_Table]
SET BookName = @BookName,
	BookAuthor = @BookAuthor,
	BookPublication = @BookPublication,
	BookPurchaseDate = @BookPurchaseDate,
	BookPrice = @BookPrice,
	BookQuantity = @BookQuantity
WHERE BookId = @BookId AND AdministrationId = @AdministrationId

IF @@ROWCOUNT < 1
  BEGIN
   ROLLBACK
   RETURN
  END
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [DeleteBook]
(
	@BookId INT,
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
DELETE
FROM [Books_Table]
WHERE BookId = @BookId AND AdministrationId = @AdministrationId

IF @@ROWCOUNT < 1
  BEGIN
   ROLLBACK
   RETURN
  END
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectBooksByNameAnd]
(
	@AdministrationId INT
)
AS
BEGIN
SELECT BookId, BookName
FROM [Books_Table]
WHERE AdministrationId = @AdministrationId
END
GO

CREATE TABLE [Students_Table]
(
StudentName VARCHAR(250) NOT NULL,
StudentNumber VARCHAR(250) NOT NULL,
StudentDepartment VARCHAR(250) NOT NULL,
StudentSemester VARCHAR(250) NOT NULL,
StudentContact VARCHAR(20) NOT NULL,
StudentEmail VARCHAR(250),
AdministrationId INT NOT NULL,
CONSTRAINT PK_Students_Table
PRIMARY KEY (StudentNumber),
CONSTRAINT FK_Students_Administrations
FOREIGN KEY (AdministrationId)
REFERENCES [Administrations_Table] (AdministrationId)
ON DELETE CASCADE
)
GO

CREATE PROCEDURE [InsertNewStudent]
(
	@StudentName VARCHAR(250),
	@StudentNumber VARCHAR(250),
	@StudentDepartment VARCHAR(250),
	@StudentSemester VARCHAR(250),
	@StudentContact VARCHAR(20),
	@StudentEmail VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Students_Table] (StudentName, StudentNumber, StudentDepartment, StudentSemester, StudentContact, StudentEmail, AdministrationId)
VALUES (@StudentName,
		@StudentNumber,
		@StudentDepartment,
		@StudentSemester,
		@StudentContact,
		CASE
			WHEN @StudentEmail = '' THEN NULL
			ELSE @StudentEmail
		END,
		@AdministrationId)

IF @@ROWCOUNT < 1
  BEGIN
   ROLLBACK
   RETURN
  END
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectAllStudents]
(
	@AdministrationId INT
)
AS
BEGIN
SELECT *
FROM [Students_Table]
WHERE AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [SelectStudentsByStudentNo]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
SELECT *
FROM [Students_Table]
WHERE [StudentNumber] LIKE CONCAT('%', @StudentNumber, '%') AND  AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [SelectCurrentStudent]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
SELECT *
FROM [Students_Table]
WHERE [StudentNumber] = @StudentNumber AND  AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [UpdateStudentData]
(
	@StudentName VARCHAR(250),
	@StudentNumber VARCHAR(250),
	@StudentDepartment VARCHAR(250),
	@StudentSemester VARCHAR(250),
	@StudentContact VARCHAR(20),
	@StudentEmail VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [Students_Table]
SET StudentName = @StudentName,	
	StudentDepartment = @StudentDepartment,
	StudentSemester = @StudentSemester,
	StudentContact = @StudentContact,
	StudentEmail = CASE
						WHEN @StudentEmail = '' THEN NULL
						ELSE @StudentEmail 
				   END
WHERE StudentNumber = @StudentNumber AND  AdministrationId = @AdministrationId

IF @@ROWCOUNT < 1
  BEGIN
   ROLLBACK
   RETURN
  END
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [DeleteStudent]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
DELETE
FROM [Students_Table]
WHERE StudentNumber = @StudentNumber AND  AdministrationId = @AdministrationId

IF @@ROWCOUNT < 1
  BEGIN
   ROLLBACK
   RETURN
  END
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectStudentById]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
SELECT *
FROM [Students_Table]
WHERE StudentNumber = @StudentNumber AND  AdministrationId = @AdministrationId
END
GO

CREATE TABLE [IssueReturnBook_Table]
(
IRBookId INT IDENTITY(1, 1) NOT NULL,
BookId INT, 
StudentNumber VARCHAR(250),
BookIssueDate DATE NOT NULL,
BookReturnDate DATE,
AdministrationId INT NOT NULL,
CONSTRAINT PK_IssueReturnBook
PRIMARY KEY (IRBookId),
CONSTRAINT FK_IssueReturnBook_Books
FOREIGN KEY (BookId)
REFERENCES [Books_Table] (BookId),
CONSTRAINT FK_IssueReturnBook_Students
FOREIGN KEY (StudentNumber)
REFERENCES [Students_Table] (StudentNumber),
CONSTRAINT FK_IssueReturnBook_Administrations
FOREIGN KEY (AdministrationId)
REFERENCES [Administrations_Table] (AdministrationId)
ON DELETE CASCADE
)
GO

CREATE PROCEDURE [GiveBook]
(
	@BookId INT,
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [IssueReturnBook_Table] (BookId, StudentNumber, BookIssueDate, AdministrationId)
VALUES (@BookId, @StudentNumber, GETDATE(), @AdministrationId)

IF (@@ROWCOUNT <> 1)
  BEGIN
   ROLLBACK
   RETURN
  END
ELSE
  COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [IsBookAlreadyTaken]
(
	@BookId INT,
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
DECLARE @RowsCount INT = (SELECT COUNT(BookId)
							FROM [IssueReturnBook_Table]
							WHERE BookId = @BookId 
							AND StudentNumber = @StudentNumber
							AND BookReturnDate IS NULL
							AND  AdministrationId = @AdministrationId)
RETURN @RowsCount
END
GO

CREATE PROCEDURE [CanStudentTakeMoreBooks]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
DECLARE @BooksCount INT = (SELECT COUNT(BookId)
							FROM [IssueReturnBook_Table]
							WHERE StudentNumber = @StudentNumber
							AND BookReturnDate IS NULL
							AND  AdministrationId = @AdministrationId)
RETURN @BooksCount
END
GO

CREATE PROCEDURE [SelectStudentAndNotReturnedBooks]
(
	@AdministrationId INT
)
AS
BEGIN
SELECT BT.BookId AS [Book Id],
	   BT.BookName AS [Book Name],
	   ST.StudentName AS [Student Name],
	   ST.StudentNumber AS [Student Number],
	   IRBT.BookIssueDate AS [Book Issue Date],
	   IRBT.BookReturnDate AS [Book Return Date],
	   IRBT.AdministrationId AS [Administration Id]
FROM Books_Table AS BT
INNER JOIN IssueReturnBook_Table AS IRBT
ON BT.BookId = IRBT.BookId
INNER JOIN Students_Table AS ST
ON IRBT.StudentNumber = ST.StudentNumber
WHERE IRBT.BookReturnDate IS NULL AND IRBT.AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [SelectNotReturnetBooksByStudentNumber]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
SELECT BT.BookId AS [Book Id],
	   BT.BookName AS [Book Name],
	   ST.StudentName AS [Student Name],
	   ST.StudentNumber AS [Student Number],
	   IRBT.BookIssueDate AS [Book Issue Date],
	   IRBT.BookReturnDate AS [Book Return Date],
	   IRBT.AdministrationId AS [Administration Id]
FROM Books_Table AS BT
INNER JOIN IssueReturnBook_Table AS IRBT
ON BT.BookId = IRBT.BookId
INNER JOIN Students_Table AS ST
ON IRBT.StudentNumber = ST.StudentNumber
WHERE ST.StudentNumber = @StudentNumber
	AND IRBT.BookReturnDate IS NULL 
	AND IRBT.AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [ReturnBook]
(
	@BookId INT,
	@StudentNumber VARCHAR(250),
	@ReturnBookDate DATE,
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [IssueReturnBook_Table]
SET BookReturnDate = @ReturnBookDate
WHERE BookId = @BookId 
	AND StudentNumber = @StudentNumber 
	AND  AdministrationId = @AdministrationId

IF (@@ROWCOUNT <> 1)
  BEGIN
   ROLLBACK
   RETURN
  END
ELSE
  COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [SelectAllNotReturnedBooks]
(
	@AdministrationId INT
)
AS
BEGIN
SELECT BT.BookId AS [Book Id],
	   BT.BookName AS [Book Name],
	   BT.BookAuthor AS [Book Author],
	   ST.StudentName AS [Student Name],
	   ST.StudentNumber AS [Student Number],
	   ST.StudentDepartment AS [Student Department],
	   ST.StudentContact AS [Student Contact],
	   ST.StudentEmail AS [Student Email],
	   IRBT.BookIssueDate AS [Book Issue Date],
	   IRBT.BookReturnDate AS [Book Return Date],
	   IRBT.AdministrationId AS [Administration Id]
FROM Books_Table AS BT
INNER JOIN IssueReturnBook_Table AS IRBT
ON BT.BookId = IRBT.BookId
INNER JOIN Students_Table AS ST
ON IRBT.StudentNumber = ST.StudentNumber
WHERE IRBT.BookReturnDate IS NULL AND IRBT.AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [SelectAllReturnedBooks]
(
	@AdministrationId INT
)
AS
BEGIN
SELECT BT.BookId AS [Book Id],
	   BT.BookName AS [Book Name],
	   BT.BookAuthor AS [Book Author],
	   ST.StudentName AS [Student Name],
	   ST.StudentNumber AS [Student Number],
	   ST.StudentDepartment AS [Student Department],
	   ST.StudentContact AS [Student Contact],
	   ST.StudentEmail AS [Student Email],
	   IRBT.BookIssueDate AS [Book Issue Date],
	   IRBT.BookReturnDate AS [Book Return Date],
	   IRBT.AdministrationId AS [Administration Id]
FROM Books_Table AS BT
INNER JOIN IssueReturnBook_Table AS IRBT
ON BT.BookId = IRBT.BookId
INNER JOIN Students_Table AS ST
ON IRBT.StudentNumber = ST.StudentNumber
WHERE IRBT.BookReturnDate IS NOT NULL AND IRBT.AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [SelectStudentNotReturnedBooks]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
SELECT BT.BookId AS [Book Id],
	   BT.BookName AS [Book Name],
	   BT.BookAuthor AS [Book Author],
	   ST.StudentName AS [Student Name],
	   ST.StudentNumber AS [Student Number],
	   ST.StudentDepartment AS [Student Department],
	   ST.StudentContact AS [Student Contact],
	   ST.StudentEmail AS [Student Email],
	   IRBT.BookIssueDate AS [Book Issue Date],
	   IRBT.BookReturnDate AS [Book Return Date],
	   IRBT.AdministrationId AS [Administration Id]
FROM Books_Table AS BT
INNER JOIN IssueReturnBook_Table AS IRBT
ON BT.BookId = IRBT.BookId
INNER JOIN Students_Table AS ST
ON IRBT.StudentNumber = ST.StudentNumber
WHERE ST.StudentNumber = @StudentNumber 
	AND IRBT.BookReturnDate IS NULL 
	AND IRBT.AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [SelectStudentReturnedBooks]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
SELECT BT.BookId AS [Book Id],
	   BT.BookName AS [Book Name],
	   BT.BookAuthor AS [Book Author],
	   ST.StudentName AS [Student Name],
	   ST.StudentNumber AS [Student Number],
	   ST.StudentDepartment AS [Student Department],
	   ST.StudentContact AS [Student Contact],
	   ST.StudentEmail AS [Student Email],
	   IRBT.BookIssueDate AS [Book Issue Date],
	   IRBT.BookReturnDate AS [Book Return Date],
	   IRBT.AdministrationId AS [Administration Id]
FROM Books_Table AS BT
INNER JOIN IssueReturnBook_Table AS IRBT
ON BT.BookId = IRBT.BookId
INNER JOIN Students_Table AS ST
ON IRBT.StudentNumber = ST.StudentNumber
WHERE ST.StudentNumber = @StudentNumber 
	AND IRBT.BookReturnDate IS NOT NULL 
	AND IRBT.AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [IsBookIssued]
(
	@BookId INT,
	@AdministrationId INT
)
AS
BEGIN
SELECT BookReturnDate
FROM [IssueReturnBook_Table]
WHERE BookReturnDate IS NULL AND BookId = @BookId AND AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [HasStudentIssuedBooks]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
SELECT BookReturnDate
FROM [IssueReturnBook_Table]
WHERE BookReturnDate IS NULL AND StudentNumber = @StudentNumber AND AdministrationId = @AdministrationId
END
GO

CREATE PROCEDURE [DeleteRecordInIssueReturnBookTableByBookId]
(
	@BookId INT,
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
		DELETE 
		FROM [IssueReturnBook_Table]
		WHERE BookId = @BookId AND AdministrationId = @AdministrationId
		COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [DeleteRecordInIssueReturnBookTableByStudentNumber]
(
	@StudentNumber VARCHAR(250),
	@AdministrationId INT
)
AS
BEGIN
BEGIN TRANSACTION
		DELETE 
		FROM [IssueReturnBook_Table]
		WHERE StudentNumber = @StudentNumber AND AdministrationId = @AdministrationId
		COMMIT TRANSACTION
END
GO