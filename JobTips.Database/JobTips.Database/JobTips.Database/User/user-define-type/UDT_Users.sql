CREATE TYPE UDT_Users AS TABLE
(
    [Id]         INT            NULL,
    [FirstName]  NVARCHAR (100)  NULL,
    [LastName]   NVARCHAR (100)  NULL,
    [Email]      NVARCHAR (256)  NULL,
    [Birthday]   Date            NULL,
	[PasswordHash] NVARCHAR (MAX)NULL,
	[ActiveCode]  NVARCHAR (MAX) NULL,
	[PhoneNumber] NVARCHAR (50)  NULL,
	[Address]     NVARCHAR (100) NULL,
	[Sex]         BIT            NULL,
    [IsActive]    BIT            NULL,
	[IsDeleted]   BIT            NULL,
    [Inserted]    DATETIME       NULL,
	[UserName]    NVARCHAR (30)  NULL,
    [Updated]     DATETIME       NULL
    
)