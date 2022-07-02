using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("ContentTypes")]
    public sealed class ContentType
    {
        /// <summary>Идентификатор содержимого.</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>Название типа содержимого.</summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>Уникальный код типа содержимого.</summary>
        [Required]
        [Index(IsUnique = true)]
        public int UniqueCode { get; set; }
    }
}