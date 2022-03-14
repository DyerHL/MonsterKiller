using MonsterKiller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKiller.Models
{
    public class Ghoul: IAllergicToSilver, IDrownable
    {
        public void Stab(string attack)
        {
            if (attack == "Sword")
            {
                Console.WriteLine("You just killed the Ghoul with silver.");
            }
        }

        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed the Ghoul with Holy Water.");
            }
        }

    }
}
