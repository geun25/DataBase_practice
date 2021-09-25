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
PRINT N'테이블 [dbo].[TB_Student]을(를) 변경하는 중...';


GO
ALTER TABLE [dbo].[TB_Student] ALTER COLUMN [Address] VARCHAR (200) NULL;


GO
PRINT N'프로시저 [dbo].[SP_Student_Add]을(를) 변경하는 중...';


GO
ALTER PROCEDURE [dbo].[SP_Student_Add]
	@StudentName varchar(50),
	@Address varchar(200)
AS
	INSERT
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
PRINT N'프로시저 [dbo].[SP_Student_Delete]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_Student_Delete]
	@StudentId int
AS
	DELETE
		TB_Student
	WHERE
		StudentId = @StudentId
GO
PRINT N'프로시저 [dbo].[SP_Student_GetAll]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_Student_GetAll]
AS
	SELECT 
		StudentId,
		StudentName,
		Address
	FROM
		TB_Student
	ORDER BY
		StudentName
GO
PRINT N'프로시저 [dbo].[SP_Student_GetById]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_Student_GetById]
	@StudentID int
AS
	SELECT 
		StudentId,
		StudentName,
		Address
	FROM
		TB_Student
	WHERE
		StudentId = @StudentId
GO
PRINT N'프로시저 [dbo].[SP_Student_Update]을(를) 만드는 중...';


GO
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
GO
PRINT N'프로시저 [dbo].[SP_Student_UpdateName]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_Student_UpdateName]
	@StudentId int,
	@StudentName varchar(50)
AS
	UPDATE
		TB_Student
	SET
		StudentName = @StudentName
	WHERE
		StudentId = @StudentId
GO
PRINT N'프로시저 [dbo].[SP_Subject_Add]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_Subject_Add]
	@SubjectName varchar(50)
AS
	INSERT
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
PRINT N'프로시저 [dbo].[SP_Subject_Delete]을(를) 만드는 중...';


GO
CREATE PROCEDURE [dbo].[SP_Subject_Delete]
	@SubjectId int
AS
	DELETE
		TB_Subject
	WHERE
		SubjectId = @SubjectId
GO
PRINT N'프로시저 [dbo].[SP_Subject_GetAll]을(를) 만드는 중...';


GO
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
GO
PRINT N'프로시저 [dbo].[SP_Subject_GetById]을(를) 만드는 중...';


GO
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
GO
PRINT N'프로시저 [dbo].[SP_Subject_Update]을(를) 만드는 중...';


GO
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
GO
PRINT N'업데이트가 완료되었습니다.';


GO
