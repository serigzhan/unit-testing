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

            var counts = _shoppingCart.Select(b => b.Quantity).ToList();

            double sum = 0.00;

            foreach (CartItem item in _shoppingCart)
            {

                sum += item.Price * item.Quantity;

            }

            sum *= 1 - getDiscount(counts.Aggregate((a, b) => a + b));

            return sum;

        }

        private static double getDiscount(int count)
        {
            return count switch
            {
                2 => 0.05,
                3 => 0.10,
                4 => 0.20,
                5 => 0.25,
                _ => 0.00,
            };
        }
    }
}