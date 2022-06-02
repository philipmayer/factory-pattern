using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class Shield : Item
    {
        //Properties
        public int defenseValue { get; set; }
        //Methods
        public override void UseItem()
        {
            Console.WriteLine("Shield used");
        }
    }
}
