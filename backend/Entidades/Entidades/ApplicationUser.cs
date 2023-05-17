using Entidades.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class ApplicationUser : IdentityUser
    {
        [Column("usr_age")]
        public int Age { get; set; }

        [Column("usr_phone")]
        public string Phone { get; set; }

        [Column("usr_type")]
        public UserType? Type { get; set; }
    }
}
