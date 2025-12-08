using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Event
    {
      [Key]
      public string EventId { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [Required]
      [StringLength(30)]
      public string EventName { get; set; }

      [Display(Name = "Event Start")]
      [DataType(DataType.Date)]
      public DateTime EventStart { get; set; }

      [Display(Name = "Event End")]
      [DataType(DataType.Date)]
      public DateTime EventEnd { get; set; }

      [Required]
      public string EventCategoryID { get; set; }
      [DeleteBehavior(DeleteBehavior.NoAction)]
      public virtual required EventCategory EventCategory { get; set; }

      [Required]
      public string AnimalID { get; set; }
      public virtual required Animal Animal { get; set; }
    }
}
