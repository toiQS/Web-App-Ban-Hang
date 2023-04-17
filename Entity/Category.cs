using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class Category
    {
        [Key,Required, MaxLength (10)]
        public int CategoryID { get; set; }
        [Required, MaxLength (50)]
        public string CategoryName { get; set; }
    }
}
