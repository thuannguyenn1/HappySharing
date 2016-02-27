CREATE PROCEDURE dbo.GetTopicsByIndex
(
	@Index INT,
	@NumberPerPage INT,
	@IsActive BIT
)
AS
BEGIN
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	
	DECLARE @StartRow INT
	SET @StartRow = (@Index * @NumberPerPage)

	SELECT  t.Id
		, t.IsActive
		, t.Rating
		, t.TopicBody
		, t.TopicFooter
		, t.TopicTitle
		, t.UserId
		, t.Views
	FROM    dbo.Topics t
	ORDER BY t.Id ASC 
	OFFSET  @StartRow ROWS 
	FETCH NEXT @NumberPerPage ROWS ONLY 

	SELECT COUNT(Id) AS NumberOfTopic
	FROM dbo.Topics
END