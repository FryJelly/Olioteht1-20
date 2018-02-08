using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name)
        {
            Name = name;
            this.Orders = new List<Order>();
        }
        public void ShowOrders()
        {
            Console.WriteLine(Name);
            foreach (Order i in Orders)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }
}
