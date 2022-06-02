using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class RandomItem : ItemFactory
    {
        protected override Item GenerateItem()
        {
            var random = new Random();

            Item[] items = { new Hammer(), new Shield() };

            int itemIndex = random.Next(0, items.Length);

            return items[itemIndex];
        }
    }
}
