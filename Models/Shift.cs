using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }

        public int AssistantId { get; set; }
        public Assistant Assistant { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public DateTime ShiftDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
