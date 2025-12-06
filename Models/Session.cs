using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Session
    {
      [Key]
      public string SessionID { get; set; }
      [Required]
      public string EventID { get; set; }
      public virtual required Event Event { get; set; }

      [Required]
      public string VenueID { get; set; }
      public virtual required Venue Venue { get; set; }

      [Required]
      public string TicketID { get; set; }
      public virtual required TicketSales TicketSales { get; set; }
    }
}
