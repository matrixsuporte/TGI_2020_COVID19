using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TGI_2020_COVID19.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TGI_2020_COVID19.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}