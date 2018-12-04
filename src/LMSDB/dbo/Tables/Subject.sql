CREATE TABLE [dbo].[Subject] (
    [id_subject]        INT        NOT NULL IDENTITY,
    [name]              NCHAR (10) NOT NULL,
    [id_parent_subject] INT        NULL,
    CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED ([id_subject] ASC),
    CONSTRAINT [FK_Subject_Subject] FOREIGN KEY ([id_parent_subject]) REFERENCES [dbo].[Subject] ([id_subject])
);

