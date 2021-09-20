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
PRINT N'키가 c0c1d37d-d54f-41fa-8a32-418b159d1b38인 이름 바꾸기 리팩터링 작업을 건너뜁니다. 요소 [dbo].[TB_Subject].[Id](SqlSimpleColumn)의 이름이 SubjectId(으)로 바뀌지 않습니다.';


GO
PRINT N'키가 83bdd263-4095-4262-90a4-21a60463af37인 이름 바꾸기 리팩터링 작업을 건너뜁니다. 요소 [dbo].[TB_CourseRegistration].[Id](SqlSimpleColumn)의 이름이 StudentId(으)로 바뀌지 않습니다.';


GO
PRINT N'키가 628c708f-5bd4-46d5-be72-72e622da2f3c인 이름 바꾸기 리팩터링 작업을 건너뜁니다. 요소 [dbo].[TB_CourseRegistration].[SUbjectId](SqlSimpleColumn)의 이름이 SubjectId(으)로 바뀌지 않습니다.';


GO
PRINT N'테이블 [dbo].[TB_CourseRegistration]을(를) 만드는 중...';


GO
CREATE TABLE [dbo].[TB_CourseRegistration] (
    [StudentId]    INT  NOT NULL,
    [SubjectId]    INT  NOT NULL,
    [RegisterDate] DATE NOT NULL,
    CONSTRAINT [PK_TB_CourseRegistration] PRIMARY KEY CLUSTERED ([StudentId] ASC, [SubjectId] ASC)
);


GO
PRINT N'테이블 [dbo].[TB_Subject]을(를) 만드는 중...';


GO
CREATE TABLE [dbo].[TB_Subject] (
    [SubjectId]   INT          IDENTITY (1, 1) NOT NULL,
    [SubjectName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([SubjectId] ASC),
    UNIQUE NONCLUSTERED ([SubjectName] ASC)
);


GO
PRINT N'외래 키 [dbo].[FK_TB_CourseRegistration_TB_Student]을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[TB_CourseRegistration] WITH NOCHECK
    ADD CONSTRAINT [FK_TB_CourseRegistration_TB_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[TB_Student] ([StudentId]);


GO
PRINT N'외래 키 [dbo].[FK_TB_CourseRegistration_TB_Subject]을(를) 만드는 중...';


GO
ALTER TABLE [dbo].[TB_CourseRegistration] WITH NOCHECK
    ADD CONSTRAINT [FK_TB_CourseRegistration_TB_Subject] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[TB_Subject] ([SubjectId]);


GO
-- 배포된 트랜잭션 로그를 사용하여 대상 서버를 업데이트하는 리팩터링 단계
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'c0c1d37d-d54f-41fa-8a32-418b159d1b38')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('c0c1d37d-d54f-41fa-8a32-418b159d1b38')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '83bdd263-4095-4262-90a4-21a60463af37')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('83bdd263-4095-4262-90a4-21a60463af37')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '628c708f-5bd4-46d5-be72-72e622da2f3c')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('628c708f-5bd4-46d5-be72-72e622da2f3c')

GO

GO
PRINT N'새로 만든 제약 조건에 대해 기존 데이터를 검사하는 중입니다.';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[TB_CourseRegistration] WITH CHECK CHECK CONSTRAINT [FK_TB_CourseRegistration_TB_Student];

ALTER TABLE [dbo].[TB_CourseRegistration] WITH CHECK CHECK CONSTRAINT [FK_TB_CourseRegistration_TB_Subject];


GO
PRINT N'업데이트가 완료되었습니다.';


GO
