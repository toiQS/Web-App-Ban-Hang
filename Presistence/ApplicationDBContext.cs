using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp_Ban_Hang.Entity;

namespace WebApp_Ban_Hang.Presistence
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Account> Account { get; set; }
        public DbSet<AccountGroup> AccountGroup { get; set; }
        public DbSet<AccountPermission> AccountPermission { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductInfo> ProductInfo { get; set; }
        public DbSet<ProductWarranty> ProductWarranty { get; set;}
        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<UserOrder> UserOrder { get; set; }
    }
}
