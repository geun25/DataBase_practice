CREATE PROCEDURE [dbo].[SP_CourseRegistration_GetByUser]
	@StudentId int
AS
	SELECT
		a.StudentId,
		b.StudentName,
		a.SubjectId,
		c.SubjectName,
		a.RegistedDate
	FROM
		TB_CourseRegistration a
	INNER JOIN
		TB_Student b
	ON
		a.StudentId = b.StudentId
	INNER JOIN
		TB_Subject c
	ON
		a.SubjectId = c.SubjectId
	WHERE
		a.StudentId = @StudentId



		