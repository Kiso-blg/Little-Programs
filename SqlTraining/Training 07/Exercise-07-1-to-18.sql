USE SoftUni
GO

SELECT LastName, Name AS DepartmentName
FROM Employees, Departments
GO

SELECT *
FROM Employees AS E
	INNER JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
GO

SELECT *
FROM Employees AS E
	LEFT OUTER JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
GO

SELECT *
FROM Employees AS E
	RIGHT OUTER JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
GO

SELECT * 
FROM Employees AS E
	FULL JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
GO

SELECT * 
FROM Employees AS E
	CROSS JOIN Departments AS D
GO

SELECT TOP (50) E.FirstName, E.LastName, T.Name AS Town, A.AddressText
FROM Employees AS E
	JOIN Addresses AS A
	ON E.AddressID = A.AddressID
	JOIN Towns AS T
	ON A.TownID = T.TownID
ORDER BY E.FirstName ASC,
		 E.LastName ASC
GO

SELECT E.EmployeeID, E.FirstName, E.LastName, D.Name AS DepartmentName
FROM Employees AS E
	INNER JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
WHERE D.Name = 'Sales'
ORDER BY E.EmployeeID ASC
GO

SELECT E.FirstName, E.LastName, E.HireDate,
	D.Name AS DeptName
FROM Employees AS E
	INNER JOIN Departments AS D
	ON (E.DepartmentID = D.DepartmentID
	AND E.HireDate > '1/1/1999'
	AND D.Name IN ('Sales', 'Finance'))
ORDER BY E.HireDate ASC
GO

SELECT TOP (50) E.EmployeeID,
	CONCAT(E.FirstName, E.LastName) AS EmployeeName, 
	CONCAT(M.FirstName, M.LastName) AS ManagerName,
	D.Name AS DepartmentName
FROM Employees AS E
	LEFT JOIN Employees AS M 
	ON E.EmployeeID = M.ManagerID
	LEFT JOIN Departments AS D
	ON D.DepartmentID = E.DepartmentID
ORDER BY E.EmployeeID ASC
GO

SELECT *
FROM Employees AS E
WHERE E.DepartmentID IN
 (
  SELECT D.DepartmentID
  FROM Departments AS D
  WHERE D.Name = 'Finance'
 )
GO

SELECT MIN(A.AvegateSalary) AS MinAverageSalary
FROM 
(
 SELECT E.DepartmentID,
		AVG(E.Salary) AS AvegateSalary
 FROM Employees AS E
 GROUP BY E.DepartmentID
) AS A
GO

WITH Employees_CTE
	(FirstName, LastName, DepartmentName)
AS
(
  SELECT E.FirstName, E.LastName, D.Name AS DepartmentName
  FROM Employees AS E
  LEFT JOIN Departments AS D
  ON D.DepartmentID = E.DepartmentID
) 

SELECT FirstName, LastName, DepartmentName
FROM Employees_CTE

--1
SELECT TOP (5) E.EmployeeID,
				E.JobTitle, 
				A.AddressID,
				A.AddressText
FROM Employees AS E
	INNER JOIN Addresses AS A
	ON E.AddressID = A.AddressID
ORDER BY A.AddressID ASC
GO
--2
SELECT TOP (50) E.FirstName,
				E.LastName,
				T.Name AS Town,
				A.AddressText
FROM Employees AS E
	INNER JOIN Addresses AS A
	ON E.AddressID = A.AddressID
	INNER JOIN Towns AS T
	ON A.TownID = T.TownID
ORDER BY E.FirstName ASC,
		 E.LastName ASC
GO

--3
SELECT E.EmployeeID,
	   E.FirstName,
	   E.LastName,
	   d.Name AS DepartmentName
FROM Employees AS E
	INNER JOIN Departments AS D
	ON (E.DepartmentID = D.DepartmentID
	AND D.Name = 'Sales')
ORDER BY E.EmployeeID ASC
GO

--

SELECT E.EmployeeID,
	   E.FirstName,
	   E.LastName,
	   d.Name AS DepartmentName
FROM Employees AS E
	INNER JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
WHERE D.Name = 'Sales'
ORDER BY E.EmployeeID ASC
GO

--4
SELECT TOP (5) E.EmployeeID,
			   E.FirstName,
			   E.Salary,
			   D.Name AS DepartmentName
FROM Employees AS E
	INNER JOIN Departments AS D
	ON (E.DepartmentID = D.DepartmentID
	AND E.Salary > 15000)
ORDER BY E.DepartmentID ASC
GO

