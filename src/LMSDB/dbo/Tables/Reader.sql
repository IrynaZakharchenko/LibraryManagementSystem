CREATE TABLE [dbo].[Reader] (
    [id_reader_ticket] INT NOT NULL,
    [id_personal_info] INT NOT NULL,
    CONSTRAINT [PK_Reader] PRIMARY KEY CLUSTERED ([id_reader_ticket] ASC),
    CONSTRAINT [FK_Reader_Person] FOREIGN KEY ([id_personal_info]) REFERENCES [dbo].[Person] ([id_person])
);

