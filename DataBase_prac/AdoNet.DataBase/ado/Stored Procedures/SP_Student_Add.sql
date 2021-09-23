CREATE PROCEDURE [dbo].[SP_Student_Add]
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