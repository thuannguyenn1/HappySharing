CREATE PROCEDURE dbo.DeleteTopic
(
	@TopicIds dbo.UDT_Ids READONLY
)
AS
BEGIN
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

	UPDATE dbo.Topics
	SET IsActive = 0
	WHERE  Id IN (SELECT Id FROM @TopicIds)

END