CREATE PROCEDURE [dbo].[SP_Student_UpdateName]
	@StudentId int,
	@StudentName varchar(50)
AS
	UPDATE
		TB_Student
	SET
		StudentName = @StudentName
	WHERE
		StudentId = @StudentId