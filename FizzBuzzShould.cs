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
        public void return_the_same_number(int value, string expectedResult) => 
            fizzBuzz.Calculate(value).Should().Be(expectedResult);
    }

    public class FizzBuzz {
        public string Calculate(int value) {
            if (IsFizzBuzz(value)) return "FizzBuzz";
            if (IsFizz(value)) return "Fizz";
            if (IsBuzz(value)) return "Buzz";
            return value.ToString();
        }

        private static bool IsBuzz(int value) => value.IsDivisibleBy(5);

        private static bool IsFizz(int value) => value.IsDivisibleBy(3);

        private static bool IsFizzBuzz(int value) => IsFizz(value) && IsBuzz(value);
    }

    public static class IntegerExtensions {
        public static bool IsDivisibleBy(this int value, int divisor) => value%divisor == 0;
    }
}
