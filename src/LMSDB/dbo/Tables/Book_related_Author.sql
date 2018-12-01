CREATE TABLE [dbo].[Book_related_Author] (
    [id_book]   INT NOT NULL,
    [id_author] INT NOT NULL,
    CONSTRAINT [PK_Book_related_Author] PRIMARY KEY CLUSTERED ([id_book] ASC, [id_author] ASC),
    CONSTRAINT [FK_Book_related_Author_Author] FOREIGN KEY ([id_author]) REFERENCES [dbo].[Author] ([id_author]),
    CONSTRAINT [FK_Book_related_Author_Book] FOREIGN KEY ([id_book]) REFERENCES [dbo].[Book] ([id_book_isbn])
);

