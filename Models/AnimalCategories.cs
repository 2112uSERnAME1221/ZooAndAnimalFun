using System.ComponentModel.DataAnnotations;

namespace ZooAnimalList.Models
{
    public class AnimalCategories
    {
     [Key]
     public int CategoryID { get; set;}

     [Required]
     [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
     [StringLength(30)]
     public string CategoryName { get; set; }
    }
}
