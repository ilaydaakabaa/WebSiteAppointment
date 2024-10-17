using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir email giriniz.")]
        public string ProfessorEmail { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
