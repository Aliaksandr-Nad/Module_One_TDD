using System;
using System.Linq;

namespace CalculatorSample.Logic
{
    public class FindNumberByBit
    {
        public Array SearchNumbers(int sum, int range)
        {
            int maxRang = (int)Math.Pow(10, range);

            if ( range < 0 || sum < 0)
            {
                throw new ArgumentOutOfRangeException("Not valid variables");
            }

            var result =
                from num in Enumerable.Range(0, maxRang)
                where SumByBit(num) == sum
                select num;

            if (result.Count().Equals(0))
            {
                return new int[] { };
            }
            var answer = new int[] {result.Count(), result.Min(), result.Max() };
            return answer;
        }

        private int SumByBit (int a)
        {
            int sum = 0;
            string number = a.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse((number[i]).ToString());
            }

            return sum;
        }
    }
}
