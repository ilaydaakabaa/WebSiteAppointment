using System.ComponentModel.DataAnnotations;

namespace emergencyProject.Models
{
    public class EmergencyNews
    {
        [Key]
        public int EmergencyNewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime NewsDateTime { get; set; }
        public bool IsSent { get; set; } = false;
    }
}
