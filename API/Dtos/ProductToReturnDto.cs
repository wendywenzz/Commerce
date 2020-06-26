namespace API.Dtos
{
    public class ProductToReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public string PictureUrl { get; set; }
        public string ProductCategory { get; set; }
        public string UnitOfMeasurementName { get; set; }
    }
}