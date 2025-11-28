namespace UnitTesting.HarryPotter
{

    public record CartItem(string Name, int Quantity, double Price);

    public class ShoppingCart
    {

        private List<CartItem> _shoppingCart = [];

        public double Total
        {
            get { return Sum(); }
        }

        public void Add(string bookName, int quantity)
        {
            _shoppingCart.Add(new CartItem(bookName, quantity, 8.00));
        }

        private double Sum()
        {

            if (_shoppingCart.Count == 0) return 0.00;

            double sum = 0.00;

            foreach (CartItem item in _shoppingCart)
            {

                sum += item.Price * item.Quantity;

            }

            return sum;

        }

    }
}