using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Species
    {
      [Key]
      public int SpeciesID { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [MaxLength(50)]
      [MinLength(2)]
      public string SpeciesName { get; set; }

     [Required]
     public int CategoryID { get; set; }
     public virtual required Category Category { get; set; }
    }
}
