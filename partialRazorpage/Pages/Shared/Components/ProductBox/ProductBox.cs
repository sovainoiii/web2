using Microsoft.AspNetCore.Mvc;

namespace Minh
{
    public class ProductBox : ViewComponent
    {
        // Invoke(object o)
        // InvokeAsync()
        public IViewComponentResult Invoke(bool sapxeptang = true)
        {
            var products = new List<Product>()
            {
                new Product() { Name = "SP1", Description = "Thông tin SP1", Price = 10000 },
                new Product() { Name = "SP2", Description = "Thông tin SP2", Price = 15000 },
                new Product() { Name = "SP3", Description = "Thông tin SP3", Price = 20000 },
                new Product() { Name = "SP4", Description = "Thông tin SP4", Price = 25000 }
            };
            List<Product> _products = null;
            if (sapxeptang )
            {
                _products = products.OrderBy(p => p.Price).ToList();
            } 
            else
            {
                _products = products.OrderByDescending(p => p.Price).ToList();
            }
            return View<List<Product>>(_products);
        }
    }
}
