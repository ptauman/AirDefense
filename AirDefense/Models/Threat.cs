using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirDefense.Models
{
    public class Threat
    {
        [Key]
        public int Id { get; set; }

        public Country country { get; set; }

        public Weapon weapon { get; set; }

        public int ResponseTime { get; set; }

        public string status { get; set; }

        public Threat(Country country, Weapon weapon)
        {
            this.country = country;
            this.weapon = weapon;
            this.ResponseTime = (country.Distance / weapon.Speed) * 60;
            this.status = "action";
        }
    }
}
