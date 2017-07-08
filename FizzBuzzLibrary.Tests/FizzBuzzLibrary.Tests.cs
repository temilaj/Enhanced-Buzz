using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzzLibrary.Tests
{
    public class FizzBuzzLibraryTests
    {
        [Theory]
        [InlineData(50, 5)]
        [InlineData(6, 2)]
        [InlineData(10, 5)]
        [InlineData(6, 1)]
        public void IsDivisibleByNumber_GivenDivisibleNumbers_ReturnsTrue(int numberToDivide, int divisor)
        {
            //arrange
            var fizzBuzz = new FizzBuzz();

            //act
            var divisible = fizzBuzz.IsDivisibleByNumber(numberToDivide, divisor);

            //assert
            Assert.True(divisible);
        }

        [Theory]
        [InlineData(13, 7)]
        [InlineData(3, 4)]
        [InlineData(40, 19)]
        public void IsDivisibleByNumber_GivenIndivisibleNumbers_ReturnsFalse(int numberToDivide, int divisor)
        {
            //arrange
            var fizzBuzz = new FizzBuzz();

            //act
            var divisible = fizzBuzz.IsDivisibleByNumber(numberToDivide, divisor);

            //assert
            Assert.False(divisible);
        }

        [Fact]
        public void Calculate_GivenRangeOf5_Outputs5Lines()
        {
            var fizzBuzz = new FizzBuzz();
            var range = new Range<int>() { Minimum = 8, Maximum = 15 };

            var result = fizzBuzz.Calculate(range, new List<FizzBuzzNumberConfiguration>());
            var lineCount = LineCount(result);

            Assert.Equal(lineCount, 8);
        }

        [Fact]
        public void GetWordToDisplay_GivenDivisibleNumber_ReturnsAssociatedWord()
        {
            var fizzBuzz = new FizzBuzz();
            const string MessageForNumbersDivisibleByFive = "Divisible by five";
            var fizzBuzzNumber = new FizzBuzzNumberConfiguration() { Divisor = 5, Message = MessageForNumbersDivisibleByFive };
            var wordToDisplay = fizzBuzz.GetWordToDisplay(15, fizzBuzzNumber);

            Assert.Equal(MessageForNumbersDivisibleByFive, wordToDisplay);
        }

        [Fact]
        public void GetWordToDisplay_GivenIndivisibleNumber_ReturnsEmptyString()
        {
            var fizzBuzz = new FizzBuzz();
            const string wordToDisplayForNumbersDivisibleByFive = "Divisible by five";
            var numberConfig = new FizzBuzzNumberConfiguration() { Divisor = 5, Message = wordToDisplayForNumbersDivisibleByFive };

            var wordToDisplay = fizzBuzz.GetWordToDisplay(13, numberConfig);

            Assert.Empty(wordToDisplay);
        }

        [Fact]
        public void Calcuate_GivenTwoFizzBuzzNumbers_ReturnsExpectedResult()
        {
            const string messageFor5 = "Nice! Hai Fivez!";
            const string messageFor7 = "Lucky Number Se7en";

            var fizzBuzzNumbers = new List<FizzBuzzNumberConfiguration>()
            {
                new FizzBuzzNumberConfiguration() { Divisor = 5, Message = messageFor5 },
                new FizzBuzzNumberConfiguration() { Divisor = 7, Message = messageFor7 }
            };

            var range = new Range<int>() { Minimum = 5, Maximum = 10 };

            const string expectedResult = "5" + messageFor5 + "\r\n6\r\n7" + messageFor7 + "\r\n8\r\n9\r\n10" + messageFor5 + "\r\n";
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Calculate(range, fizzBuzzNumbers);

            Assert.Equal(result, expectedResult);
        }

        #region Helpers
        private long LineCount(string s)
        {
            long count = 0;
            int position = 0;
            while ((position = s.IndexOf('\n', position)) != -1)
            {
                count++;
                position++;         
            }
            return count;
        }
        #endregion


    }
}
