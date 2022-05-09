CREATE TRIGGER [Chapters_Delete]
	ON [dbo].[Chapters]
	AFTER DELETE

	AS
	BEGIN
		SET NOCOUNT ON

		DELETE [dbo].[ContentItems]
		WHERE ChapterId IN (SELECT Id FROM deleted)
	END
