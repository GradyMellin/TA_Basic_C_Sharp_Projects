using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class InputNumber
    {
        public int TimesTen()
        {
            int product = this.NumIn * 10;
            return product;
        }

        public int PlusFive()
        {
            int sum = this.NumIn + 5;
            return sum;
        }

        public int ModulesTwo()
        {
            int remainder = this.NumIn % 2;
            return remainder;
        }

        public int NumIn { get; set; }
    }
}
