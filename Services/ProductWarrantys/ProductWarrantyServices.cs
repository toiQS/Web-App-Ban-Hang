using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;
using WebAppBanHang.Presistence;

namespace WebAppBanHang.Services.ProductWarrantys
{
    public class ProductWarrantyServices
    {
        private ApplicationDBContext _context;
        public ProductWarrantyServices(ApplicationDBContext context)
        {
            _context = context;
        }
        public IEnumerable<ProductWarranty> ViewAll()
        {
            return _context.ProductWarranty.ToList();
        }
        public ProductWarranty FindById(string id)
        {
            return _context.ProductWarranty.Where(x => x.Product_ID == id).FirstOrDefault();
        }
    }
}
