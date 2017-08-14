using ProjectASPWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectASPWebAPI
{
    public class ProjectContext : DbContext
    {
        public DbSet<User> users { get; set; }
    }
}