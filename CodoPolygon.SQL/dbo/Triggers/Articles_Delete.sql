CREATE TRIGGER [Articles_Delete]
	ON [dbo].[Articles]
	AFTER DELETE

	AS
	BEGIN
		SET NOCOUNT ON

		DELETE [dbo].[Chapters]
		WHERE ArticleId IN (SELECT Id FROM deleted)

		DELETE [dbo].[UsersArticles]
		WHERE ArticleId IN (SELECT Id FROM deleted)
	END
