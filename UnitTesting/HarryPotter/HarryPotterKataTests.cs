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

            Assert.AreEqual(0, actualTotal);

        }

    }
}
