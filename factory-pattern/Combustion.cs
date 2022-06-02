using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class Combustion : Engine
    {
        public Combustion(string name, int horsePower) : base(name, horsePower) { }
        public override void Start()
        {
            Console.WriteLine("COMBUSTION");
        }
    }
}
