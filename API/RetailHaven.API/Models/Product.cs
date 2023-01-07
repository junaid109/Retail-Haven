namespace RetailHaven.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ProductType { get; set; }
        public string? ProductBrand { get; set; }
        public int QuantityInStock { get; set; }
        public DateOnly DateAdded { get; set; }
        public DateOnly DateModified { get; set; }
        public DateOnly DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
