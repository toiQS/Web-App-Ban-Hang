using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class Product
    {
        [Required, MaxLength (50)]
        public string Product_Line { get; set; }
        [Required, MaxLength (150)]
        public string Product_Name { get; set;}
        [Required, MaxLength(10)]
        public int Price { get; set;}
        [Required, MaxLength(3)]
        public uint Discount { get; set;}
        public DateTime Create_At { get; set; }
        public DateTime Modified_At { get; set; }
        public DateTime Delete_At { get; set; }
        [Required, MaxLength(20)]
        public DateTime Create_By { get; set; }
        [Required, MaxLength(10)]
        public string BrandId { get; set; }
        [Required, MaxLength(10)]
        public int Category { get; set; }

    }
}
