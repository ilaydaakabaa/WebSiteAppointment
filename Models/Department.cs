using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PatientCapacity { get; set; }
        public int EmptyBeds { get; set; }

        public ICollection<Shift> Shifts { get; set; }
    }
}
