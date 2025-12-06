using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Species
    {
      [Key]
      public string SpeciesID { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [MaxLength(50)]
      [MinLength(2)]
      public string SpeciesName { get; set; }

     [Required]
     public string EventCategoryID { get; set; }
     public virtual required EventCategory EventCategory { get; set; }
    }
}
