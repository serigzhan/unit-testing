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

        [TestCase(3, "Buzz")]
        [TestCase(21, "Buzz")]
        [TestCase(66, "Buzz")]
        [TestCase(99, "Buzz")]
        public void Should_Return_Buzz_If_Number_Divisible_By_Three(int input, string output)
        {

            var actualNumber = FizzBuzz.Print(input);

            Assert.That(actualNumber, Is.EqualTo(output));

        }

    }
}
