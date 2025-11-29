namespace UnitTesting.HarryPotter
{

    public record CartItem(string Name, int Quantity, double Price);

    public class ShoppingCart
    {

        private readonly List<CartItem> _shoppingCart = [];

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

            var basketSets = new List<int>();

            while (counts.Any(q => q > 0))
            {

                int setSize = counts.Count(q => q > 0);
                basketSets.Add(setSize);

                for (int i = 0; i < counts.Count; i++)
                {
                    if (counts[i] > 0) counts[i]--;
                }

            }

            double sum = 0.00;

            foreach (int size in basketSets)
            {
                double discount = GetDiscount(size);
                sum += size * 8 * (1 - discount);

            }

            return sum;

        }

        private static double GetDiscount(int count)
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