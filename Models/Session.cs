using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Session
    {
      [Key]
      public int SessionID { get; set; }
      public string TicketID { get; set; }
      public string EventID { get; set; }
      public string VenueID { get; set; }
    }
}
