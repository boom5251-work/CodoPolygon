using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("Roles")]
    public sealed class UserRole
    {
        /// <summary>Идентификатор роли.</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>Название роли.</summary>
        [Required, MaxLength(50)]
        public string RoleName { get; set; }

        /// <summary>Уникальный код роли.</summary>
        [Required]
        [Index(IsUnique = true)]
        public int UniqueCode { get; set; }
    }
}