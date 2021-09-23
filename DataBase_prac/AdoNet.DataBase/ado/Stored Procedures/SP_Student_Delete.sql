CREATE PROCEDURE [dbo].[SP_Student_Delete]
	@StudentId int
AS
	DELETE
		TB_Student
	WHERE
		StudentId = @StudentId