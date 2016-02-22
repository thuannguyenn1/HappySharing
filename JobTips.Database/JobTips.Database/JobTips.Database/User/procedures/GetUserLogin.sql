CREATE PROCEDURE dbo.GetUserLogin
(
	@UserName NVARCHAR(50),
	@Password NVARCHAR(50)
)
AS
BEGIN

	SELECT us.Id AS UserId
		, us.UserName
		, us.PasswordHash AS Password
		, us.Address
		, us.PhoneNumber
	FROM Users us
	WHERE us.UserName = @UserName
		AND us.PasswordHash = @Password

END