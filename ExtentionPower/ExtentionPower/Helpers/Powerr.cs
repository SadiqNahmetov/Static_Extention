using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionPower.Helpers
{
    public static class Powerr
    {
        public static int Power(this int num1, int num2)
        {
            return (int) Math.Pow(num1, num2);
        }
    }
}
