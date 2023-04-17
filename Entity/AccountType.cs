using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class AccountType
    {
        [Key,Required, MaxLength (20)]
        public string AccountTypeID { get; set; }
        [Required, MaxLength (50)]
        public string TypeName { get; set; }
        public DateTime Create_At { get; set; }
        public DateTime Modified_At { get; set; }
        public DateTime Delete_At { get; set; }

    }
}
