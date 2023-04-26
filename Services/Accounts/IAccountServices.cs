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
        IEnumerable<Account> ViewAll();
        Account FindById(int id);
        Task CreateAsSync(Account account);
        Task UpdateAsSync(Account account);
        Task DeleteById(int id);
        Task UpdateById(int id, Account account);

    }
}
