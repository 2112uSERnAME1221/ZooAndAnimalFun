using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Venue
    {
      [Key]
      public int VenueID { get; set; }
     
      [Required]
      public string VenueName { get; set; }
      
      public int Capacity { get; set; }
    }
}
