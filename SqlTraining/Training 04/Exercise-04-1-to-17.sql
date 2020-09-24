--1
SELECT FirstName,
	   LastName
FROM Employees
WHERE FirstName LIKE 'SA%'

--2
SELECT FirstName,
	   LastName
FROM Employees
WHERE LastName LIKE '%EI%'

--3
SELECT FirstName
FROM Employees
WHERE DepartmentID IN (3, 10) 
	AND YEAR(HireDate) BETWEEN 1995 AND 2005

--4
SELECT FirstName,
	   LastName
FROM Employees
WHERE NOT JobTitle LIKE '%engineer%'

--5
SELECT Name
FROM Towns
WHERE LEN(Name) IN (5, 6)
ORDER BY Name ASC

--6
SELECT TownID, Name
FROM Towns
WHERE LEFT(Name, 1) IN ('M', 'K', 'B', 'E')
ORDER BY Name ASC

--7
SELECT TownID, Name
FROM Towns
WHERE NOT LEFT(Name, 1) IN ('R', 'B', 'D')
ORDER BY Name ASC

--8
CREATE VIEW V_EmployeesHiredAfter2000
AS
	SELECT FirstName, LastName
	FROM Employees
	WHERE YEAR(HireDate) > 2000
GO
SELECT * FROM V_EmployeesHiredAfter2000

--9
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5

USE Geography

--10
SELECT CountryName, IsoCode
FROM Countries
WHERE LEN(CountryName) - LEN(REPLACE(CountryName, 'a', '')) > 2
ORDER BY IsoCode ASC

--11
SELECT PeakName, RiverName,
	LOWER(CONCAT(PeakName, SUBSTRING(RiverName, 2, LEN(RiverName) - 1))) AS Mix
	--LOWER(CONCAT(PeakName, RIGHT(RiverName, LEN(RiverName) - 1))) AS Mix
FROM Peaks, Rivers
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY PeakName ASC

USE Diablo
GO

--12
SELECT TOP (50) Name, CONVERT(varchar(10), Start, 126) AS Start
FROM Games
WHERE YEAR(Start) IN (2011, 2012)
ORDER BY Start ASC,
		 Name ASC

SELECT TOP (50) Name, FORMAT(Start, 'yyyy-MM-dd') AS Start
FROM Games
WHERE YEAR(Start) BETWEEN 2011 AND 2012
ORDER BY Start ASC,
		 Name ASC

--13
SELECT Username, SUBSTRING(Email, CHARINDEX('@', Email) + 1, 1000) AS [Email Provider]
FROM Users
ORDER BY [Email Provider] ASC,
		 Username ASC

--14
SELECT Username, IpAddress AS [IP Address]
FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username ASC

--15
SELECT Name,
CASE
	WHEN FORMAT(Start, 'HH') BETWEEN 0 AND 11 THEN 'Morning'
	WHEN DATEPART(HOUR, Start) BETWEEN 12 AND 17 THEN 'Afternoon' 
	WHEN DATEPART(HOUR, Start) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the Day],
CASE
	WHEN Duration BETWEEN 0 AND 3 THEN 'Extra Short'
	WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
	WHEN Duration > 6 THEN 'Long'
	ELSE 'Extra Long'
END AS [Duration]
FROM Games
ORDER BY Name ASC,
		 [Duration] ASC,
		 [Part of the Day] ASC

USE Orders
GO

--16
SELECT ProductName, OrderDate,
	DATEADD(DAY, 3, OrderDate) AS [Pay Due],
	DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
FROM Orders 

--17
USE People
GO

CREATE TABLE People2
(
Id INT NOT NULL IDENTITY,
Name VARCHAR(50) NOT NULL,
Birthdate DATETIME NOT NULL
)

INSERT INTO People2 VALUES ('Victor', '2000-12-07 00:00:00.000')
INSERT INTO People2 VALUES ('Steven', '1992-09-10 00:00:00.000')
INSERT INTO People2 VALUES ('Stephen', '1910-09-19 00:00:00.000')
INSERT INTO People2 VALUES ('John', '2010-01-06 00:00:00.000')

SELECT Name,
	   DATEDIFF(YEAR, Birthdate, GETDATE()) AS [Age in Years],
	   DATEDIFF(MONTH, Birthdate, GETDATE()) AS [Age in Months],
	   DATEDIFF(DAY, Birthdate, GETDATE()) AS [Age in Days],
	   DATEDIFF(MINUTE, Birthdate, GETDATE()) AS [Age in Days]
FROM People2