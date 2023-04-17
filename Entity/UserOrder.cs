using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class UserOrder
    {
        [Required, MaxLength(11)]
        public string OrderID { get; set; }
        [ForeignKey("Account"),Required, MaxLength(20)]
        public string UserName { get; set; }
        public DateTime Create_At { get; set; }
        [Required, MaxLength(20)]
        public string Status { get; set; }
        [Required, MaxLength(10)]
        public uint Total { get; set; }
        [ForeignKey("Account"),Required, MaxLength(20)]
        public string Comfirmed_by { get; set; }
    }
}
