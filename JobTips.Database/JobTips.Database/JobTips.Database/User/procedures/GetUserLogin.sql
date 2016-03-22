CREATE PROCEDURE dbo.GetUserLogin
(
	@UserName NVARCHAR(50),
	@Password NVARCHAR(MAX)
)
AS
BEGIN
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
	SELECT us.Id AS UserId
		, us.UserName
		, us.PasswordHash AS Password
		, us.Address
		, us.PhoneNumber
	FROM Users us
	WHERE us.UserName = @UserName
		AND us.PasswordHash = @Password

END