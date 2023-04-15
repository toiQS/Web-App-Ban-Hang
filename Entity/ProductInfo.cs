using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class ProductInfo
    {
        [Required, MaxLength(10)]
        public int Info_ID { get; set; }
        [Required, MaxLength(50)]
        public string Product_Line { get; set; }
        public string Product_Infomation { get; set; }
    }
}
