CREATE DATABASE CollegeManagementSystem_DB
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
