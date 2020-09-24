USE SoftUni
GO

--CREATE FUNCTION udf_ProjectDurationWeeks (@StartDate DATETIME, @EndDate DATETIME)
--RETURNS INT
--AS
--BEGIN
--	DECLARE @projectWeeks INT;
--	IF (@EndDate IS NULL)
--	BEGIN
--		SET @EndDate = GETDATE()
--	END
--	SET @projectWeeks = DATEDIFF(WEEK, @StartDate, @Enddate)
--	RETURN @projectWeeks;
--END
--GO

SELECT ProjectID, 
		StartDate,
		EndDate,
		dbo.udf_ProjectDurationWeeks (StartDate, EndDate) AS ProjectWeeks
FROM SoftUni.dbo.Projects
ORDER BY StartDate DESC
GO

--CREATE FUNCTION ufn_GetSalaryLevel(@salary INT)
--RETURNS NVARCHAR(10)
--AS
--BEGIN
--	DECLARE @salaryLevel VARCHAR(10)

--	IF (@salary < 30000)
--		SET @salaryLevel = 'Low'
--	ELSE IF (@salary IN (30000, 50000))
--		SET @salaryLevel = 'Average'
--	ELSE
--		SET @salaryLevel = 'High'

--	RETURN @salaryLevel
--END
--GO

DROP FUNCTION ufn_GetSalaryLevel
GO

SELECT FirstName,
		LastName,
		Salary,
		dbo.ufn_GetSalaryLevel (Salary) AS SalaryLevel
FROM Employees
GO

CREATE PROCEDURE dbo.usp_SelectEmployeesBySeniority
AS
	SELECT *
	FROM Employees
	WHERE DATEDIFF(YEAR, HireDate, GETDATE()) > 5
GO

EXEC usp_SelectEmployeesBySeniority
GO

ALTER PROCEDURE usp_SelectEmployeesBySeniority
AS
	SELECT FirstName, LastName, HireDate,
			DATEDIFF(YEAR, HireDate, GETDATE()) AS Years
	FROM Employees
	WHERE DATEDIFF(YEAR, HireDate, GETDATE()) > 5
	ORDER BY HireDate
GO

EXEC usp_SelectEmployeesBySeniority
GO

CREATE PROCEDURE usp_SelectEmployeesBySeniority2(@minYearsAtWork INT = 5)
AS
	SELECT FirstName, LastName, HireDate,
		DATEDIFF(YEAR, HireDate, GETDATE()) AS Years
	FROM Employees
	WHERE DATEDIFF(YEAR, HireDate, GETDATE()) > @minYearsAtWork
	ORDER BY HireDate
GO

EXECUTE usp_SelectEmployeesBySeniority2 10
GO

--CREATE PROCEDURE usp_WithdrawMoney
--	@account INT,
--	@moneyAmount MONEY
--AS
--BEGIN
--BEGIN TRANSACTION
--	UPDATE Accounts
--	SET Balance = Balance - @moneyAmount
--	WHERE Id = @account
--	IF @@ROWCOUNT <> 1
--		BEGIN
--		 ROLLBACK;
--		 RAISERROR('Invalid account!', 16, 1)
--		 RETURN
--	END
--COMMIT TRANSACTION
--END
--GO

--CREATE TRIGGER tr_TownsUpdate ON Towns FOR UPDATE
--AS
--	IF (EXISTS(SELECT * FROM inserted WHERE Name IS NULL)
-- OR
--	EXISTS(SELECT * FROM inserted WHERE LEN(NAME) = 0))
--  BEGIN 
--	RAISERROR('Town name cannot be empty!', 16, 1)
--	ROLLBACK TRANSACTION
--	RETURN	
--  END
  
UPDATE Towns 
SET Name = ''
WHERE TownID = 1
GO

CREATE TABLE Accounts
(
Username VARCHAR(20) NOT NULL,
[Password] VARCHAR(20) NOT NULL,
Active VARCHAR(1) NOT NULL DEFAULT 'Y'
CONSTRAINT PK_Accounts
PRIMARY KEY(Username),
CONSTRAINT CHK_Accounts
CHECK (Active = 'Y' OR Active = 'N')
)
GO

CREATE TRIGGER tr_AccountsDelete ON Accounts
	INSTEAD OF DELETE
AS
  UPDATE A
  SET Active = 'N'
  FROM Accounts AS A
  JOIN DELETED D
  ON D.Username = A.Username
  WHERE A.Active = 'Y'
GO

--1
CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary > 35000
GO

EXECUTE usp_GetEmployeesSalaryAbove35000
GO
DROP PROCEDURE usp_GetEmployeesSalaryAbove35000
GO

--2
CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber (@salary MONEY)
AS
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary >= @salary
GO

EXECUTE usp_GetEmployeesSalaryAboveNumber 35000
GO
DROP PROCEDURE usp_GetEmployeesSalaryAboveNumber
GO
--3
CREATE PROCEDURE usp_GetTownsStartingWith (@startString VARCHAR(50))
AS
	SELECT Name AS Town
	FROM Towns
	WHERE LOWER(LEFT(Name, LEN(@startString))) = LOWER(@startString)
GO

