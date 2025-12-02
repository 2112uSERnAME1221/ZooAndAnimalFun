using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Session
    {
      [Key]
      public int SessionID { get; set; }

      [Required]
      public int TicketID { get; set; }
      public virtual required TicketType TicketType { get; set; }

      [Required]
      public int EventID { get; set; }
      public virtual required Event Event { get; set; }

      [Required]
      public int VenueID { get; set; }
      public virtual required Venue Venue { get; set; }
    }
}
