using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Weapon
    {

        public string Name { get; set; }
        public float Caliber { get; set; }
        public double Range { get; set; }

        public Weapon(string name, float caliber, double range)
        {
            Name = name;
            Caliber = caliber;
            Range = range;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("АК-47", 14.2f, 14.1d);
            

            Console.WriteLine(weapon.Name);
            Console.WriteLine(weapon.Caliber);
            Console.WriteLine(weapon.Range);
        }
    }

    
}
