using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Invoice
    {
        public string Customer { get; set; }
        List<InvoiceItem> items = new List<InvoiceItem>();

        public string Total()
        {
            double sum = 0;
            foreach(InvoiceItem i in items)
            {
                sum = sum + i.Total();
            }
            return "Total : " + sum + " euros";
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Customer " + Customer + "'s invoice: ");
            Console.WriteLine("=======================================");
            foreach (InvoiceItem i in items)
            {
                Console.WriteLine(i.Name + "  " + i.Price + "e " + i.Quantity + " pieces " + i.Total() + "e total");
            }
            Console.WriteLine("=======================================");
            Console.WriteLine(Total());
        }

        public void CreateItems()
        {
            items.Add(new InvoiceItem("Milk", 1.75, 1));
            items.Add(new InvoiceItem("Beer", 5.25, 3));
            items.Add(new InvoiceItem("Butter", 2.50, 2));
        }
    }
}
