CREATE TABLE [dbo].[UsersArticles] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [UserId]    INT NOT NULL,
    [ArticleId] INT NOT NULL,
    CONSTRAINT [PK_dbo.UsersArticles] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.UsersArticles_dbo.Articles_ArticleId] FOREIGN KEY ([ArticleId]) REFERENCES [dbo].[Articles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.UsersArticles_dbo.Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[UsersArticles]([UserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ArticleId]
    ON [dbo].[UsersArticles]([ArticleId] ASC);

