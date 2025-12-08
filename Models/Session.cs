using Microsoft.EntityFrameworkCore;
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
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual required Venue Venue { get; set; }

        public virtual ICollection<TicketSales> TicketSales { get; set; } = new List<TicketSales>();
    }
}
