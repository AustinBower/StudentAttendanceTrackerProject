CREATE INDEX [StudentIndex]
	ON [dbo].[Student]
	(StudentID)

/*
SELECT Student.StudenID, Class.ClassName, Student.Attendance
FROM Student
INNER JOIN Class
ON Student.ClassID=Class.ClassID;
*/