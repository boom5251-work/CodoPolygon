using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("Articles")]
    public sealed class Article
    {
        /// <summary>Идентификатор статьи.</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>Название статьи.</summary>
        [Required, MinLength(5), MaxLength(100)]
        public string Name { get; set; }
        /// <summary>Описание статьи.</summary>
        [MaxLength(300)]
        public string Description { get; set; }
    }
}