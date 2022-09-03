using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai1
{
    public class DeQuy
    {
       
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
        }
    }
}
