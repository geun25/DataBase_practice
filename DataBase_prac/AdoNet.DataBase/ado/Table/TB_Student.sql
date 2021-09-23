CREATE TABLE [dbo].[TB_Student]
(
	[StudentId] INT NOT NULL IDENTITY(1,1) , 
    [StudentName] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(200) NULL, 
    CONSTRAINT [PK_TB_Student] PRIMARY KEY ([StudentId])
)
