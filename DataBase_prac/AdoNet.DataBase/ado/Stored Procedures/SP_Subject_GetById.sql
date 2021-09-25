CREATE PROCEDURE [dbo].[SP_Subject_GetById]
	@SubjectId int
AS
	SELECT
		SubjectId,
		SubjectName
	FROM
		TB_Subject
	WHERE
		SubjectId = @SubjectId