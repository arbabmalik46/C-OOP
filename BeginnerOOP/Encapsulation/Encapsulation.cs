using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerOOP
{
    public class Encapsulation
    {
        public int print() //this is public
        {
            return 1;
        }
        private string printLetter() //only in same class
        {
            return "This is private";
        }

        protected string printAlphabet() //only in same class or inherited class
        {
            return "this is protected";
        }
    }

    public class HelperClass : Encapsulation
    {
        public HelperClass()
        {
            Console.WriteLine(print());
            Console.WriteLine(printAlphabet());
            
        }
    }

    public abstract class HelperClass1 : Manager
    {
        public abstract string GetDescription();
    }

    public class HelperClass2 : HelperClass1
    {
        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }

}

