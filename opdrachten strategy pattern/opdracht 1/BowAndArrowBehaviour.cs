using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with the bow...");
        }
    }
}
