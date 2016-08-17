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
            if (value.IsDivisibleBy(3) && value.IsDivisibleBy(5)) return "FizzBuzz";
            if (value.IsDivisibleBy(3)) return "Fizz";
            if (value.IsDivisibleBy(5)) return "Buzz";
            return value.ToString();
        }
    }

    public static class IntegerExtensions {
        public static bool IsDivisibleBy(this int value, int divisor) {
            return value%divisor == 0;
        }
    }
}
