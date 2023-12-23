using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerOOP
{
    class CarSalesMan : SalesMan, Manager
    {
        public CarSalesMan(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public string GetDescription()
        {
            return "I am the most senior office here. How can I help you?";
        }

        public override void SaleCar()
        {
            Console.WriteLine("Hi my name is {0} and I will sell you this Lamborghini Urus", FullName);
        }
    }
}