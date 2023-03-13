using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Weapon
    {
        public string name;
        public float caliber;
        public double range;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            weapon.name = " ";
            weapon.caliber = 2.3f;
            weapon.range = 1.1d;

            Console.WriteLine(weapon.name);
            Console.WriteLine(weapon.caliber);
            Console.WriteLine(weapon.range);
        }
    }

    
}
