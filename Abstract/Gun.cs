using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Gun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Granat");
        }
    }
    class LaserGun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Lazer");
        }
    }
}
