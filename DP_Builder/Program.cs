using System;

namespace DP_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Milk = 0;
            int Sugar = 0;
            int Water = 0;
            int Powder = 0;
            String PowderType = String.Empty;


            Console.WriteLine("Enter Milk:");
            Milk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Water:");
            Water = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Tea or Coffee:");
            PowderType = Console.ReadLine();

            Console.WriteLine("Enter Powder:");
            Powder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sugar:");
            Sugar = Convert.ToInt32(Console.ReadLine());

           

            if (PowderType.ToUpper().Equals("COFFEE"))
            {
                BeverageCreator Creator = new BeverageCreator(new Coffee());
                Creator.CreateBeverage(Sugar, Water, Powder, PowderType, Milk);
            }
            else if (PowderType.ToUpper().Equals("TEA"))
            {
                BeverageCreator Creator = new BeverageCreator(new Tea());
                Creator.CreateBeverage(Sugar, Water, Powder, PowderType, Milk);
                
            }
        }
    }
}
