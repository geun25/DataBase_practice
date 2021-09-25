CREATE PROCEDURE [dbo].[SP_Subject_GetAll]
AS
SET NOCOUNT ON
	SELECT
		SubjectId,
		SubjectName
	FROM
		TB_Subject
	ORDER BY
		SubjectName