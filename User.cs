using System.ComponentModel.DataAnnotations;

namespace PizzaOrderApp.Models
{
    public class User
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, 120)]
        public int Age { get; set; }
    }
}