CREATE TABLE [dbo].[Author] (
    [id_author] INT          NOT NULL IDENTITY,
    [Name]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED ([id_author] ASC)
);

