using MonsterKiller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKiller.Models
{
    public class Demon: IDrownable, IAllergicToSilver, ICombustable
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed the Demon with Holy Water.");
            }
        }

        public void Stab(string attack)
        {
            if (attack == "Sword")
            {
                Console.WriteLine("You just killed the Demon with silver.");
            }
        }

        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Demon with fire");
            }
        }
    }
}
