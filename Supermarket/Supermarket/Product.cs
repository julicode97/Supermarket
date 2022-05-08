namespace Supermarket
{
    public abstract class Product : Ipay
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; } //impuesto

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"{Id} - {Description} , " +
                $"\n\tPrice......:  {$"{Price:C2}", 18}" +
                $"\n\tTax........: {$"{Tax:F2}", 18}%";
        }
    }
}
