/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Age]
  FROM [Minions].[dbo].[Minions-Exercise-01]


SELECT [Name]
  FROM [Minions].[dbo].[Minions-Exercise-01]

  UPDATE [Minions].[dbo].[Minions-Exercise-01]
SET [Age] = 10
WHERE [Id] = 3

UPDATE [Minions].[dbo].[Minions-Exercise-01]
SET [Age] = [Age] + 1