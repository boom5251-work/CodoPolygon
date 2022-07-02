using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("ContentItems")]
    public sealed class ContentItem
    {
        /// <summary>Идентификатор элемента содержимого.</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>Идентификатор главы, к которой принадлежит элемент содержимого.</summary>
        [Required]
        public int ChapterId { get; set; }
        /// <summary>Идентификатор типа элемента содержимого.</summary>
        [Required]
        public int TypeId { get; set; }

        /// <summary>Содержимое элемента.</summary>
        [Required]
        public string Content { get; set; }
        /// <summary>Порядковый номер элемента содержимого.</summary>
        [Required]
        public int SequenceNumber { get; set; }

        [ForeignKey(nameof(ChapterId))]
        internal Chapter Chapter { get; set; }
        [ForeignKey(nameof(TypeId))]
        internal ContentType Type { get; set; }
    }
}