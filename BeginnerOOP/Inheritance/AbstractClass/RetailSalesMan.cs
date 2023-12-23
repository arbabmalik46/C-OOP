using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerOOP
{
    class RetailSalesMan : SalesMan
    {
        public RetailSalesMan(string fname, string lname) : base(fname, lname)
        { }
        public override void SaleCar()
        { Console.WriteLine("Hi my name is {0} and I will sell you this Porsche 911", FullName); }
        public override void Sold()
        { Console.WriteLine("Please ask salesman to name the price of the car"); }
    }
}
