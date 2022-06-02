using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public abstract class ItemFactory
    {

        protected abstract Item GenerateItem();

        public Item DropItem() {
            return GenerateItem();
        }
    }
}
