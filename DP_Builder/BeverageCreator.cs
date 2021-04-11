using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Builder
{
    class BeverageCreator
    {
        IBeverageBuilder BeverageBuilder = null;
        public BeverageCreator(IBeverageBuilder Beverage)
        {
            BeverageBuilder = Beverage;
        }

        public IBeverageBuilder CreateBeverage(int Sugar, int Water, int Powder, String PowderType, int Milk)
        {
            BeverageBuilder.AddWater(Water);
            BeverageBuilder.AddPowder(Powder);
            BeverageBuilder.AddSugar(Sugar);
            BeverageBuilder.AddMilk(Milk);

            return BeverageBuilder;
        }
    }
}
