using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public abstract class Car
    {

        public Car()
        {
        }

        protected abstract Engine produceEngine();

        public void start()
        {
            Engine engine = produceEngine();
            engine.Start();
        }
    }
}
