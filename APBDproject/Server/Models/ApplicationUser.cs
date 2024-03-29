﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDproject.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Companies = new HashSet<Company>();
        }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
