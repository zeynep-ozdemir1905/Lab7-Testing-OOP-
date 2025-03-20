using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathLibrary
{
    public class BasicMath
    {
        /* Creates double arguments and returns corresponding operation result */
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            return (b == 0) ? 0 : a / b;  
        }
    }
}
