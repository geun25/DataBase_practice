CREATE PROCEDURE [dbo].[SP_Student_GetAll]
AS
	SELECT 
		StudentId,
		StudentName,
		Address
	FROM
		TB_Student
	ORDER BY
		StudentName
