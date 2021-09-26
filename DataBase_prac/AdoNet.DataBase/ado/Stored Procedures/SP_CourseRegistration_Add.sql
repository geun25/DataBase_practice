CREATE PROCEDURE [dbo].[SP_CourseRegistration_Add]
	@StudentId int,
	@SubjectId int,
	@RegistedDate datetime
AS
	INSERT INTO
		TB_CourseRegistration
		(
			StudentId,
			SubjectId,
			RegisterDate
		)
	VALUES
		(
			@StudentId,
			@SubjectId,
			@RegistedDate
		)
	
