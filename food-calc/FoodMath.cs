using System;

namespace FoodCalc
{
    public class FoodMath
    {
        public static decimal toPound(decimal Amount){
            return Amount * Convert.ToDecimal(0.00220462);
        }

    }
}
