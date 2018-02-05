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
        string ShowTransaction()
        {
            Console.WriteLine("Paid with cash:")
        }
        float GetAmount()
        {
            
        }
        public float ShowCash()
        {
            
        }
    }
}
