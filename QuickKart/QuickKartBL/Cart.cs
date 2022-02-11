using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Cart
    {
        readonly string[] Items;
        public Cart()
        {
            Items = new string[3];
            Items[0] = "Apple iPhone 6 Plus";
            Items[1] = "HTC One M9";
            Items[2] = "Microsoft Lumia 950";
        }
        public void DisplayItems()
        {
            int index = 0;
            int numberOfItems = this.Items.Length;
            while (index < numberOfItems)
            {
                Console.WriteLine(this.Items[index]);
                index += 1;
            }
        }
    }
}
