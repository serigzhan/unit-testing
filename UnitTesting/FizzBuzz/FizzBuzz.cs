namespace UnitTesting.FizzBuzz
{
    public static class FizzBuzz
    {

        public static string Print(int num)
        {

            if (num % 3 == 0)
            {

                return "Fizz";

            }

            return num.ToString();

        }
        
    }
}
