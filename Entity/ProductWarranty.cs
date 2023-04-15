using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class ProductWarranty
    {
        [Required, MaxLength(50)]
        public string Product_ID { get; set; }
        public DateTime Purchased_At { get; set; }
        public DateTime Warranty_Period { get; set; }
        [Required, MaxLength(50)]
        public string Product_Line { get; set;}
    }
}
