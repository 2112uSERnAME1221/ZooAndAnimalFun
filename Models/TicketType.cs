using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class TicketType
    {
      [Key]
      public int TicketTypeID { get; set;}

      [Required]
      public string TicketTypeName { get; set; }
    }
}
