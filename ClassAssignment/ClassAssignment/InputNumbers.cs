using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class InputNumbers
    {
        public int Exponentals(int num1, int num2 = 23)
        {
            double productD = Math.Pow(num1, num2);
            int product = Convert.ToInt32(productD);
            return product;
        }
    }
}
