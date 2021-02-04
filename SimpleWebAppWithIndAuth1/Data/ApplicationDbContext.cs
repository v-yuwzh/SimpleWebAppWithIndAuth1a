using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SimpleWebAppWithIndAuth1.Models;

namespace SimpleWebAppWithIndAuth1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SimpleWebAppWithIndAuth1.Models.Movie> Movie { get; set; }
    }
}
