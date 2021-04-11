using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Builder
{
    //Product Creation
    class Tea : IBeverageBuilder
    {
        Beverage TeaBeverage = new Beverage();

        void IBeverageBuilder.AddMilk(int Milk)
        {
            TeaBeverage.Milk = Milk;
            Console.WriteLine("Milk Added" + " Quantity :" + TeaBeverage.Milk);
        }

        void IBeverageBuilder.AddPowder(int Powder)
        {
            TeaBeverage.Powder = Powder;
            Console.WriteLine("Powder Added" + " Quantity :" + TeaBeverage.Powder);
        }

        void IBeverageBuilder.AddSugar(int Sugar)
        {
            TeaBeverage.Sugar = Sugar;
            Console.WriteLine("Sugar Added" + " Quantity :" + TeaBeverage.Sugar);
        }

        void IBeverageBuilder.AddWater(int Water)
        {
            TeaBeverage.Water = Water;
            Console.WriteLine("Water Added" + " Quantity :" + TeaBeverage.Water);
        }



    }
}
