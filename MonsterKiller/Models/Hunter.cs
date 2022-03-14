using MonsterKiller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKiller.Models
{
    public class Hunter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> Weapons { get; } = new List<string>() {
        "Silver", "Fire", "Holy Water"
    };

        public Hunter(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public void SplashWater(IDrownable enemy)
        {
            enemy.Douse("Holy Water");  // Kills with holy water
        }

        public void Ignite(ICombustable enemy)
        {
            enemy.Burn("Fire");  // Kills with fire
        }

        public void WieldSilver(IAllergicToSilver enemy)
        {
            enemy.Stab("Sword");   // Stabs with silver knife
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} kills monsters with the following weapons: {String.Join(", ", Weapons)}";
        }
    }
}
