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
    }

    public class FizzBuzz {
        public string Calculate(int value) {
            if (value%3 == 0) return "Fizz";
            return value.ToString();
        }
    }
}
