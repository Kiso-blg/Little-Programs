PRINT N'Creating MyDictionaryDatabase...'
GO
CREATE SCHEMA [MyDictionaryDatabase]
GO

PRINT N'Creating MyDictionaryTable...'
GO
CREATE TABLE [MyDictionaryTable] (
	[Word] NVARCHAR(40) PRIMARY KEY NOT NULL,
	[WordTranslation] NVARCHAR(MAX) NOT NULL,
	[IsWritten] BIT NOT NULL DEFAULT(0)
);

PRINT N'Creating MyDictionaryDatabase.uspAddItem...'
GO
CREATE PROCEDURE [MyDictionaryDatabase].[uspAddItem]
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

PRINT N'Creating MyDictionaryDatabase.uspSelectWord...'
GO
CREATE PROCEDURE [MyDictionaryDatabase].[uspSelectWord]
AS
BEGIN
BEGIN TRANSACTION
SELECT Word, IsWritten
FROM [MyDictionaryTable]
COMMIT TRANSACTION
END
GO

PRINT N'Creating MyDictionaryDatabase.uspSelectCurrentItem...'
GO
CREATE PROCEDURE [MyDictionaryDatabase].[uspSelectCurrentItem]
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

PRINT N'Creating MyDictionaryDatabase.uspUpdateItem...'
GO
CREATE PROCEDURE [MyDictionaryDatabase].[uspUpdateItem]
(
	@Word NVARCHAR(40)
)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [MyDictionaryTable]
SET [IsWritten] = 1
WHERE Word = '@Word'
COMMIT TRANSACTION
END
GO

PRINT N'cREATING MyDictionaryDatabase.uspEditItem...'
GO
CREATE PROCEDURE [MyDictionaryDatabase].[uspEditItem]
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

PRINT N'Creating MyDictionaryDatabase.uspDeleteItem...'
GO
CREATE PROCEDURE [MyDictionaryDatabase].[uspDeleteItem]
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