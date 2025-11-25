using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class EventCategory
    {
      [Key]
      public int EventCategoryID{ get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [Required]
      [StringLength(30)]
      public string EventCategoryName{ get; set; }


      public bool AvailableToCustomers{ get; set; }
    }
}
