using System.ComponentModel.DataAnnotations ;
namespace AirDefense.Models
{
    public class Weapon
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "שם הכלי")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "מהירות")]
        public int Speed { get; set; }
    }
}
