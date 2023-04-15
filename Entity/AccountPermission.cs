using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class AccountPermission
    {

        [Required, MaxLength (10)]
        public string Permission { get; set; }
        [Required, MaxLength(20)]
        public string TypeID { get; set; } 

    }
}
