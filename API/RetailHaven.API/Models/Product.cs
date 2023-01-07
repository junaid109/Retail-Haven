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
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
