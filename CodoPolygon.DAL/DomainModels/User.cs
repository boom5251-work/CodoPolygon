using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodoPolygon.DAL.DomainModels
{
    [Table("Users")]
    public sealed class User
    {
        /// <summary>Идентификатор пользователя.</summary>
        [Key]
        public int Id { get; set; }

        /// <summary>Имя пользователя.</summary>
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>Фамилия пользователя.</summary>
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string LastName { get; set; }

        /// <summary>Электронный адрес пользователя.</summary>
        [Required]
        [MinLength(5)]
        [MaxLength(320)]
        public string Email { get; set; }

        /// <summary>Пароль пользователя.</summary>
        [Required]
        [MinLength(6)]
        [MaxLength(50)]
        public string Password { get; set; }

        /// <summary>Идентификатор роли пользователя.</summary>
        [Required]
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        internal UserRole Role { get; set; }
    }
}