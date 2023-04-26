using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;

namespace WebAppBanHang.Services.UserDetails
{
    public interface IUserDetailsServices
    {
        public IEnumerable<UserDetail> ViewAll();
        UserDetailServices FindById(int id);
        Task CreateAsSync (UserDetail userDetail);
        Task DeleteById(int id);
        Task UpdateAsSync (UserDetail userDetail);
        Task UpdateById(int id);
    }
}
