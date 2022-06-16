namespace CodoPolygon.DAL.ViewModels
{
    public sealed class ArticleViewModel
    {
        /// <summary>Идентификатор статьи.</summary>
        public int Id { get; set; }
        /// <summary>Латинское название статьи для поискового пути.</summary>
        public string LatShortName { get; set; }
        /// <summary>Название статьи.</summary>
        public string Name { get; set; }
        /// <summary>Описание статьи.</summary>
        public string Description { get; set; }
        /// <summary>Указвает опубликована ли статья.</summary>
        public bool IsPublished { get; set; }
    }
}