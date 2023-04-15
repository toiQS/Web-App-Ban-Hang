using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class ProductImage
    {
        [Required, MaxLength (11)]
        public int ImageID { get; set; }
        [Required, MaxLength (50)]
        public string ProductLine { get; set; }
        [Required, MaxLength (50)]
        public string ImageURL { get; set; }
    }
}
