using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirDefense.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Display(Name= "Country Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Country distance")]
        public int Distance {  get; set; }

    }

}
