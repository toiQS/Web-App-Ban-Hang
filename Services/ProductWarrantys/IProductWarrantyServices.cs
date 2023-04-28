using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;

namespace WebAppBanHang.Services.ProductWarrantys
{
    public interface IProductWarrantyServices
    {
        IEnumerable<ProductWarranty> ViewAll();
        ProductWarranty FindByName(string name);
        Task CreateAsSync(ProductWarranty product);
        Task DeleteByName(string name);
        Task UpdateAsSync(ProductWarranty product);
    }
}
