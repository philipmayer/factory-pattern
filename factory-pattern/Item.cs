using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public abstract class Item
    {
        //Properties
        public string Name { get; set; }
        public string Id { get; set; }

        //Methods
        abstract public void UseItem();
    }
}
