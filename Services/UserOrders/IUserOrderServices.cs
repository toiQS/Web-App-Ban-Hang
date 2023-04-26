using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;

namespace WebAppBanHang.Services.UserOrders
{
    public interface IUserOrderServices
    {
        IEnumerable<UserOrder> ViewAll();
        UserOrder FindById(int id);
        Task CreateAsSync(UserOrder userOrder);
        Task UpdateAsSync(UserOrder userOrder);
        Task UpdateById(int id);
        Task DeleteAsSync(int id);

    }
}
