using CalculatorSample.Logic.Logger;
using System;
using System.IO;

namespace CalculatorSample.Logic
{
    public class Calculator : FindNumberByBit
    {
        private ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Add(int x, int y)
        {
            _logger.Log($"Operation Sum: x={x}, y={y}");
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            _logger.Log($"Operation Diff: x={x}, y={y}");
            return x - y;
        }

        public int Division(int x, int y)
        {
            _logger.Log($"Operation Division: x={x}, y={y}");
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
            _logger.Log($"Operation Multiply: x={x}, y={y}");
            return x * y;
        }

        public int Raising(int x, int y)
        {
            _logger.Log($"Operation Raising: x={x}, y={y}");
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
