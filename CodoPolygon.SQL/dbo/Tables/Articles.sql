CREATE TABLE [dbo].[Articles] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (300) NULL,
    CONSTRAINT [PK_dbo.Articles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

