using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Employee
    {
      [Key]
      public string EmployeeID { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [MaxLength(50)]
      [MinLength(2)]
      public string FirstName { get; set; }

      [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
      [MaxLength(50)]
      [MinLength(2)]
      public string LastName { get; set; }

    }
}
