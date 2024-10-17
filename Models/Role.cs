using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public RoleType RoleType { get; set; } // Enum ile ilişkilendirme

        [Required(ErrorMessage = "Rol başlığı gereklidir.")]
        public string Title { get; set; } // Rol başlığı

        public ICollection<User> Users { get; set; } // Kullanıcı ile ilişki
    }
}
