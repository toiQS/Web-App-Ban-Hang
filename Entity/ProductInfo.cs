using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppBanHang.Entity
{
    public class ProductInfo
    {
        [Key,Required, MaxLength(10)]
        public int Info_ID { get; set; }
        [ForeignKey("Product"),Required, MaxLength(50)]
        public string Product_Line { get; set; }
        public Product? Product { get; set; }
        public string Product_Infomation { get; set; }
    }
}
