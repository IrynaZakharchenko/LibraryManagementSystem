CREATE TABLE [dbo].[Instance] (
    [id_book_inventory_num] INT NOT NULL,
    [id_book_isbn]          INT NOT NULL,
    CONSTRAINT [PK_Instance] PRIMARY KEY CLUSTERED ([id_book_inventory_num] ASC),
    CONSTRAINT [FK_Instance_Book] FOREIGN KEY ([id_book_isbn]) REFERENCES [dbo].[Book] ([id_book_isbn])
);

