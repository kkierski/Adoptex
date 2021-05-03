using System;
using System.Collections.Generic;
using System.Text;
using Adoptex.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Adoptex.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Animal_Info> Animal_Info { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
