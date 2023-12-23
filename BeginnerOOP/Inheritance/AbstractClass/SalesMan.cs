using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerOOP
{
    public abstract class SalesMan
    {
        private string _lastName;
        private string _firstName;
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", _firstName, _lastName);
            }
        }
        public SalesMan(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public abstract void SaleCar();

        /// <summary>
        /// This method shows if car is sold or not
        /// </summary>
        /// <returns>Consoles a new line on terminal</returns>
        public virtual void Sold()
        {
            Console.WriteLine("This car has been sold");
        }
    }
}
