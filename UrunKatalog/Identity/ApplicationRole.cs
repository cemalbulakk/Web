﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace UrunKatalog.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {
            
        }

        public ApplicationRole(string roleName, string description)
        {
            this.Description = description;
        }
    }
}