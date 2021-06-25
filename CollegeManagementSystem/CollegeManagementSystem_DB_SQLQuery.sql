CREATE DATABASE [CollegeManagementSystem_DB]
GO

USE CollegeManagementSystem_DB
GO

CREATE TABLE [Colleges]
(
CollegeId INT IDENTITY(1, 1) NOT NULL,
CollegeName VARCHAR(300) NOT NULL,
RectorFirstName VARCHAR(60) NOT NULL,
RectorLastName VARCHAR(60) NOT NULL,
Administrator VARCHAR(60) NOT NULL,
Password VARCHAR(60) NOT NULL,
CONSTRAINT PK_Colleges
PRIMARY KEY (CollegeId)
)
GO

CREATE PROCEDURE [DoesCollegeExists]
(
	@CollegeName VARCHAR(300)
)
AS
BEGIN
SELECT CollegeName
FROM [Colleges]
WHERE CollegeName = @CollegeName
END
GO

CREATE PROCEDURE [AddNewCollege]
(
	@CollegeName VARCHAR(300),
	@RectorFirstName VARCHAR(60),
	@RectorLastName VARCHAR(60),
	@Administrator VARCHAR(60),
	@Password VARCHAR(60)
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [Colleges] (CollegeName, RectorFirstName, RectorLastName, Administrator, Password)
VALUES (@CollegeName, @RectorFirstName, @RectorLastName, @Administrator, @Password)

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

CREATE PROCEDURE [AdministratorLogin]
(
	@Administrator VARCHAR(60),
	@Password VARCHAR(60),
	@CollegeId INT OUTPUT
)
AS
BEGIN
SELECT @CollegeId = CollegeId
FROM [Colleges]
WHERE Administrator COLLATE Latin1_General_CS_AS = @Administrator
	  AND Password COLLATE Latin1_General_CS_AS = @Password
END
GO

CREATE TABLE [Semesters]
(
SemesterId INT NOT NULL IDENTITY(1, 1),
SemesterName VARCHAR(200) NOT NULL,
CONSTRAINT PK_Semesters
PRIMARY KEY (SemesterId),
)
GO

INSERT INTO [Semesters] (SemesterName)
VALUES ('First Semester'),
	   ('Second Semester'),
	   ('Third Semester'),
	   ('Fourth Semester'),
	   ('Fifth Semester'),
	   ('Sixth Semester'),
	   ('Completed')
GO

CREATE PROCEDURE [SelectSemesters]
(
	@CourseId INT,
	@Year INT,
	@CollegeId INT
)
AS
BEGIN
SELECT SE.SemesterId, SE.SemesterName
FROM Semesters AS SE
INNER JOIN AdmissionsTable AS AT
ON SE.SemesterId = AT.SemesterId
WHERE AT.CourseId = @CourseId
AND YEAR(AT.EnlistDate) = @Year
AND AT.CollegeId = @CollegeId
GROUP BY SE.SemesterId, SE.SemesterName
END
GO

CREATE TABLE [CoursesTable]
(
CourseId INT NOT NULL IDENTITY(1, 1),
CourseName VARCHAR(100) NOT NULL,
CourseFee MONEY NOT NULL,
CollegeId INT NOT NULL,
CONSTRAINT PK_CoursesTable
PRIMARY KEY (CourseId),
CONSTRAINT FK_CoursesTable_Colleges
FOREIGN KEY (CollegeId)
REFERENCES Colleges (CollegeId)
)
GO

--INSERT INTO [CoursesTable] (CourseName, CollegeId)
--VALUES ('C Programming', 1),
--	   ('C++', 1),
--	   ('Java', 1),
--	   ('C# (CSharp)', 1),
--	   ('Python', 1),
--	   ('JavaScript', 1)
--GO

CREATE PROCEDURE [SelectAllCourses]
(
	@CollegeId INT
)
AS
BEGIN
SELECT CourseId, CourseName, CourseFee
FROM CoursesTable
WHERE CollegeId = @CollegeId
END
GO

CREATE TABLE [AdmissionsTable]
(
	AdmissionId INT NOT NULL IDENTITY(1,1),
	Name VARCHAR(100) NOT NULL,
	Surname VARCHAR(100) NOT NULL,
	Gender CHAR(1) NOT NULL,
	BirthDate DATE NOT NULL,
	MobilePhone VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	SemesterId INT NOT NULL,
	CourseId INT NOT NULL,
	SchoolName VARCHAR(250) NOT NULL,
	EnlistDate DATE NOT NULL,
	CollegeId INT NOT NULL,
	Address VARCHAR(300) NOT NULL,
	CONSTRAINT CH_Gender
	CHECK (Gender = 'M' OR Gender = 'm' OR Gender = 'F' OR Gender = 'f'),
	CONSTRAINT PK_NewAdmissionTable
	PRIMARY KEY (AdmissionId),
	CONSTRAINT FK_AdmissionsTable_Colleges
	FOREIGN KEY (CollegeId)
	REFERENCES [Colleges] (CollegeId),
	CONSTRAINT FK_AdmissionsTable_Semesters
	FOREIGN KEY (SemesterId)
	REFERENCES [Semesters] (SemesterId),
	CONSTRAINT FK_AdmissionsTable_CoursesTable
	FOREIGN KEY (CourseId)
	REFERENCES [CoursesTable] (CourseId)
)
GO

--EXECUTE sp_rename '[NewAdmissionTable].[NaId]', 'AdmissionId', 'COLUMN'
--GO

--EXECUTE sp_rename 'NewAdmissionTable', 'AdmissionsTable'
--GO

CREATE PROCEDURE [AddNewAdmission]
(
	@Name VARCHAR(100),
	@Surname VARCHAR(100),
	@Gender CHAR(1),
	@BirthDate DATE,
	@MobilePhone VARCHAR(50),
	@Email VARCHAR(50),
	@SemesterId INT,
	@CourseId INT,
	@SchoolName VARCHAR(250),
	@EnlistDate DATE,	
	@Address VARCHAR(300),
	@CollegeId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [AdmissionsTable] (Name, Surname, Gender, BirthDate, MobilePhone, Email,
								SemesterId, CourseId, SchoolName, EnlistDate, Address, CollegeId)
VALUES (@Name, @Surname, @Gender, @BirthDate, @MobilePhone, @Email, @SemesterId,
		@CourseId, @SchoolName, @EnlistDate, @Address, @CollegeId)

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

CREATE PROCEDURE [GetLastId]
(
	@CollegeId INT
)
AS
BEGIN
DECLARE @Id INT = (SELECT TOP 1 AdmissionId
					FROM [AdmissionsTable]
					WHERE CollegeId = @CollegeId
					ORDER BY AdmissionId DESC)
RETURN @Id
END
GO

CREATE PROCEDURE [GetEnlistDates]
(
	@CourseId INT,
	@CollegeId INT,
	@SemesterId INT
)
AS
BEGIN
SELECT YEAR([EnlistDate]) AS [Year]
FROM [AdmissionsTable]
WHERE CourseId = @CourseId
AND CollegeId = @CollegeId
AND SemesterId < @SemesterId
GROUP BY YEAR([EnlistDate])
END
GO

CREATE PROCEDURE [UpdateSemester]
(
	@AdmissionId INT,
	@CollegeId INT,
	@MaxSemesterId INT
)
AS
BEGIN 
BEGIN TRANSACTION
UPDATE [AdmissionsTable]
SET SemesterId += 1
WHERE AdmissionId = @AdmissionId
AND CollegeId = @CollegeId
AND SemesterId + 1 < @MaxSemesterId

IF (@@ROWCOUNT < 1)
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

CREATE PROCEDURE [GetAdmissionData]
(
	@CollegeId INT
)
AS
BEGIN
SELECT AT.AdmissionId, AT.Name, AT.Surname, YEAR(AT.EnlistDate) AS [Year], SE.SemesterName, SE.SemesterId, CT.CourseName, CT.CourseFee
FROM [AdmissionsTable] AS AT
INNER JOIN [Semesters] AS SE
ON AT.SemesterId = SE.SemesterId
INNER JOIN [CoursesTable] AS CT
ON AT.CourseId = CT.CourseId
WHERE AT.CollegeId = @CollegeId
END
GO

CREATE TABLE [FeesTable]
(
FeeId INT NOT NULL IDENTITY(1,1),
FeeAmount MONEY NOT NULL,
AdmissionId INT NOT NULL,
SemesterId INT NOT NULL,
CollegeId INT NOT NULL,
CONSTRAINT PK_FeesTable
PRIMARY KEY (FeeId),
CONSTRAINT FK_FeesTable_AdmissionsTable
FOREIGN KEY (AdmissionId)
REFERENCES [AdmissionsTable] (AdmissionId)
ON DELETE CASCADE,
CONSTRAINT FK_FeesTable_Colleges
FOREIGN KEY (CollegeId)
REFERENCES [Colleges] (CollegeId),
CONSTRAINT FK_FeesTable_Semesters
FOREIGN KEY (SemesterId)
REFERENCES [Semesters] (SemesterId)
)
GO

--ALTER TABLE [FeesTable]
--DROP CONSTRAINT FK_FeesTable_AdmissionsTable
--GO

--ALTER TABLE [FeesTable]
--ADD CONSTRAINT FK_FeesTable_AdmissionsTable
--FOREIGN KEY (AdmissionId)
--REFERENCES [AdmissionsTable] (AdmissionId)
--ON DELETE CASCADE
--GO

CREATE PROCEDURE [IsTheSemesterPaid]
(
	@AdmissionId INT,
	@SemesterId INT
)
AS
BEGIN
SELECT *
FROM [FeesTable]
WHERE AdmissionId = @AdmissionId
AND SemesterId = @SemesterId
END
GO

CREATE PROCEDURE [InsertFeeData]
(
	@FeeAmount MONEY,
	@AdmissionId INT,
	@SemesterId INT,
	@CollegeId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [FeesTable] (FeeAmount, AdmissionId, SemesterId, CollegeId)
VALUES (@FeeAmount, @AdmissionId, @SemesterId, @CollegeId)

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

CREATE PROCEDURE [InsertNewCourse]
(
	@CourseName VARCHAR(100),
	@CourseFee MONEY,
	@CollegeId INT
)
AS
BEGIN
BEGIN TRANSACTION

INSERT INTO [CoursesTable] (CourseName, CourseFee, CollegeId)
VALUES (@CourseName, @CourseFee, @CollegeId)

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

CREATE PROCEDURE [GetCourseData]
(
	@CourseId INT,
	@CollegeId INT
)
AS
BEGIN
SELECT [CourseName], [CourseFee]
FROM [CoursesTable]
WHERE CourseId = @CourseId
AND CollegeId = @CollegeId
END
GO

CREATE PROCEDURE [UpdateCourseData]
(
	@CourseId INT,
	@CourseName VARCHAR(100),
	@CourseFee MONEY,
	@CollegeId INT
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [CoursesTable]
SET CourseName = @CourseName, CourseFee = @CourseFee
WHERE CourseId = @CourseId
AND CollegeId = @CollegeId

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

CREATE PROCEDURE [DeleteCourseById]
(
	@CourseId INT,
	@CollegeId INT
)
AS
BEGIN
BEGIN TRANSACTION
DELETE
FROM [CoursesTable]
WHERE CourseId = @CourseId
AND CollegeId = @CollegeId

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

CREATE PROCEDURE [SelectStudents]
(
	@CourseId INT,
	@Year INT,
	@SemesterId INT,
	@CollegeId INT
)
AS
BEGIN
SELECT AT.AdmissionId, AT.Name, AT.Surname, AT.Gender, AT.Email, AT.EnlistDate, CT.CourseName, SE.SemesterName, FT.FeeAmount
FROM [AdmissionsTable] AS AT
INNER JOIN [Semesters] AS SE
ON AT.SemesterId = SE.SemesterId
INNER JOIN [CoursesTable] AS CT
ON AT.CourseId = CT.CourseId
INNER JOIN [FeesTable] AS FT
ON AT.AdmissionId = FT.AdmissionId
WHERE AT.CourseId = @CourseId
AND YEAR(AT.EnlistDate) = @Year
AND AT.SemesterId = @SemesterId
AND FT.SemesterId = @SemesterId
END
GO

CREATE PROCEDURE [SelectStudentData]
(
	@CollegeId INT
)
AS
BEGIN
SELECT AT.AdmissionId AS [Student Id],
	   AT.Name,
	   AT.Surname,
	   AT.Gender,
	   AT.MobilePhone AS [Mobile Phone],
	   AT.Email,
	   AT.EnlistDate AS [Start year],
	   CT.CourseName AS [Course Name],
	   SE.SemesterName AS [Semester]
FROM [AdmissionsTable] AS AT
INNER JOIN [Semesters] AS SE
ON AT.SemesterId = SE.SemesterId
INNER JOIN [CoursesTable] AS CT
ON AT.CourseId = CT.CourseId
WHERE AT.CollegeId = @CollegeId
END
GO

CREATE PROCEDURE [SelectStudentById]
(
	@AdmissionId INT,
	@CollegeId INT
)
AS
BEGIN
SELECT AT.AdmissionId AS [Student Id],
	   AT.Name,
	   AT.Surname,
	   AT.Gender,
	   AT.MobilePhone AS [Mobile Phone],
	   AT.Email,
	   AT.EnlistDate AS [Start year],
	   CT.CourseName AS [Course Name],
	   SE.SemesterName AS [Semester]
FROM [AdmissionsTable] AS AT
INNER JOIN [Semesters] AS SE
ON AT.SemesterId = SE.SemesterId
INNER JOIN [CoursesTable] AS CT
ON AT.CourseId = CT.CourseId
WHERE AT.AdmissionId = @AdmissionId
AND AT.CollegeId = @CollegeId
END
GO

CREATE PROCEDURE [DeleteStudentById]
(
	@AdmissionId INT,
	@CollegeId INT
)
AS
BEGIN 
BEGIN TRANSACTION
DELETE
FROM [AdmissionsTable]
WHERE AdmissionId = @AdmissionId
AND CollegeId = @CollegeId

IF	(@@ROWCOUNT <> 1)
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

CREATE TABLE [TeachersTable]
(
TeacherId INT NOT NULL IDENTITY(1,1),
TeacherName VARCHAR(100) NOT NULL,										
TeacherSurname VARCHAR(100) NOT NULL,
Gender CHAR(1) NOT NULL,
DateOfBirth DATE NOT NULL,
MobilePhone VARCHAR(50) NOT NULL,
Email VARCHAR(50) NOT NULL,
Address VARCHAR(300) NOT NULL,
CourseId INT NOT NULL,
CollegeId INT NOT NULL,
CONSTRAINT CH_TeacherGender
CHECK (Gender = 'M' OR Gender = 'm' OR Gender = 'F' OR Gender = 'f'),
CONSTRAINT PK_TeachersTable
PRIMARY KEY (TeacherId),
CONSTRAINT FK_TeachersTable_Colleges
FOREIGN KEY (CollegeId)
REFERENCES [Colleges] (CollegeId),
CONSTRAINT FK_TeachersTable_CoursesTable
FOREIGN KEY (CourseId)
REFERENCES [CoursesTable] (CourseId)
)
GO

CREATE PROCEDURE [AddNewTeacher]
(
	@TeacherName VARCHAR(100),
	@TeacherSurname VARCHAR(100),
	@Gender CHAR(1),
	@DateOfBirth DATE,
	@MobilePhone VARCHAR(50),
	@Email VARCHAR(50),
	@Address VARCHAR(300),
	@CourseId INT,
	@CollegeId INT
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [TeachersTable] (TeacherName, TeacherSurname, Gender, DateOfBirth, MobilePhone, Email, Address, CourseId, CollegeId)
VALUES (@TeacherName, @TeacherSurname, @Gender, @DateOfBirth, @MobilePhone, @Email, @Address, @CourseId, @CollegeId)

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

CREATE PROCEDURE [SelectAllTeachers]
(
	@CollegeId INT
)
AS
BEGIN
SELECT TT.TeacherId, TT.TeacherName, TT.TeacherSurname, TT.Gender, TT.DateOfBirth, TT.MobilePhone, TT.Email, TT.Address, CT.CourseName
FROM [TeachersTable] AS TT
INNER JOIN [CoursesTable] AS CT
ON TT.CourseId = CT.CourseId
WHERE TT.CollegeId = @CollegeId
END
GO

CREATE PROCEDURE [SelectTeacherById]
(
	@TeacherId INT,
	@CollegeId INT
)
AS
BEGIN
SELECT TT.TeacherId, TT.TeacherName, TT.TeacherSurname, TT.Gender, TT.DateOfBirth, TT.MobilePhone, TT.Email, TT.Address, CT.CourseId
FROM [TeachersTable] AS TT
INNER JOIN [CoursesTable] AS CT
ON TT.CourseId = CT.CourseId
WHERE TT.TeacherId = @TeacherId
AND TT.CollegeId = @CollegeId
END
GO

CREATE PROCEDURE [DeleteTeacherById]
(
	@TeacherId INT,
	@CollegeId INT
)
AS
BEGIN 
BEGIN TRANSACTION
DELETE
FROM [TeachersTable]
WHERE TeacherId = @TeacherId
AND CollegeId = @CollegeId

IF	(@@ROWCOUNT <> 1)
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