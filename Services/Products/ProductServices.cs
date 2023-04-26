using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;
using WebAppBanHang.Presistence;

namespace WebAppBanHang.Services.Products
{
    public class ProductServices
    {
        private ApplicationDBContext _context;
        public ProductServices(ApplicationDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> ViewAll()
        {
            return _context.Product.ToList();
        }
        public async Task CreateAsSync(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsSync(string name)
        {
            _context.Remove(name);
            await _context.SaveChangesAsync();
        }
        public Product FindByName(string name)
        {
            return _context.Product.Where(x => x.Product_Line == name).FirstOrDefault();
        }
        public async Task UpdateAsSync(Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateByName(string name)
        {
            var product = FindByName(name);
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
