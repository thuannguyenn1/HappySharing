CREATE PROCEDURE dbo.SaveTopic
(
	@Topic dbo.UDT_Topics READONLY
)
AS
BEGIN
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

	DECLARE @InsertedObjects UDT_Topics


	IF(EXISTS(SELECT TOP 1 t.Id	FROM dbo.Topics t INNER JOIN @Topic t2 ON t2.Id = t.Id))
	BEGIN
		DELETE FROM dbo.Topics
		WHERE Id IN (
						SELECT t2.Id
						FROM @Topic t2
						)

		SET IDENTITY_INSERT dbo.Topic ON

		INSERT INTO dbo.Topic
		OUTPUT INSERTED INTO @InsertedObjects 
		SELECT * 
		FROM @Topic

		SET IDENTITY_INSERT dbo.Topic OFF
	END
	ELSE 
	BEGIN
		INSERT INTO dbo.Topic
		OUTPUT INSERTED INTO @InsertedObjects 
		SELECT * 
		FROM @Topic
	END

	SELECT *
	FROM @InsertedObjects

END