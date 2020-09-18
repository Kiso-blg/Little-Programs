PRINT N'Creating MyDictionaryDB...'
GO
CREATE SCHEMA [MyDictionaryDB]
GO

PRINT N'Creating MyDictionaryTable...'
GO
CREATE TABLE [MyDictionaryTable] (
	[Word] NVARCHAR(40) NOT NULL,
	[WordTranslation] NVARCHAR(MAX) NOT NULL,
	[IsWritten] BIT NOT NULL DEFAULT(0)
);

PRINT N'Creating MyDictionaryDB.uspAddItem...'
GO
CREATE PROCEDURE [MyDictionaryDB].[uspAddItem]
(
	@Word NVARCHAR(40),
	@WordTranslation NVARCHAR(MAX)
)
AS
BEGIN
BEGIN TRANSACTION
INSERT INTO [MyDictionaryTable] (Word, WordTranslation)
VALUES (@Word, @WordTranslation);
COMMIT TRANSACTION
END
GO

PRINT N'Creating MyDictionaryDB.uspSelectWord...'
GO
CREATE PROCEDURE [MyDictionaryDB].[uspSelectWord]
AS
BEGIN
BEGIN TRANSACTION
SELECT Word, IsWritten
FROM [MyDictionaryTable]
COMMIT TRANSACTION
END
GO

PRINT N'Creating MyDictionaryDB.uspSelectCurrentItem...'
GO
CREATE PROCEDURE [MyDictionaryDB].[uspSelectCurrentItem]
(
	@Word NVARCHAR(40)
)
AS
BEGIN
BEGIN TRANSACTION
SELECT Word, WordTranslation, IsWritten
FROM [MyDictionaryTable]
WHERE Word = @Word
COMMIT TRANSACTION
END
GO

PRINT N'Creating MyDictionaryDB.uspUpdateItem...'
GO
CREATE PROCEDURE [MyDictionaryDB].[uspUpdateItem]
(
	@Word NVARCHAR(40)
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [MyDictionaryTable]
SET [IsWritten] = 1
WHERE Word = @Word
COMMIT TRANSACTION
END
GO

PRINT N'cREATING MyDictionaryDB.uspEditItem...'
GO
CREATE PROCEDURE [MyDictionaryDB].[uspEditItem]
(
	@Word NVARCHAR(40),
	@WordTranslation NVARCHAR(MAX),
	@CurrentWord NVARCHAR(40)
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [MyDictionaryTable]
SET [Word] = @Word, [WordTranslation] = @WordTranslation, [IsWritten] = 0
WHERE Word = @CurrentWord
COMMIT TRANSACTION
END
GO

PRINT N'Creating MyDictionaryDB.uspDeleteItem...'
GO
CREATE PROCEDURE [MyDictionaryDB].[uspDeleteItem]
(
	@Word NVARCHAR(40)
)
AS
BEGIN
BEGIN TRANSACTION
DELETE FROM [MyDictionaryTable]
WHERE Word = @Word
COMMIT TRANSACTION
END
GO

--ALTER TABLE [MyDictionaryTable]
--DROP CONSTRAINT PK__MyDictio__95B50109C48A94D3
--GO

ALTER TABLE [MyDictionaryTable]
ADD UNIQUE ([Word])
GO