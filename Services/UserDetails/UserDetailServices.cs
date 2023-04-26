using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBanHang.Entity;
using WebAppBanHang.Presistence;

namespace WebAppBanHang.Services.UserDetails
{
    public class UserDetailServices
    {
        private ApplicationDBContext _context;
        public UserDetailServices(ApplicationDBContext context)
        {
            _context = context;
        }
        public IEnumerable<UserDetail> ViewAll()
        {
            return _context.UserDetail.ToList();
        }
        public UserDetail FindById(int id)
        {
            return _context.UserDetail.Where(x => x.UserDetailId == id).FirstOrDefault();
        }
        public async Task CreateAsSync(UserDetail userDetail)
        {
            _context.Add(userDetail);
            await _context.SaveChangesAsync(); 
        }
        public async Task DeleteAsSync(int id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsSync(UserDetail userDetail)
        {
            _context.Update(userDetail);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateById(int id)
        {
           var UserDetail = FindById(id);
            if (UserDetail != null)
            {
                _context.Update(UserDetail);
            }
            await _context.SaveChangesAsync();
        }
    }
}
