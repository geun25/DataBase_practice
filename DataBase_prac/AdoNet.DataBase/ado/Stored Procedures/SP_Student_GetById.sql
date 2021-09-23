CREATE PROCEDURE [dbo].[SP_Student_GetById]
	@StudentID int
AS
	SELECT 
		StudentId,
		StudentName,
		Address
	FROM
		TB_Student
	WHERE
		StudentId = @StudentId
		
