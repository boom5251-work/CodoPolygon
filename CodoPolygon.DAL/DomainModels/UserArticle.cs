using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("UsersArticles")]
    public sealed class UserArticle
    {
        /// <summary>Идентификатор статьи пользователя.</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>Идентификатор пользователя.</summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>Идентификатор статьи.</summary>
        [Required]
        public int ArticleId { get; set; }

        [ForeignKey(nameof(UserId))]
        internal User User { get; set; }

        [ForeignKey(nameof(ArticleId))]
        internal Article Article { get; set; }
    }
}