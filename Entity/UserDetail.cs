using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class UserDetail
    {
        [Key,Required, MaxLength(11)]
        public int UserDetailId { get; set; }
        [ForeignKey("Account"),Required, MaxLength(20)]
        public string UserName { get; set; }
        public Account? Account { get; set; }
        [Required, MaxLength(30)]
        public string? DetaledAddress { get; set; }
        [Required, MaxLength(20)]
        public string WardOrVillage { get; set; }
        [Required, MaxLength(20)]
        public string District { get; set; }
        [Required, MaxLength(20)]
        public string CityOrProvince { get; set; }
        [Required, MaxLength(20)]
        public string Phone { get; set; }
    }
}
