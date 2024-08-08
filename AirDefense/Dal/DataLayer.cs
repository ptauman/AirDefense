using Microsoft.EntityFrameworkCore;
using System;
using AirDefense.Models;

namespace AirDefense.Dal
{
    // מחלקת מסד הנתונים שיורשת ממחלקה מובנית
    public class DataLayer : DbContext
    {
        public DataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
        {
            // לוודא שנוצר מסד הנתונים על בסיס מחרוזת החיבור
            Database.EnsureCreated();
            Seed();
        }
        // יצירת רשומה בודדת בטבלה לצורך הדגמה
        private void Seed()
        {
            // בדיקה שהטבלה הייתה ריקה
            if (Countryes.Any() || Defense_Missiles.Any() || Threats.Any() || Weapons.Any()) return;
            
            Country country = new Country{Name = "Iran", Distance = 1800};
            Countryes.Add(country);

            // הכנסת עשרים טילי הגנה
            for(int i = 0; i < 20; i++)
            {
                Defense_Missile defense_Missile = new Defense_Missile();
                Defense_Missiles.Add(defense_Missile);
            }
            
            Weapon weapon = new Weapon{Name = "טיל בליסטי", Speed = 16000};
            Weapons.Add(weapon);

            Threat threat = new Threat(country, weapon);
            Threats.Add(threat);
            // שמירת השינויים
            SaveChanges();
        }
        // מחזיר אובייקט שמאפשר חיבור לשרת ה sql שהולך למחלקה המורישה למחלקה זאת 
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
        }

        // משתנה שמחזיק את רשומות הטבלה של חברים
        public DbSet<Country> Countryes { get; set; }
        public DbSet<Defense_Missile> Defense_Missiles { get; set; }       
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Threat> Threats { get; set; }





    }
}
