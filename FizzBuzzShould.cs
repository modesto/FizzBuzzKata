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
    }

    public class FizzBuzz {
        public string Calculate(int value) {
            return value.ToString();
        }
    }
}
