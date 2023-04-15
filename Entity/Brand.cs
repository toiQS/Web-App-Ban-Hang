using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class Brand
    {
        [Required, MaxLength(10)]
        public string BrandId { get; set; }
        [Required, MaxLength(20)]
        public string BrandName { get; set;}
    }
}
