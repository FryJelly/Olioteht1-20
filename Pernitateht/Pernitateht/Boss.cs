using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pernitateht
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss()
        {

        }

        public Boss(string firstName, string lastName, string Profession, int Salary, string car, int bonus)
            : base(firstName,lastName)
        {
            Car = car;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
        }


    }
}
