namespace Core.Entities
{
    public class BasketItem
    {
        public int BasketItemId { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public string Category { get; set; }
        public string UnitOfMeasurementName { get; set; }
        public decimal Weight { get; set; }
    }
}