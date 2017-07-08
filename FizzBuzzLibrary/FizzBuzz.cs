using System;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public string Calculate(Range<int> range, List<FizzBuzzNumber> fizzBuzzNumbers)
        {
            var counter = range.Minimum;

            var stringBuilder = new StringBuilder();

            while (counter <= range.Maximum)
            {
                stringBuilder.Append(counter);

                foreach (var fizzBuzzNumber in fizzBuzzNumbers)
                {
                    stringBuilder.Append(GetWordToDisplay(counter, fizzBuzzNumber));
                }

                stringBuilder.Append("\r\n");
                counter++;
            }

            return stringBuilder.ToString();
        }

        public string GetWordToDisplay(int numberToDivide, FizzBuzzNumber fizzBuzzNumber)
        {
            if (IsDivisibleByNumber(numberToDivide, fizzBuzzNumber.Divisor))
            {
                return fizzBuzzNumber.Message;
            }
            return string.Empty;
        }

        public bool IsDivisibleByNumber(int numberToDivide, int divisor)
        {
            return numberToDivide % divisor == 0;
        }
    }
}
