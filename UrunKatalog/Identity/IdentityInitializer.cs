using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using UrunKatalog.Entity;

namespace UrunKatalog.Identity
{
    public class IdentityInitializer : DropCreateDatabaseIfModelChanges<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Roles
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole()
                {
                    Name = "admin",
                    Description = "Admin Rolü"
                };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole(){
                    Name = "user",
                    Description = "User Rolü"
                };
                manager.Create(role);
            }


            //Users

            if (!context.Roles.Any(i => i.Name == "cemalbulak"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "Cemal",
                    SurName = "Bulak",
                    UserName = "cemalbulak",
                    Email = "cemalbulak41@gmail.com"

                };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
            }

            if (!context.Roles.Any(i => i.Name == "salihbulak"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "Salih",
                    SurName = "Bulak",
                    UserName = "salihbulak",
                    Email = "salihbulak@gmail.com"

                };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
            }



            base.Seed(context);
        }
    }
}