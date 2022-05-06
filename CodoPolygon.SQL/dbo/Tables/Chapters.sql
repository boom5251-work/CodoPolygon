CREATE TABLE [dbo].[Chapters] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [ArticleId]      INT            NOT NULL,
    [Name]           NVARCHAR (100) NOT NULL,
    [SequenceNumber] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Chapters] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Chapters_dbo.Articles_ArticleId] FOREIGN KEY ([ArticleId]) REFERENCES [dbo].[Articles] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ArticleId]
    ON [dbo].[Chapters]([ArticleId] ASC);

