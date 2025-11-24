using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooAnimalList.Models
{
    public class TicketSales
    {
      [Key]
      public int TicketID { get; set; }

      [Range(1, 100)]
      [DataType(DataType.Currency)]
      [Column(TypeName = "decimal(18, 2)")]
      public double Price { get; set; }

      public int CustomerID { get; set; }
        
      [Display(Name = "Date Sold")]
      [DataType(DataType.Date)]
      public DateTime DateSold { get; set;  }

      [Display(Name = "When Available")]
      [DataType(DataType.Date)]
      public DateTime AppliciableFor { get; set; }

      public int TicketTypeID { get; set; }
      public int SessionID { get; set; }
    }
}
