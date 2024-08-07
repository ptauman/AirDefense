using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirDefense.Models
{
    public class Threats
    {
        [Key]
        public int Id { get; set; }

        public Country country { get; set; }

        public Weapon weapon { get; set; }

        public int ResponseTime { get; set; }

        public string statos { get; set; }

        public Threats(Country country, Weapon weapon)
        {
            this.country = country;
            this.weapon = weapon;
            this.ResponseTime = (country.Distance / weapon.Speed) * 60;
            this.statos = "action";
        }
    }
}
