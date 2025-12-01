using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc
    {
        //Methods

        public decimal Addition(decimal num1, decimal num2)
        {
            decimal ans = num1 + num2;
            return ans;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            decimal ans = num1 - num2;
            return ans;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            decimal ans = num1 * num2;
            return ans;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            decimal ans = num1 / num2;
            return ans;
        }

    }
}
