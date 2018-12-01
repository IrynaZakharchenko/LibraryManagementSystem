CREATE TABLE [dbo].[Book] (
    [id_book_isbn]  INT            NOT NULL,
    [title]         NVARCHAR (30)  NOT NULL,
    [full_title]    NVARCHAR (150) NULL,
    [is_eBook]      BIT            NOT NULL,
    [id_publishing] INT            NOT NULL,
    [language]      NVARCHAR (50)  NOT NULL,
    [date_publish]  DATE           NOT NULL,
    [book_series]   NVARCHAR (50)  NULL,
    [annotation]    NVARCHAR (256) NULL,
    [id_subject]    INT            NOT NULL,
    CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED ([id_book_isbn] ASC),
    CONSTRAINT [FK_Book_PublishingHouse] FOREIGN KEY ([id_publishing]) REFERENCES [dbo].[PublishingHouse] ([id_publishing]),
    CONSTRAINT [FK_Book_Subject] FOREIGN KEY ([id_subject]) REFERENCES [dbo].[Subject] ([id_subject])
);

