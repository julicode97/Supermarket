namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in Products)
            {
                payroll += product.ValueToPay();
            }
            return payroll - (payroll * (decimal)Discount);
        }

        public override string ToString()
        {
            return $"{Id} - {Description} , " +
                $"\n\tProducts...: {$"{String.Join(",", Products.Select(x => x.Description.ToString()).ToArray())}",18}" +
                $"\n\tDiscount...: {$"{Discount:F2}",18}%" +
                $"\n\tValue......: {$"{ValueToPay():C2}",18}";
        }

    }
}
