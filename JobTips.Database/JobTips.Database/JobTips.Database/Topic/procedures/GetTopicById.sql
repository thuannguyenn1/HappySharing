CREATE PROCEDURE dbo.GetTopicById
(
	@TopicId INT
)
AS
BEGIN
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	
	SELECT  t.Id
		, t.IsActive
		, t.Rating
		, t.TopicBody
		, t.TopicFooter
		, t.TopicTitle
		, t.UserId
		, t.Views
	FROM   dbo.Topics t
	WHERE t.Id = @TopicId
END