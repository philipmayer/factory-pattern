using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class ElectricCar : Car
    {
        public ElectricCar() : base() { }
        protected override Engine produceEngine()
        {
            return new Electric("electric", 300);
        }
    }
}
