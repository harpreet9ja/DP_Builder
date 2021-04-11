using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Builder
{
    //Product Representation 
    class Beverage
    {
        public int Sugar { get; set; }
        public int Water { get; set; }
        public string PowderType { get; set; }
        public int Powder { get; set; }
        public int Milk { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Sugar :" + Sugar + " Water :" + Water + " Powder :" + Powder + " Milk :" + Milk);
        }

    }
}
