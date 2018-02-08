using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Test
    {
        public void TestCustomers()
        {
            Customer customer = new Customer("Peter");
            Order order1 = new Order("OR1", DateTime.Now.Date);
            customer.Orders.Add(order1);
            OrderItem item1 = new OrderItem("PC-Case", 20);
            order1.OrderItems.Add(item1);
            Order order2 = new Order("OR2", DateTime.Now.Date);
            customer.Orders.Add(order2);
            OrderItem item2 = new OrderItem("GPU", 12);
            order2.OrderItems.Add(item2);

            customer.ShowOrders();
            Console.WriteLine("Done");
        }
    }
}
