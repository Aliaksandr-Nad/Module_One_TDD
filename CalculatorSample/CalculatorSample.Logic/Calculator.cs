using System;

namespace CalculatorSample.Logic
{
    public class Calculator
    {
        public int Add(int x, int y)
        {   
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        public int Division(int x, int y)
        {
            if (y.Equals(0))
            {
                return 0;
            }
            else
            {
                return x / y;
            }
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Raising(int x, int y)
        {
            if (y < 0)
            {
                return 0;
            }
            else
            {
                return (int)Math.Pow(x, y);
            }
            
        }
    }
}
