using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooAndAnimalFun.Models
{
    public class TicketSales
    {
      [Key]
      public string TicketID { get; set; }

      [Range(1, 100)]
      [DataType(DataType.Currency)]
      [Column(TypeName = "decimal(18, 2)")]
      public double Price { get; set; }
        
      [Display(Name = "Date Sold")]
      [DataType(DataType.Date)]
      public DateTime DateSold { get; set;  }

      [Display(Name = "When Available")]
      [DataType(DataType.Date)]
      public DateTime ApplicableFor { get; set; }

      [Required]
      public string CustomerID { get; set; }
      public virtual required Customer Customer { get; set; }

      [Required]
      public string TicketTypeID { get; set; }
      public virtual required TicketType TicketType { get; set; }

      [Required]
      public string SessionID { get; set; }
      public virtual required Session Session { get; set; }
    }
}
