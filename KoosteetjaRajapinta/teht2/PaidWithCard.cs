using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class PaidWithCard : ITransaction
    {
        public float Amount { get; set; }
        public string Card { get; set; }
        public float TotalCard;
        public DateTime Date;
        public string ShowTransaction()
        {
            Console.WriteLine("Transaction to bank: charge from card " + Card + " date " + Date + " amount " + Amount);
            return "shown";
        }
        public float GetAmount()
        {
            float amount;
            Console.WriteLine("Enter payment with card: ");
            float.TryParse(Console.ReadLine(), out amount);
            Date = DateTime.Now;
            Console.WriteLine("Enter CardNumber (xxxx-xxxx): ");
            Card = Console.ReadLine();
            Amount = amount;
            TotalCard = Amount + TotalCard;
            return Amount;
        }
        public float ShowCard()
        {
            Console.WriteLine("Total money to our bank account: " + TotalCard);
            return TotalCard;
        }
    }
}
