CREATE TABLE [dbo].[TB_Subject]
(
	[SubjectId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [SubjectName] VARCHAR(50) NOT NULL UNIQUE
)
