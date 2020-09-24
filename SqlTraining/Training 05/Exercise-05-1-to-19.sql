USE [SoftUni]
GO

SELECT e.DepartmentID,
	SUM(e.Salary)AS 'Total Salary'
FROM Employees AS e
GROUP BY e.DepartmentID
ORDER BY e.DepartmentID

SELECT E.DepartmentID,
	MIN(e.Salary) AS 'MinSalary'
FROM Employees AS e
GROUP BY e.DepartmentID

SELECT E.DepartmentID,
	COUNT(e.Salary) AS 'SalaryCount'
FROM Employees AS e
GROUP BY e.DepartmentID

SELECT E.DepartmentID,
	SUM(e.Salary) AS 'TotalSalary'
FROM Employees AS e
GROUP BY e.DepartmentID

SELECT E.DepartmentID,
	MAX(e.Salary) AS 'MaxSalary'
FROM Employees AS e
GROUP BY e.DepartmentID

SELECT E.DepartmentID,
	AVG(e.Salary) AS 'AvgSalary'
FROM Employees AS e
GROUP BY e.DepartmentID

SELECT E.DepartmentID,
	SUM(e.Salary) AS 'TotalSalary'
FROM Employees AS e
GROUP BY e.DepartmentID
HAVING SUM(e.Salary) < 250000

USE [Gringotts]
GO

--1
SELECT COUNT(WD.Id) AS 'Count'
FROM WizzardDeposits AS WD

--2
SELECT MAX(WD.MagicWandSize) AS 'LongestMagicWand'
FROM WizzardDeposits AS WD

--3
SELECT WD.DepositGroup,
	MAX(WD.MagicWandSize) AS 'LongestMagicWand'
FROM WizzardDeposits AS WD
GROUP BY WD.DepositGroup
ORDER BY MAX(WD.MagicWandSize)

--4
SELECT TOP (1) WITH TIES DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

---

SELECT DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
HAVING AVG(MagicWandSize) = (SELECT MIN(wizzardAvgSize.AvgMagicWizzardWand) FROM
								(
								SELECT DepositGroup, AVG(MagicWandSize) AS AvgMagicWizzardWand
								FROM WizzardDeposits
								GROUP BY DepositGroup
								) AS wizzardAvgSize
							)

--5
SELECT DepositGroup,
	SUM(DepositAmount) AS 'TotalSum'
FROM WizzardDeposits
GROUP BY DepositGroup
GO

--6
SELECT DepositGroup,
	SUM(DepositAmount) AS 'TotalSum'
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

--7
SELECT DepositGroup,
	SUM(DepositAmount) AS [TotalSum]
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
ORDER BY [TotalSum] DESC

--8
SELECT DepositGroup,
		MagicWandCreator,
		MIN(DepositCharge) ASMinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup,
		 MagicWandCreator
ORDER BY MagicWandCreator ASC,
		 DepositGroup ASC

--9
SELECT
	CASE
		WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
		WHEN Age > 60 THEN '[61+]'
	END AS 'AgeGroup', COUNT('AgeGroup') AS 'WizardCount'
FROM WizzardDeposits
GROUP BY 
	CASE
		WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
		WHEN Age > 60 THEN '[61+]'
	END

----

SELECT ageGroups.AgeGroup, COUNT(AgeGroup)
FROM
(
SELECT
	CASE
		WHEN Age BETWEEN 0 AND 10  THEN '[0-10]'
		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
		WHEN Age > 60 THEN '[61+]'
	END AS 'AgeGroup'
FROM WizzardDeposits
) AS ageGroups
GROUP BY ageGroups.AgeGroup

--10
SELECT DISTINCT LEFT(FirstName, 1) AS 'FirstLetter'
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'

SELECT LEFT(FirstName, 1) AS 'FirstLetter'
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)

--11
SELECT DepositGroup,
	IsDepositExpired,
	AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup,
		 IsDepositExpired
ORDER BY DepositGroup DESC,
		 IsDepositExpired ASC

--12
DECLARE @currentDeposit DECIMAL(8, 2)
DECLARE @previousDeposit DECIMAL(8, 2)
DECLARE @totalSum DECIMAL(8, 2) = 0

