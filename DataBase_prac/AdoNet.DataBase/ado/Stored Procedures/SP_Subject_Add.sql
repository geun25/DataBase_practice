CREATE PROCEDURE [dbo].[SP_Subject_Add]
	@SubjectName varchar(50)
AS
	INSERT INTO
		TB_Subject
		(
			SubjectName
		)
	VALUES
		(
			@SubjectName
		)
	RETURN SCOPE_IDENTITY()