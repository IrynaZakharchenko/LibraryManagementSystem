CREATE TABLE [dbo].[Person] (
    [id_person] INT            NOT NULL,
    [full_name] NVARCHAR (50)  NOT NULL,
    [birthday]  DATE           NOT NULL,
    [address]   NVARCHAR (150) NULL,
    [phone]     NUMERIC (10)   NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([id_person] ASC)
);

