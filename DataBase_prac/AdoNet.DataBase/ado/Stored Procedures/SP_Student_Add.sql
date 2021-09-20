CREATE PROCEDURE [dbo].[SP_Student_Add]
	@StudentName varchar(50),
	@Address varchar(200)
AS
	INSERT INTO
		TB_Student
		(
			StudentName,
			Address
		)
	Values
		(
			@StudentName,
			@Address
		)
