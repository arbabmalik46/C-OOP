using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerOOP
{
    class StaticPolymorphism
    {
        /// <summary>
        /// This method shows why polymorphism is necessary
        /// </summary>
        /// <param name="primaryLang">Primary Language</param>
        /// <param name="secondaryLang">Secondary Language</param>
        /// <returns>Prints a new line on console accroding to number of parameters</returns>
        public void printDevLang(string primaryLang = null,string secondaryLang = null)
        {
            if(primaryLang == null && secondaryLang == null)
            {
                Console.WriteLine("Kindly write some language");
            }
            else if(primaryLang != null && secondaryLang == null)
            {
                Console.WriteLine("You primary language is {0}",primaryLang);
            }
            else if (primaryLang == null && secondaryLang != null)
            {
                Console.WriteLine("You secondary language is {0}", secondaryLang);
            }
            else if (primaryLang != null && secondaryLang != null)
            {
                Console.WriteLine("You code in {0} and {1}", primaryLang,secondaryLang);
            }

        }
        public void printDevLanguage()
        {
            Console.WriteLine("Kindly write some language");
        }
        public void printDevLanguage(string primaryLanguage)
        {
            Console.WriteLine("You primary language is {0}", primaryLanguage);
        }
        public void printDevLanguage(string primaryLang, string secondaryLang)
        {
            Console.WriteLine("You code in {0} and {1}", primaryLang, secondaryLang);
        }
        public string printDevLanguage(string primaryLang, string secondaryLang,string lks)
        {
            Console.WriteLine("You code in {0} and {1}", primaryLang, secondaryLang);
            return "";    
        }
        public string printDevLanguage(string primaryLang, string secondaryLang, int numberoflanguages)
        {
            Console.WriteLine("You code in {0} and {1}", primaryLang, secondaryLang, numberoflanguages);
            return "";
        }
    }
}
