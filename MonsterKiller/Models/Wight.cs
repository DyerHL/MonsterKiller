using MonsterKiller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKiller.Models
{
    public class Wight: IAllergicToSilver
    {
        public void Stab(string attack)
        {
            if (attack == "Sword")
            {
                Console.WriteLine("You just killed the Wight with silver.");
            }
            else
            {
                Console.WriteLine("Your attack had no effect.");
            }
        }
    }
}
