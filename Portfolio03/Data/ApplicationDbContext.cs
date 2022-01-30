using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Portfolio03.Models;

namespace Portfolio03.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Portfolio03.Models.Contact> Contact { get; set; }
        public DbSet<Portfolio03.Models.Person> Person { get; set; }
    }
}
