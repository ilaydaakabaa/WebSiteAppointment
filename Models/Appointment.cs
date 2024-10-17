using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public int AssistantId { get; set; }
        public Assistant Assistant { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; } = "Bekliyor";
    }
}
