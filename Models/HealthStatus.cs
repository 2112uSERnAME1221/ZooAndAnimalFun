using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class HealthStatus
    {
        [Key]
        public string HealthStatusId { get; set; }

        
        [Required]
        public string HealthDescription { get; set; }
    }
}
