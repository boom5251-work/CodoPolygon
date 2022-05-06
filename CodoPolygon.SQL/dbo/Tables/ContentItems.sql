CREATE TABLE [dbo].[ContentItems] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [ChapterId]      INT            NOT NULL,
    [TypeId]         INT            NOT NULL,
    [Content]        NVARCHAR (MAX) NOT NULL,
    [SequenceNumber] INT            NOT NULL,
    CONSTRAINT [PK_dbo.ContentItems] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.ContentItems_dbo.Chapters_ChapterId] FOREIGN KEY ([ChapterId]) REFERENCES [dbo].[Chapters] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.ContentItems_dbo.ContentTypes_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[ContentTypes] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ChapterId]
    ON [dbo].[ContentItems]([ChapterId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_TypeId]
    ON [dbo].[ContentItems]([TypeId] ASC);

