CREATE TABLE [dbo].[Roles] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [RoleName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_dbo.Roles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

