CREATE TABLE student
(
	[StudentID] INT NOT NULL PRIMARY KEY, 
	[StudentNumber] INT NOT NULL,
    [StudentName] NCHAR(10) NOT NULL, 
    [Attendance] INT NULL, 
    [Gender] NCHAR(10) NULL, 
    [Email] NCHAR(10) NULL, 
    [Phone] NCHAR(10) NULL, 
    [Address] NCHAR(10) NULL, 
    [ClassID] NCHAR(10) NOT NULL
)