using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Venue
    {
      [Key]
      public string VenueID { get; set; }
     
      [Required]
      public string VenueName { get; set; }
      
      public int Capacity { get; set; }

      public string EventID { get; set; }
      public virtual required Event Event { get; set; }
    }
}
