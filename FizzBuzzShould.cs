using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzShould {
        private readonly FizzBuzz fizzBuzz;

        public FizzBuzzShould() {
            fizzBuzz = new FizzBuzz();
        }
        [Fact]
        public void return_the_same_number() {
            fizzBuzz.Calculate(1).Should().Be("1");
        }

        [Fact]
        public void return_fizz_if_is_divisible_by_three() {
            fizzBuzz.Calculate(3).Should().Be("Fizz");
        }

        [Fact]
        public void return_buzz_if_is_divisible_by_five()
        {
            fizzBuzz.Calculate(5).Should().Be("Buzz");
        }

        [Fact]
        public void return_fizzbuzz_if_is_divisible_by_three_and_five()
        {
            fizzBuzz.Calculate(15).Should().Be("FizzBuzz");
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
