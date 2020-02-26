using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ClientServices;
using Microsoft.AspNet.Identity.EntityFramework;

namespace UrunKatalog.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {
            
        }
    }
}