--5
SELECT TOP (3) E.EmployeeID, E.FirstName
FROM Employees AS E
	LEFT OUTER JOIN EmployeesProjects AS EP
	ON (E.EmployeeID = EP.EmployeeID
	AND EP.EmployeeID IS NULL)
ORDER BY E.EmployeeID
GO

---

SELECT TOP (3) NewEmployeeProject.EmployeeID, 
			   NewEmployeeProject.FirstName
FROM (
	SELECT E.EmployeeID, E.FirstName
	FROM Employees AS E
	LEFT OUTER JOIN EmployeesProjects AS EP
	ON (E.EmployeeID = EP.EmployeeID
	AND EP.EmployeeID IS NULL)
) AS NewEmployeeProject
ORDER BY NewEmployeeProject.EmployeeID ASC
GO

--6
SELECT E.FirstName,
	   E.LastName,
	   E.HireDate,
	   D.Name AS DeptName
FROM Employees AS E
	INNER JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
	AND E.HireDate > '01-01-1999'
	AND D.Name IN ('Sales', 'Finance')
ORDER BY E.HireDate ASC
GO

--7
SELECT TOP (5) E.EmployeeID,
			   E.FirstName,
			   P.Name AS ProjectName
FROM Employees AS E
 INNER JOIN EmployeesProjects AS EP
 ON E.EmployeeID = EP.EmployeeID
 INNER JOIN Projects AS P
 ON EP.ProjectID = P.ProjectID
 AND P.StartDate > '2002-08-13'
 AND P.EndDate IS NULL
ORDER BY E.EmployeeID ASC
GO

--8
SELECT E.EmployeeID,
		E.FirstName,
		CASE
			WHEN YEAR(P.StartDate) >= 2005 THEN NULL
			ELSE P.Name
		END AS ProjectName
FROM Employees AS E
 INNER JOIN EmployeesProjects AS EP
 ON E.EmployeeID = EP.EmployeeID
 INNER JOIN Projects AS P
 ON EP.ProjectID = P.ProjectID
 AND E.EmployeeID = 24
ORDER BY E.EmployeeID ASC
GO

--9
SELECT E.EmployeeID,
		E.FirstName,
		E.ManagerID,
		M.FirstName AS ManagerName
FROM Employees AS E
	INNER JOIN Employees AS M
	ON E.ManagerID = M.EmployeeID
	AND E.ManagerID IN (3, 7)
ORDER BY E.EmployeeID ASC

--10
SELECT TOP (50) E.EmployeeID,
		CONCAT(E.FirstName, ' ', E.LastName) AS EmployeeName,
		CONCAT(M.FirstName, ' ', M.LastName) AS ManagerName,
		D.Name AS DepartmentName
FROM Employees AS E
	LEFT OUTER JOIN Employees AS M
	ON E.ManagerID = M.EmployeeID
	LEFT OUTER JOIN Departments AS D
	ON E.DepartmentID = D.DepartmentID
ORDER BY E.EmployeeID ASC

--11
SELECT MIN(A.AvgSal) AS MinAverageSalary
FROM (
SELECT AVG(E.Salary) AS AvgSal
FROM Employees AS E
GROUP BY E.DepartmentID
) AS A
GO

USE Geography
GO

--12
SELECT C.CountryCode,
		M.MountainRange,
		P.PeakName,
		P.Elevation
FROM Countries AS C
INNER JOIN MountainsCountries AS MC	
ON C.CountryCode = MC.CountryCode
AND C.CountryCode = 'BG'
INNER JOIN Mountains AS M
ON MC.MountainId = M.Id
INNER JOIN Peaks AS P
ON M.Id = P.MountainId
AND P.Elevation > 2835
--WHERE C.CountryName = 'Bulgaria'
ORDER BY P.Elevation DESC
GO

--13
SELECT CountryCode,
		COUNT(MountainId) AS MountainRanges
FROM MountainsCountries
--WHERE CountryCode IN ('US', 'RU', 'BG')
GROUP BY CountryCode
HAVING CountryCode IN ('US', 'RU', 'BG')
GO

---
SELECT C.CountryCode, 
	COUNT(M.MountainRange) AS MountainRanges
FROM Countries AS C
INNER JOIN MountainsCountries AS MC
ON C.CountryCode = MC.CountryCode
INNER JOIN Mountains AS M
ON MC.MountainId = M.Id
WHERE C.CountryCode IN ('US', 'RU', 'BG')
GROUP BY C.CountryCode
GO

