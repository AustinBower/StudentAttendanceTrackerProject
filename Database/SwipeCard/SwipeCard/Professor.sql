CREATE TABLE [dbo].[Professor]
(
	[ProfessorID] INT NOT NULL PRIMARY KEY, 
    [ProfessorName] NCHAR(10) NOT NULL, 
    [Password] NCHAR(10) NOT NULL, 
    [Department] NCHAR(10) NULL, 
	[Gender] NCHAR(10) NULL, 
    [Email] NCHAR(10) NULL, 
    [Phone] INT NULL, 
    [Address] NCHAR(10) NULL
)
