/*
AdoNetWindow의 배포 스크립트

이 코드는 도구를 사용하여 생성되었습니다.
파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
변경 내용이 손실됩니다.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "AdoNetWindow"
:setvar DefaultFilePrefix "AdoNetWindow"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
SQLCMD 모드가 지원되지 않으면 SQLCMD 모드를 검색하고 스크립트를 실행하지 않습니다.
SQLCMD 모드를 설정한 후에 이 스크립트를 다시 사용하려면 다음을 실행합니다.
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'이 스크립트를 실행하려면 SQLCMD 모드를 사용하도록 설정해야 합니다.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'다음 작업이 리팩터링 로그 파일 e0b51939-c85a-4fba-9507-124fdbc7dfe4에서 생성되었습니다.';

PRINT N'[dbo].[TB_CourseRegistration].[RegisterDate]에서 RegistedDate(으)로 이름 바꾸기';


GO
EXECUTE sp_rename @objname = N'[dbo].[TB_CourseRegistration].[RegisterDate]', @newname = N'RegistedDate', @objtype = N'COLUMN';


GO
PRINT N'프로시저 [dbo].[SP_Student_Add]을(를) 변경하는 중...';


GO
ALTER PROCEDURE [dbo].[SP_Student_Add]
	@StudentName varchar(50),
	@Address varchar(200)
AS
	INSERT INTO
		TB_Student
		(
			StudentName,
			Address
		)
	VALUES
		(
			@StudentName,
			@Address
		)
	RETURN SCOPE_IDENTITY()
GO
PRINT N'프로시저 [dbo].[SP_Subject_Add]을(를) 변경하는 중...';


GO
ALTER PROCEDURE [dbo].[SP_Subject_Add]
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
GO
PRINT N'프로시저 [dbo].[SP_CourseRegistration_Add]을(를) 만드는 중...';


GO
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
			RegistedDate
		)
	VALUES
		(
			@StudentId,
			@SubjectId,
			@RegistedDate
		)
GO
PRINT N'프로시저 [dbo].[SP_CourseRegistration_Delete]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_CourseRegistration_Delete]
	@StudentId int,
	@SubjectId int
AS
	DELETE
		TB_CourseRegistration
	WHERE
		StudentId = @StudentId AND
		SubjectId = @SubjectId
GO
PRINT N'프로시저 [dbo].[SP_CourseRegistration_GetByUser]을(를) 만드는 중...';


GO
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
GO
PRINT N'프로시저 [dbo].[SP_CourseRegistration_Update]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_CourseRegistration_Update]
	@StudentId int,
	@SubjectId int,
	@NewSubjectId int,
	@RegistedDate datetime
AS
	UPDATE
		TB_CourseRegistration
	SET
		SubjectId = @NewSubjectid,
		RegistedDate = @RegistedDate
	WHERE
		StudentId = @StudentId AND
		SubjectId = @SubjectId
GO
-- 배포된 트랜잭션 로그를 사용하여 대상 서버를 업데이트하는 리팩터링 단계
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e0b51939-c85a-4fba-9507-124fdbc7dfe4')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e0b51939-c85a-4fba-9507-124fdbc7dfe4')

GO

GO
PRINT N'업데이트가 완료되었습니다.';


GO
