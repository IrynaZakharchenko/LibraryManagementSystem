CREATE TABLE [dbo].[Account] (
    [id_account]       INT           NOT NULL,
    [id_personal_info] INT           NOT NULL,
    [login]            NVARCHAR (15) NOT NULL,
    [password]         NVARCHAR (30) NOT NULL,
    [id_position]      INT           NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([id_account] ASC),
    CONSTRAINT [FK_Account_Person] FOREIGN KEY ([id_personal_info]) REFERENCES [dbo].[Person] ([id_person]),
    CONSTRAINT [FK_Account_Position] FOREIGN KEY ([id_position]) REFERENCES [dbo].[Position] ([id_position])
);