DECLARE wizzardCursor CURSOR FOR SELECT DepositAmount FROM WizzardDeposits
OPEN wizzardCursor
FETCH NEXT FROM wizzardCursor INTO @currentDeposit

WHILE (@@FETCH_STATUS = 0)
BEGIN
	IF (@previousDeposit IS NOT NULL)
	BEGIN
		SET @totalSum += (@previousDeposit - @currentDeposit)
	END

SET @previousDeposit = @currentDeposit
FETCH NEXT FROM wizzardCursor INTO @currentDeposit
END

CLOSE wizzardCursor
DEALLOCATE wizzardCursor

SELECT @totalSum

----

DECLARE @index INT = 1
DECLARE @sum DECIMAL(8, 2) = 0
DECLARE @last INT = (SELECT COUNT(WD.Id) AS 'Count'
					FROM WizzardDeposits AS WD)

WHILE (@index < @last)
BEGIN
	DECLARE @current DECIMAL (8, 2) = (SELECT WD.DepositAmount
									  FROM WizzardDeposits AS WD
									  WHERE WD.Id = @index)
	DECLARE @next DECIMAL (8, 2) = (SELECT WD.DepositAmount
								   FROM WizzardDeposits AS WD
								   WHERE WD.Id = @index + 1)
	SET @sum += (@current - @next)
	SET @index += 1
	--SELECT @index, @sum, @current, @next, (@current - @next)
END

SELECT @sum

---

SELECT SUM(wizzardDep.Diff) AS 'SumDifference'
FROM
(
	SELECT TOP (SELECT COUNT(*) FROM WizzardDeposits)
	FirstName,
	DepositAmount,
	LEAD(FirstName) OVER (ORDER BY Id) AS GuestWizzard,
	LEAD(DepositAmount) OVER (ORDER BY Id) AS GuestDeposit,
	DepositAmount - LEAD(DepositAmount) OVER (ORDER BY Id) AS Diff
FROM WizzardDeposits
) AS wizzardDep

USE [SoftUni]
GO

--13
SELECT DepartmentID,
	SUM(Salary) AS [TotalSalary]
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID ASC

--14
SELECT DepartmentID,
	MIN(Salary) AS MinimumSalary
FROM Employees
WHERE HireDate > '01/01/2000'
GROUP BY DepartmentID
HAVING DepartmentID IN (2, 5, 7)
ORDER BY DepartmentID ASC

--15
SELECT E.DepartmentID,
	CASE
		WHEN E.DepartmentID = 1 THEN AVG(E.Salary) + 5000
		ELSE AVG(E.Salary)
	END AS [AverageSalary]
FROM Employees AS E
WHERE E.Salary > 30000 AND NOT E.ManagerID = 42
GROUP BY E.DepartmentID

----

SELECT * INTO NewEmployees
FROM Employees
WHERE Salary > 30000 AND NOT ManagerID = 42

UPDATE NewEmployees
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID,
	AVG(Salary) AS [AverageSalary]
FROM NewEmployees
GROUP BY DepartmentID

--16
SELECT DepartmentID,
	MAX(Salary) AS [MaxSalary]
FROM Employees
GROUP BY DepartmentID
HAVING NOT MAX(Salary) BETWEEN 30000 AND 70000

--17
SELECT COUNT(EmployeeID) AS [Count]
FROM Employees
WHERE ManagerID IS NULL

--18
SELECT salaries.DepartmentID, salaries.Salary
FROM (SELECT DepartmentID,
		MAX(Salary) AS [Salary],
		DENSE_RANK() OVER (PARTITION BY DepartmentID ORDER BY Salary DESC) AS Rank
		FROM Employees
		GROUP BY DepartmentID, Salary) AS salaries
WHERE Rank = 3

--19
SELECT TOP (10) E.FirstName,
		E.LastName,
		E.DepartmentID
FROM Employees AS E
WHERE E.Salary > (
				SELECT AVG(EMP.Salary)
				FROM Employees AS EMP
				WHERE E.DepartmentID = EMP.DepartmentID
				GROUP BY EMP.DepartmentID 
				)
ORDER BY E.DepartmentID ASC