CREATE PROCEDURE dbo.CreateUser
(
	@User dbo.UDT_Users READONLY
)
AS
BEGIN
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	
	DECLARE @InsertedObjects UDT_Users

	BEGIN
		INSERT INTO dbo.User
		OUTPUT INSERTED INTO @InsertedObjects 
		SELECT * 
		FROM @User
	END

	SELECT *
	FROM @InsertedObjects

END