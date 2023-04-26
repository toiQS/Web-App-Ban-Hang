using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;

namespace WebAppBanHang.Services.Products
{
    public  interface IProductServices
    {
        IEnumerable<Product> ViewAll();
         
        Task CreateAsSync(Product product);
        Task DeleteByName(string name);
        Task UpdateAsSync(Product product);
        Task UpdateByName(string name);
    }
}
