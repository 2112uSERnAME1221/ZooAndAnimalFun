using System.ComponentModel.DataAnnotations;

namespace ZooAnimalList.Models
{
    public class Event
    {
      [Key]
      public int    EventId { get; set; }

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

      public int EventCategoryID { get; set; }

      public int AnimalID { get; set; }
    }
}
