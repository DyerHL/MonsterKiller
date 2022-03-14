using MonsterKiller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKiller.Models
{
    public class Vampire: ICombustable, IAllergicToSilver
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Vampire with fire.");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Sword")
            {
                Console.WriteLine("You just killed the Vampire with silver.");
            }
        }
    }
}
