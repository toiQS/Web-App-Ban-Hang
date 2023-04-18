using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    [Keyless]
    public class AccountGroup
    {
        
        [ForeignKey("Account"),Required, MaxLength(20)]
        public string UserName { get; set; }
        public Account? Account { get; set; }
        [ForeignKey("AccountType"),Required, MaxLength(20)]
        public string AccountTypeId { get; set; }
        public AccountType? AccountType { get; set; }

    }
}
