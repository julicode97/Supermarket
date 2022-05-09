namespace Supermarket
{
    public class Invoice : IPay
    {
        private List<Product> _products { get; set; }

        public Invoice()
        {
            _products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in _products)
            {
                payroll += product.ValueToPay();
            }
            return payroll;
        }

        public override string ToString()
        {
            string text = string.Empty;
            foreach (Product product in _products)
            {
                text += $"\n{product.ToString()}\n";
            }
            return $"{text} " +
                $"{"                           =============",18}" +
                $"\n\tTotal......: {$"{ValueToPay():C2}",18}";
        }
    }
}
