using RetailHaven.API.Models;

namespace RetailHaven.API.Data
{
    public static class DatabaseSeeder
    {


   
        public static void Seed(StoreContext context)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Nike Air Max 270",
                        Description = "The Nike Air Max 270 is a lifestyle sneaker that features Nike's largest heel Air unit yet. The Air Max 270 is inspired by two icons of big Air: the Air Max 180 and Air Max 93. It features Nike's biggest heel Air unit yet, which provides responsive cushioning. The shoe also features a bootie construction for a snug, comfortable fit.",
                        Price = 120.00m,
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/3b9b8b3a-3b8a-4b1f-8b1a-8b8b2b2b2b2b/air-max-270-mens-shoe-1JZxJx.jpg",
                        ProductType = "Sneakers",
                        ProductBrand = "Nike",
                        QuantityInStock = 10
                    },
                    new Product()
                    {
                        Name = "Nike Air Max 2090",
                        Description = "The Nike Air Max 2090 is a lifestyle sneaker that features Nike's largest heel Air unit yet. The Air Max 2090 is inspired by two icons of big Air: the Air Max 180 and Air Max 93. It features Nike's biggest heel Air unit yet, which provides responsive cushioning. The shoe also features a bootie construction for a snug, comfortable fit.",
                        Price = 120.00m,
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/3b9b8b3a-3b8a-4b1f-8b1a-8b8b2b2b2b2b/air-max-270-mens-shoe-1JZxJx.jpg",
                        ProductType = "Sneakers",
                        ProductBrand = "Nike",
                        QuantityInStock = 10
                    },
                    new Product()
                    {
                        Name = "Nike Air Max 2090",
                        Description = "The Nike Air Max 2090 is a lifestyle sneaker that features Nike's largest heel Air unit yet. The Air Max 2090 is inspired by two icons of big Air: the Air Max 180 and Air Max 93.It features Nike's biggest heel Air unit yet, which provides responsive cushioning. The shoe also features a bootie construction for a snug, comfortable fit.",
                        Price = 120.00m,
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/3b9b8b3a-3b8a-4b1f-8b1a-8b8b2b2b2b2b/air-max-270-mens-shoe-1JZxJx.jpg",
                        ProductType = "Sneakers",
                        ProductBrand = "Nike",
                        QuantityInStock = 10
                    },
                    new Product()
                    {
                        Name = "Nike Air Max 2090",
                        Description = "The Nike Air Max 2090 is a lifestyle sneaker that features Nike's largest heel Air unit yet. The Air Max 2090 is inspired by two icons of big Air: the Air Max 180 and Air Max 93. It features Nike's biggest heel Air unit yet, which provides responsive cushioning. The shoe also features a bootie construction for a snug, comfortable fit.",
                        Price = 120.00m,
                        ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/3b9b8b3a-3b8a-4b1f-8b1a-8b8b2b2b2b2b/air-max-270-mens-shoe-1JZxJx.jpg",
                        ProductType = "Sneakers",
                        ProductBrand = "Nike",
                        QuantityInStock = 10
                    },
              
                };

                foreach (var product in products)
                {
                    context.Products.Add(product);
                    
                }
                context.SaveChanges();
            }

        }

        
    }
}
