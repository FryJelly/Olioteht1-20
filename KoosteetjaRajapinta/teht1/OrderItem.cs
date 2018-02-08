using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class OrderItem
    {
        public string ItemName { get; set; }
        public int Count { get; set; }

        public OrderItem(string itemName, int count)
        {
            ItemName = itemName;
            Count = count;
        }
    }
}
