namespace UnitTesting.FizzBuzz
{
    public static class FizzBuzz
    {

        public static string Print(int num)
        {

            var isDivisibleByThree = num % 3 == 0;
            var isDivisibleByFive = num % 5 == 0;

            if (isDivisibleByThree && isDivisibleByFive)
            {

                return "FizzBuzz";

            }

            if (isDivisibleByThree)
            {

                return "Fizz";

            }

            if (isDivisibleByFive)
            {

                return "Buzz";

            }

            return num.ToString();

        }
        
    }
}
