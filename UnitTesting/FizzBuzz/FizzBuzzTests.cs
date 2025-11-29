namespace UnitTesting.FizzBuzz
{
    public class FizzBuzzTests
    {

        [SetUp]
        public void SetUp() { }

        [TestCase(1, "1")]
        [TestCase(29, "29")]
        [TestCase(53, "53")]
        [TestCase(98, "98")]
        public void Should_Return_Same_Passed_Number(int input, string output)
        {

            var actualNumber = FizzBuzz.Print(input);

            Assert.That(actualNumber, Is.EqualTo(output));

        }

        [TestCase(3, "Fizz")]
        [TestCase(21, "Fizz")]
        [TestCase(66, "Fizz")]
        [TestCase(99, "Fizz")]
        public void Should_Return_Fizz_If_Number_Divisible_By_Three(int input, string output)
        {

            var actualNumber = FizzBuzz.Print(input);

            Assert.That(actualNumber, Is.EqualTo(output));

        }

        [TestCase(5, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(65, "Buzz")]
        [TestCase(100, "Buzz")]
        public void Should_Return_Buzz_If_Number_Divisible_By_Five(int input, string output)
        {

            var actualNumber = FizzBuzz.Print(input);

            Assert.That(actualNumber, Is.EqualTo(output));

        }

    }
}
