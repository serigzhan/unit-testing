namespace UnitTesting.HarryPotter
{
    public class HarryPotterKataTests
    {

        [SetUp]
        public void SetUp() {}


        [Test]
        public void Should_Return_Zero_If_Cart_Is_Empty()
        {

            var cart = new ShoppingCart();

            var actualTotal = cart.Total;

            Assert.That(actualTotal, Is.EqualTo(0.00));

        }

        [Test]
        public void Should_Return_With_Zero_Percent_Discount_For_One_Book()
        {

            var cart = new ShoppingCart();
            cart.Add("Harry Potter and the Sorcerer's Stone", 1);

            var actualTotal = cart.Total;

            Assert.That(actualTotal, Is.EqualTo(8.00));

        }

        [Test]
        public void Should_Return_With_Five_Percent_Discount_For_Two_Different_Books()
        {

            var cart = new ShoppingCart();
            cart.Add("Harry Potter and the Sorcerer's Stone", 1);
            cart.Add("Harry Potter and the Chamber of Secrets", 1);

            var actualTotal = cart.Total;

            Assert.That(actualTotal, Is.EqualTo(15.20));

        }

        [Test]
        public void Should_Return_With_Max_Discount_For_Five_Different_Books()
        {

            var cart = new ShoppingCart();
            cart.Add("Harry Potter and the Sorcerer's Stone", 1);
            cart.Add("Harry Potter and the Chamber of Secrets", 1);
            cart.Add("Harry Potter and the Prisoner of Azkaban", 1);
            cart.Add("Harry Potter and the Goblet of Fire", 1);
            cart.Add("Harry Potter and the Order of the Phoenix", 1);

            var actualTotal = cart.Total;

            Assert.That(actualTotal, Is.EqualTo(30.00));

        }

        [Test]
        public void Should_Return_With_Possible_Max_Discount_For_Set_Of_Different_Books()
        {

            var cart = new ShoppingCart();
            cart.Add("Harry Potter and the Sorcerer's Stone", 2);
            cart.Add("Harry Potter and the Chamber of Secrets", 2);
            cart.Add("Harry Potter and the Prisoner of Azkaban", 2);
            cart.Add("Harry Potter and the Goblet of Fire", 1);
            cart.Add("Harry Potter and the Order of the Phoenix", 1);

            var actualTotal = cart.Total;

            Assert.That(actualTotal, Is.EqualTo(51.60));

        }

    }
}
