using BeginnerOOP;
using ClaculationEngine;

namespace BasicOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Inheritance
            //string fullname;
            //RetailSalesMan harpareet = new RetailSalesMan("Harpareet","Kaur");
            //harpareet.SaleCar();
            //harpareet.Sold();
            //CarSalesMan erik = new CarSalesMan("Erik","Benjamin");
            //erik.SaleCar();
            //erik.Sold();
            //Console.WriteLine(erik.GetDescription());
            ////Console.Clear();
            //Calculate a = new Calculate();
            //a.ShowMagic();
            //ManagerLogic manager = new ManagerLogic();
            //Console.WriteLine(manager.GetDescription());
            #endregion

            #region Polymorphism
            StaticPolymorphism staticPolymorphism = new StaticPolymorphism();
            staticPolymorphism.printDevLang(null,"HTML");
            staticPolymorphism.printDevLang("C#");
            staticPolymorphism.printDevLang("C#","HTML");
            staticPolymorphism.printDevLang();
            #endregion
        }
    }
}