CREATE TABLE [dbo].[TB_CourseRegistration]
(
	[StudentId] INT NOT NULL , 
    [SubjectId] INT NOT NULL, 
    [RegisterDate] DATE NOT NULL, 
    CONSTRAINT [PK_TB_CourseRegistration] PRIMARY KEY ([StudentId], [SubjectId]), 
    CONSTRAINT [FK_TB_CourseRegistration_TB_Student] FOREIGN KEY ([StudentId]) REFERENCES [TB_Student]([StudentId]),
    CONSTRAINT [FK_TB_CourseRegistration_TB_Subject] FOREIGN KEY ([SubjectId]) REFERENCES [TB_Subject]([SubjectId])

)
