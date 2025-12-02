using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Event
    {
      [Key]
      public int EventId { get; set; }

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
      public int EventCategoryID { get; set; }
      public virtual required EventCategory EventCategory { get; set; }

      [Required]
      public int AnimalID { get; set; }
      public virtual required Animal Animal { get; set; }
    }
}
