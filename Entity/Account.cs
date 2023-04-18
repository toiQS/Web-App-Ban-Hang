using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppBanHang.Entity
{
    public class Account
    {
        [Key]
        [Required, MaxLength(20)]
        public string UserName { get; set; }
        [Required, MaxLength(20)]
        public string Password { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime Modifiled_At { get; set; }
        public DateTime Delete_At { get; set; }
    }
}
