using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class Hydrogen : Engine
    {
        public Hydrogen(string type, int horsePower) : base(type, horsePower) { }

        public override void Start()
        {
            Console.WriteLine("HYDROGEN");
        }
    }
}
