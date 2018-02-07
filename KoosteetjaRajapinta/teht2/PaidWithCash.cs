using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class PaidWithCash : ITransaction
    {
        public float Register { get; set; }
        public float Amount { get; set; }
        public float TotalCash;
        private int BillNumber = 1;
        private DateTime Date;
        public string ShowTransaction()
        {
            Console.WriteLine("Paid with cash: billnumber " + BillNumber++ + " date: " + Date + " amount: " + Amount);
            return "shown";
        }
        public float GetAmount()
        {
            float amount;
            Console.WriteLine("Enter payment with cash: ");
            float.TryParse(Console.ReadLine(), out amount);
            Date = DateTime.Now;
            Amount = amount;
            TotalCash = Amount + TotalCash;
            return Amount;
        }
        public float ShowCash()
        {
            Console.WriteLine("Total cash in register: " + TotalCash);
            return TotalCash;
        }
    }
}
