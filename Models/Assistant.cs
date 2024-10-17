using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class Assistant
    {
        [Key]
        public int AssistantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string AssistantEmail { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }

        public ICollection<Shift> Shifts { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
