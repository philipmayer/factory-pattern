using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class Hammer : Item
    {
        //Properties
        public int attackValue { get; set; }
        public override void UseItem()
        {
            Console.WriteLine("Hammer used");
        }
    }
}
