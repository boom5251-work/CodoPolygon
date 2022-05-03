using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("UsersArticles")]
    public sealed class UserArticle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [Required]
        public int ArticleId { get; set; }

        [ForeignKey(nameof(UserId))]
        internal User User { get; set; }
        [ForeignKey(nameof(ArticleId))]
        internal Article Article { get; set; }
    }
}