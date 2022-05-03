using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("Users")]
    public sealed class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MinLength(1), MaxLength(50)]
        public string LastName { get; set; }

        [Required, MinLength(5), MaxLength(320)]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        internal UserRole Role { get; set; }

        [NotMapped]
        public Base.UserRole UserRole => (Base.UserRole)RoleId;
    }
}