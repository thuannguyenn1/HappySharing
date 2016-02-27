CREATE TYPE UDT_Topics AS TABLE
(
    [Id]          INT            NULL,
    [TopicTitle]  NVARCHAR (100) NULL,
    [Views]       INT            NULL,
    [Rating]      DECIMAL (18)   NULL,
    [UserId]      INT            NULL,
    [IsActive]    BIT            NULL,
    [Inserted]    DATETIME       NULL,
    [Updated]     DATETIME       NULL,
    [TopicBody]   NVARCHAR (MAX) NULL,
    [TopicFooter] NVARCHAR (200) NULL
)