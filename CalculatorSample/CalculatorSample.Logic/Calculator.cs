namespace CalculatorSample.Logic
{
    class Calculator
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
            return x / y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Raising(int x, int y)
        {
            int _ = 0;

            for (int i = 0; i < y; i++)
            {
                _ = Multiply(x, x);
            }

            return _;
        }
    }
}
