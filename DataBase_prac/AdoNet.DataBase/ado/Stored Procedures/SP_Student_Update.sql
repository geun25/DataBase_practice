CREATE PROCEDURE [dbo].[SP_Student_Update]
	@StudentId int,
	@StudentName varchar(50),
	@Address varchar(200)
AS
	UPDATE
		TB_Student
	SET
		StudentName = @StudentName,
		Address = @Address
	WHERE
		StudentId = @StudentId
