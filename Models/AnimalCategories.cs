using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class AnimalCategories
    {
     [Key]
     public string CategoryID { get; set; }

     [Required]
     [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
     [StringLength(30)]
     public string CategoryName { get; set; }
    }
}
