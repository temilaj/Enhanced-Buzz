using System;
using System.Collections.Generic;
using FizzBuzzLibrary;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzNumbers = new List<FizzBuzzNumber>()
            {
                new FizzBuzzNumber() { Divisor = 4, Message = "Divisible by 4!" },
                new FizzBuzzNumber() { Divisor = 5, Message = "Divisible by 5!" }
            };

            var range = new Range<int>()
            {
                Minimum = 15,
                Maximum = 55
            };

            var fizzBuzz = new FizzBuzz();

            Console.Write(fizzBuzz.Calculate(range, fizzBuzzNumbers));
        }
    }
}
