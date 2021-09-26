CREATE PROCEDURE [dbo].[SP_CourseRegistration_Delete]
	@StudentId int,
	@SubjectId int
AS
	DELETE
		TB_CourseRegistration
	WHERE
		StudentId = @StudentId AND
		SubjectId = @SubjectId
