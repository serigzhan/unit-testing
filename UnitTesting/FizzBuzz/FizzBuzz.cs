namespace UnitTesting.FizzBuzz
{

    public interface IPrinter
    {

        void Print(string value);

    }

    public class FizzBuzz(IPrinter printer)
    {

        private readonly IPrinter _printer = printer;

        public void Run()
        {

            for (int i = 1; i < 100; i++)
            {
                _printer.Print(GetValue(i));
            }

        }

        public string GetValue(int num)
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
