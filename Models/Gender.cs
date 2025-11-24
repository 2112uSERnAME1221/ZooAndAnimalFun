using System.ComponentModel.DataAnnotations;

namespace ZooAndAnimalFun.Models
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set;  }

        public string GenderName { get; set; }
    }
}
