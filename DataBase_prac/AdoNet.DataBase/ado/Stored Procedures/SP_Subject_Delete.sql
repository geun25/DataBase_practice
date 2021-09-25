CREATE PROCEDURE [dbo].[SP_Subject_Delete]
	@SubjectId int
AS
	DELETE
		TB_Subject
	WHERE
		SubjectId = @SubjectId