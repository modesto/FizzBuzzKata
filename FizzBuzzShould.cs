using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzShould {
        private readonly FizzBuzz fizzBuzz;

        public FizzBuzzShould() {
            fizzBuzz = new FizzBuzz();
        }
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(15, "FizzBuzz")]
        public void return_the_same_number(int value, string expectedResult) {
            fizzBuzz.Calculate(value).Should().Be(expectedResult);
        }
    }

    public class FizzBuzz {
        public string Calculate(int value) {
            if (value%3 == 0 && value%5 == 0) return "FizzBuzz";
            if (value%3 == 0) return "Fizz";
            if (value%5 == 0) return "Buzz";
            return value.ToString();
        }
    }
}
