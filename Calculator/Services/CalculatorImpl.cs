using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class CalculatorImpl
    {
        public float Sum(float num1, float num2) { return num1 + num2; }

        public float Subtract(float num1, float num2) { return num1 - num2; }

        public float Multiply(float num1, float num2) { return num1 * num2; }

        public float Divide(float num1, float num2) { return num1 / num2; }

        public bool IsEven(float num) { return num % 2 == 0; }
    }
}
