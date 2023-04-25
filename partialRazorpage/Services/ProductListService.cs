namespace Minh
{
    public class ProductListService
    {
        public List<Product> products { set; get; } = new List<Product>()
        {
            new Product() { Name = "SP1", Description = "Thông tin SP1", Price = 10000 },
            new Product() { Name = "SP2", Description = "Thông tin SP2", Price = 15000 },
            new Product() { Name = "SP3", Description = "Thông tin SP3", Price = 20000 },
            new Product() { Name = "SP4", Description = "Thông tin SP4", Price = 25000 }
        };
    }
}
