using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class SpecificItem : ItemFactory
    {
        protected int Index { get; set; }
        public SpecificItem(int index) : base()
        {
            this.Index = index;
        }
        protected override Item GenerateItem()
        {
            Item[] items = { new Hammer(), new Shield() };
            try
            {
                return items[this.Index];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of Range - chosing standard item", ex);
            }

            //If index out of range
            return new Shield();
        }
    }
}
