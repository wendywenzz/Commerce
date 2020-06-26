namespace Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public OrderItem()
        {
        }

        public OrderItem(int productItemId, string sKU, string productName, string pictureUrl, string category, string unitOfMeasurementName, decimal weight, decimal price, int quantity)
        {
            ProductItemId = productItemId;
            SKU = sKU;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Category = category;
            UnitOfMeasurementName = unitOfMeasurementName;
            Weight = weight;
            Price = price;
            Quantity = quantity;
        }
        public int OrderItemId { get; set; }
        public int ProductItemId { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public string Category { get; set; }
        public string UnitOfMeasurementName { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}