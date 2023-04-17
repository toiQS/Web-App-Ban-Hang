using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp_Ban_Hang.Entity
{
    public class Permission
    {
        [Key, Required, MaxLength(10)]
        public string PermissionId { get; set; }
        [Required, MaxLength(10)]
        public string PermissionName { get; set; }
        [Required, MaxLength(50)]
        public string Description { get; set; }
    }
}
