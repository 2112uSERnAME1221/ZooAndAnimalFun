using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooAndAnimalFun.Models
{

    public class Animal
    {
      [Key]
      public int AnimalID { get; set; }

      [Required]
      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [StringLength(30)]
      public string Name { get; set; }

      [Range(0.01, double.MaxValue)]
      [Column(TypeName = "decimal(18, 2)")]
      public double Weight { get; set; }

      [Required]
      public int GenderID { get; set; }      
      public virtual required Gender Gender { get; set; }

      [Required]
      public int HealthStatusID { get; set; }
      public virtual required HealthStatus HealthStatus { get; set; }

      [Required]
      public int SpeciesID { get; set; }
      public virtual required Species Species { get; set; }
    }
}


