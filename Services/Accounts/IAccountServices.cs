using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;
namespace WebAppBanHang.Services.Accounts
{
    public interface IAccountServices
    {
        public IEnumerable<Account> ViewAll();
    }
}
