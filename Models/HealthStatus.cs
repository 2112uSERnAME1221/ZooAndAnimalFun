using System.ComponentModel.DataAnnotations;

namespace ZooAnimalList.Models
{
    public class HealthStatus
    {
        [Key]
        public int HealthStatusId { get; set; }

        
        [Required]
        public string HealthDescription { get; set; }
    }
}
