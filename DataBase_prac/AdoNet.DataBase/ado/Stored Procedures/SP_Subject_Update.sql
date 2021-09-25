CREATE PROCEDURE [dbo].[SP_Subject_Update]
	@SubjectId int,
	@SubjectName varchar(50)
AS
	UPDATE
		TB_Subject
	SET
		SubjectName = @SubjectName
	WHERE
		SubjectId = @SubjectId