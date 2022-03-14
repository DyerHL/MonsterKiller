using MonsterKiller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKiller.Models
{
    internal class Ghost: ICombustable, IDrownable
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Ghost with fire.");
            }
        }
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed the Ghost with Holy Water.");
            }
        }
    }
}
