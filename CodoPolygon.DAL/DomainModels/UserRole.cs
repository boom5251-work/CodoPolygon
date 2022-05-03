using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("Roles")]
    public sealed class UserRole
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string RoleName { get; set; }
    }
}