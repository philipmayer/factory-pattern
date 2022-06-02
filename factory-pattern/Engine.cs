using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public abstract class Engine
    {
        public Engine(string name, int horsePower) 
        {
            this.Name = name;
            this.HorsePower = horsePower;
        }

        public string Name { get; set; }

        public int HorsePower { get; set; }

        abstract public void Start();

    }
}
