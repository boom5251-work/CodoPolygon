using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("Chapters")]
    public sealed class Chapter
    {
        /// <summary>Идентификатор главы.</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>Идентификатор статьи, к которой пренадлежит глава.</summary>
        [Required]
        public int ArticleId { get; set; }

        /// <summary>Название главы.</summary>
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>Порядковый номер главы.</summary>
        [Required]
        public int SequenceNumber { get; set; }

        [ForeignKey(nameof(ArticleId))]
        internal Article Article { get; set; }
    }
}