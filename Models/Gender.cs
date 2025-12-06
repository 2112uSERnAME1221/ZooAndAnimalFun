using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Gender
    {
        [Key]
        public string GenderID { get; set;  }

        public string GenderName { get; set; }
    }
}
