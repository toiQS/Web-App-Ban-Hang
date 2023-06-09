﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppBanHang.Entity
{
    public class ProductImage
    {
        [Key,Required, MaxLength (11)]
        public int ImageID { get; set; }
        [ForeignKey("Product"),Required, MaxLength (50)]
        public string ProductLine { get; set; }
        public Product? Product { get; set; }
        [Required, MaxLength (50)]
        public string ImageURL { get; set; }
    }
}
