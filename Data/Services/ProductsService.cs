using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bright_web_api.Data.Models;
using bright_web_api.Data.ViewModels;

namespace bright_web_api.Data.Services
{
    public class ProductsService
    {
        private AppDbContext _context;
        public ProductsService(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts() => _context.Products.ToList();

        public void AddProduct(ProductVM product)
        {
            var _product = new Product()
            {
                Name = product.Name,
                Image = product.Image
            };

            _context.Products.Add(_product);
            _context.SaveChanges();
        }
    }
}
