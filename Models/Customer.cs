using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Customer
    {
      [Key]
      public string CustomerID { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [MaxLength(50)]
      [MinLength(2)]
      public string FirstName { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [MaxLength(50)]
      [MinLength(2)]
      public string LastName { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
      [Required]
      [StringLength(100)]
      public string Address1 { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
      [StringLength(100)]
      public string? Address2 { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [Required]
      [StringLength(50)]
      public string City{ get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [Required]
      [StringLength(15)]
      public string State { get; set; }

      [RegularExpression(@"^[0-9]{5}$")]
      [Required]
      public string ZIP { get; set; }

      [RegularExpression(@"^[0-9]{10}$")]
      [Required]
      public string Phone{ get; set; }

      [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
      [Required]
      public string Email { get; set; }
    }
}
