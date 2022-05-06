CREATE TABLE [dbo].[ContentTypes] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_dbo.ContentTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