EXECUTE usp_GetTownsStartingWith 'b'
GO
DROP PROCEDURE usp_GetTownsStartingWith
GO

--4
CREATE PROCEDURE usp_GetEmployeesFromTown (@townName VARCHAR(50))
AS
	SELECT E.FirstName, E.LastName
	FROM Employees AS E
	INNER JOIN Addresses AS A
	ON E.AddressID = A.AddressID
	INNER JOIN Towns AS T
	ON A.TownID = T.TownID
	WHERE LOWER(T.Name) = LOWER(@townName)
GO

EXECUTE usp_GetEmployeesFromTown 'Sofia'
GO
DROP PROCEDURE usp_GetEmployeesFromTown
GO

--5
CREATE FUNCTION ufn_GetSalaryLevel(@salary MONEY)
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @salaryLevel VARCHAR(10);
	IF (@salary < 30000)
	BEGIN
		SET @salaryLevel = 'Low'
	END
	ELSE IF (@salary BETWEEN 30000 AND 50000)
	BEGIN
		SET @salaryLevel = 'Average'
	END
	ELSE IF (@salary > 50000)
	BEGIN
		SET @salaryLevel = 'High'
	END

	RETURN @salaryLevel
END
GO

EXECUTE ufn_GetSalaryLevel 62000
GO

--6
CREATE PROCEDURE usp_EmployeesBySalaryLevel (@salaryLevel VARCHAR(10))
AS
	SELECT FirstName, LastName
	FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @salarylevel
GO

EXECUTE usp_EmployeesBySalaryLevel 'High'
GO

DROP PROCEDURE usp_EmployeesBySalaryLevel
GO

DROP FUNCTION ufn_GetSalaryLevel
GO

--7
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	DECLARE @length INT = LEN(@word)
	DECLARE @index INT = 1

	WHIlE (@index <= @length)
	BEGIN
		DECLARE @char CHAR(1) = SUBSTRING(@word, @index, 1)
		IF (CHARINDEX(@char, @setOfLetters) <= 0)
		BEGIN
			RETURN 0
		END
		SET @index += 1
	END

	RETURN 1
END 
GO

SELECT dbo.ufn_IsWordComprised ('oistmiahf', 'Sofia')
GO
SELECT dbo.ufn_IsWordComprised ('oistmiahf', 'halves')
GO
SELECT dbo.ufn_IsWordComprised ('bobr', 'Rob')
GO
SELECT dbo.ufn_IsWordComprised ('pppp', 'Guy')
GO

DROP FUNCTION ufn_IsWordComprised
GO

--8
SELECT E.EmployeeID
FROM Employees AS E
 INNER JOIN Departments AS D
 ON E.DepartmentID = D.DepartmentID
WHERE D.Name IN ('Production', 'Production Control')
GO

ALTER TABLE Departments
ALTER COLUMN ManagerId INT NULL
GO

DELETE FROM EmployeesProjects
WHERE EmployeeID IN (
					SELECT E.EmployeeID
					FROM Employees AS E
					 INNER JOIN Departments AS D
					 ON E.DepartmentID = D.DepartmentID
					WHERE D.Name IN ('Production', 'Production Control')
					)
GO

UPDATE Employees
SET ManagerID = NULL
WHERE ManagerID IN (
					SELECT E.EmployeeID
					FROM Employees AS E
					 INNER JOIN Departments AS D
					 ON E.DepartmentID = D.DepartmentID
					WHERE D.Name IN ('Production', 'Production Control')
					)
GO

UPDATE Departments
SET ManagerID = NULL
WHERE ManagerID IN (
					SELECT E.EmployeeID
					FROM Employees AS E
					 INNER JOIN Departments AS D
					 ON E.DepartmentID = D.DepartmentID
					WHERE D.Name IN ('Production', 'Production Control')
					)
GO

DELETE FROM Employees
WHERE EmployeeID IN (
					SELECT E.EmployeeID
					FROM Employees AS E
					 INNER JOIN Departments AS D
					 ON E.DepartmentID = D.DepartmentID
					WHERE D.Name IN ('Production', 'Production Control')
					)
GO

DELETE FROM Departments
WHERE Name IN ('Production', 'Production Control')
GO

USE master
GO

DROP DATABASE SoftUni
GO

--9
CREATE PROCEDURE usp_AssignProject(@EmloyeeID INT, @ProjectID INT)
AS
BEGIN
	DECLARE @maxEmployeeProjectsCount INT = 3
	DECLARE @employeeProjectsCount INT
	SET @employeeProjectsCount = 
	(
		SELECT COUNT(*)
		FROM dbo.EmployeesProjects AS EP
		WHERE EP.EmployeeID = @EmloyeeID
	)

	BEGIN TRANSACTION
		INSERT INTO dbo.EmployeesProjects (EmployeeID, ProjectID)
		VALUES (@EmloyeeID, @ProjectID)

		IF (@employeeProjectsCount >= @maxEmployeeProjectsCount)
		BEGIN
			RAISERROR('The employee has too many projects!', 16, 1);
			ROLLBACK;
		END
	COMMIT TRANSACTION
END
GO

EXECUTE usp_AssignProject 5, 1
GO

DROP PROCEDURE usp_AssignProject
GO