---
SELECT C.CountryCode, 
	COUNT(MC.MountainId) AS MountainRanges
FROM Countries AS C
INNER JOIN MountainsCountries AS MC
ON C.CountryCode = MC.CountryCode
WHERE C.CountryCode IN ('US', 'RU', 'BG')
GROUP BY C.CountryCode
GO

--14
SELECT TOP (5) C.CountryName,
	R.RiverName
FROM Countries AS C
LEFT OUTER JOIN CountriesRivers AS CR
ON C.CountryCode = CR.CountryCode
LEFT OUTER JOIN Rivers AS R
ON CR.RiverId = R.Id
WHERE C.ContinentCode = 'AF'
ORDER BY CountryName ASC

--15
SELECT USAGES.ContinentCode,
		USAGES.CurrencyCode,
		USAGES.USAGE
FROM
(
	SELECT ContinentCode, CurrencyCode, COUNT(*) AS USAGE
	FROM Countries
	GROUP BY ContinentCode, CurrencyCode
	HAVING COUNT(*) > 1
) AS USAGES
INNER JOIN
(
	SELECT USAGES.ContinentCode, MAX(USAGES.Usage) AS MaxUsage
	FROM
	(
		SELECT C.ContinentCode, C.CurrencyCode, COUNT(*) AS Usage
		FROM Countries AS C
		GROUP BY C.ContinentCode, C.CurrencyCode
	) AS USAGES
	GROUP BY USAGES.ContinentCode
) AS MaxUsages
ON USAGES.ContinentCode = MaxUsages.ContinentCode
AND MaxUsages.MaxUsage = USAGES.USAGE
ORDER BY USAGES.ContinentCode
GO

--16
SELECT COUNT(CountryAndMountain.CountryCode) AS CountryCode
FROM
(
SELECT C.CountryCode
FROM Countries AS C
LEFT OUTER JOIN MountainsCountries AS MC
ON C.CountryCode = MC.CountryCode
WHERE MC.MountainId IS NULL
) AS CountryAndMountain
GO

---

SELECT COUNT(CountryAndMountain.CountryCode) AS CountryCode
FROM
(
SELECT C.CountryCode, MC.MountainId
FROM Countries AS C
LEFT OUTER JOIN MountainsCountries AS MC
ON C.CountryCode = MC.CountryCode
) AS CountryAndMountain
GROUP BY CountryAndMountain.MountainId
HAVING CountryAndMountain.MountainId IS NULL
GO

--17
SELECT TOP (5) C.CountryName, 
	MAX(P.Elevation) AS HighestPeakElevation,
	MAX(R.Length) AS LongestRiverLength
FROM Countries AS C
LEFT OUTER JOIN MountainsCountries AS MC
ON C.CountryCode = MC.CountryCode
LEFT OUTER JOIN Peaks AS P
ON MC.MountainId = P.MountainId
LEFT OUTER JOIN CountriesRivers AS CR
ON C.CountryCode = CR.CountryCode
LEFT OUTER JOIN Rivers AS R
ON CR.RiverId = R.Id
GROUP BY C.CountryName
ORDER BY MAX(P.Elevation) DESC,
		 MAX(R.Length) DESC,
		 C.CountryName ASC
GO

--18
SELECT C.CountryName AS Country,
		CASE
			WHEN MountainTable.HighestPeakName IS NULL THEN '(no highest peak)'
			ELSE MountainTable.HighestPeakName
		END AS HighestPeakName,
		CASE
			WHEN MountainTable.HighestPeakElevation IS NULL THEN 0
			ELSE MountainTable.HighestPeakElevation
		END AS HighestPeakElevation,
		CASE
			WHEN MountainTable.Mountain IS NULL THEN '(no mountain)'
			ELSE MountainTable.Mountain
		END
FROM Countries AS C
 LEFT OUTER JOIN MountainsCountries AS MC
 ON C.CountryCode = MC.CountryCode
 LEFT OUTER JOIN
 (
 SELECT P.MountainId,
		 P.PeakName AS HighestPeakName,
		 MAX(P.Elevation) AS HighestPeakElevation,
		 M.MountainRange AS Mountain
 FROM Peaks AS P
  INNER JOIN Mountains AS M
  ON P.MountainId = M.Id
 GROUP BY M.MountainRange, P.PeakName, P.MountainId
 ) AS MountainTable
 ON MC.MountainId = MountainTable.MountainId
ORDER BY C.CountryName ASC,
		 MountainTable.HighestPeakName ASC

GO