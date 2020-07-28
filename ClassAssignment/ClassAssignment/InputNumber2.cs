using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class InputNumber2
    {
        public int TimesFive(int num)
        {
            int product = num * 5;
            return product;
        }

        public int TimesFive(decimal num)
        {
            decimal productD = num * 5;
            int product = Convert.ToInt32(productD);
            return product;
        }

        public int TimesFive(string numS)
        {
            
            try
            {
                int num = Convert.ToInt32(numS);
                int product = num * 5;
                return product;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
        }

        public int Number { get; set; }
    }
}
