using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class HydrogenCar : Car
    {
        public HydrogenCar() : base(){ }

        protected override Engine produceEngine()
        {
            return new Hydrogen("hydrogen", 200);
        }
    }
}
