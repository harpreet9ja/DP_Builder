using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Builder
{
    //Product Creation
    class Coffee : IBeverageBuilder
    {
        Beverage CoffeeBeverage = new Beverage();

        void IBeverageBuilder.AddMilk(int Milk)
        {
            CoffeeBeverage.Milk = Milk;
            Console.WriteLine("Milk Added"+" Quantity :"+ CoffeeBeverage.Milk);
        }

        void IBeverageBuilder.AddPowder(int Powder)
        {
            CoffeeBeverage.Powder = Powder;
            Console.WriteLine("Powder Added" + " Quantity :" + CoffeeBeverage.Powder);
        }

        void IBeverageBuilder.AddSugar(int Sugar)
        {
            CoffeeBeverage.Sugar = Sugar;
            Console.WriteLine("Sugar Added" + " Quantity :" + CoffeeBeverage.Sugar);
        }

        void IBeverageBuilder.AddWater(int Water)
        {
            CoffeeBeverage.Water = Water;
            Console.WriteLine("Water Added" + " Quantity :" + CoffeeBeverage.Water);
        }


       
    }
}
