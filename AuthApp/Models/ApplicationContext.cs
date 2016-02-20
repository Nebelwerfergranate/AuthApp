using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AuthApp.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("IdentityDb") { }

        static ApplicationContext()
        {
            System.Data.Entity.Database.SetInitializer(new ContextInitializer());
        }
        public static ApplicationContext Create()
        {
            return new ApplicationContext();            
        }
    }
}