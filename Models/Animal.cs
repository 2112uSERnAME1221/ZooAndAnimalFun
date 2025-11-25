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

      
      public int SpeciesID { get; set; }

      [Range(0.01, double.MaxValue)]
      [Column(TypeName = "decimal(18, 2)")]
      public double Weight { get; set; }


      [ForeignKey("GenderID")]
      public int GenderID { get; set; }
      
      public virtual Gender Gender { get; set; }
     
      public int HealthStatusID { get; set; }
    }
}


