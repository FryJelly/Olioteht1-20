using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Order
    {
        public string OrderID { get; set; }
        public DateTime Date { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order(string orderID, DateTime date)
        {
            OrderID = orderID;
            Date = date;
            this.OrderItems = new List<OrderItem>();
        }
        public void ShowOrderItems()
        {
            foreach (OrderItem n in OrderItems)
            {
                Console.WriteLine();
            }
        }

    }
}
