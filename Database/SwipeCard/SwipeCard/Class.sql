CREATE TABLE [dbo].[Classes]
(
	[ClassID] INT NOT NULL PRIMARY KEY, 
    [Class Name] NCHAR(10) NOT NULL, 
    [ClassDate] DATE NULL, 
    [ClassTime] DATETIME NULL, 
    [ProfessorID] NCHAR(10) NOT NULL
)
