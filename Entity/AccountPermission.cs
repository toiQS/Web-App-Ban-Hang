using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppBanHang.Entity
{
    [Keyless]
    public class AccountPermission
    {

        [ForeignKey("Permission")]
        [ Required, MaxLength (10)]
        public string PermissionID { get; set; }
        public Permission? Permissions { get; set; }
        [ForeignKey("AccountType"),Required, MaxLength(20)]
        public string TypeID { get; set; }
        public AccountType? AccountType { get; set; }

    }
}
