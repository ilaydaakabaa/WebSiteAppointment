using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        [RegularExpression(@"^\S*$", ErrorMessage = "Şifre boşluk içeremez.")]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email giriniz.")]
        public string Email { get; set; }
        [Required]
 
        public RoleType Role { get; set; } // Enum kullanımı
    }
}
