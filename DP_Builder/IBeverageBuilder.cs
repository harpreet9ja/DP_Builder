using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Builder
{
    interface IBeverageBuilder
    {
        public void AddWater(int Water);
        public void AddMilk(int Milk);
        public void AddPowder(int Powder);
        public void AddSugar(int Sugar);
      
    }
}
