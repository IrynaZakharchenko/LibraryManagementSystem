CREATE TABLE [dbo].[Bibliography] (
    [id_bibliography_record] INT      NOT NULL IDENTITY,
    [id_reader_ticket]       INT      NOT NULL,
    [id_book_instance]       INT      NOT NULL,
    [give_date]              DATETIME NOT NULL,
    [get_date]               DATETIME NULL,
    CONSTRAINT [PK_Bibliography] PRIMARY KEY CLUSTERED ([id_bibliography_record] ASC),
    CONSTRAINT [FK_Bibliography_Instance] FOREIGN KEY ([id_book_instance]) REFERENCES [dbo].[Instance] ([id_book_inventory_num]),
    CONSTRAINT [FK_Bibliography_Reader] FOREIGN KEY ([id_reader_ticket]) REFERENCES [dbo].[Reader] ([id_reader_ticket])
);

