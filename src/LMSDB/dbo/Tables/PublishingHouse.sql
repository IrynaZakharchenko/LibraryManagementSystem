CREATE TABLE [dbo].[PublishingHouse] (
    [id_publishing] INT            NOT NULL,
    [name]          NVARCHAR (100) NOT NULL,
    [location]      NVARCHAR (50)  NULL,
    [category]      NVARCHAR (30)  NULL,
    CONSTRAINT [PK_PublishingHouse] PRIMARY KEY CLUSTERED ([id_publishing] ASC)
);

