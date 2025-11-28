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

    }
}
