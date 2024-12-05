using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace za_ocenka.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<Id> Id { get; set; }
        public DbSet<Name> Name { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Quantity> Quantity { get; set; }
    }
}
