using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Videostore.Entities;

namespace Videostore.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Buy> Buys { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<Studio> Studios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Data seed

            builder.Entity<Studio>().HasData(
                new Studio
                {
                    studioID = 1,
                    studioName = "Warner Brothers",
                },
                new Studio
                {
                    studioID = 2,
                    studioName = "Universal",
                },
                new Studio
                {
                    studioID = 3,
                    studioName = "Disney",
                }
                );

            base.OnModelCreating(builder);

        }

    }
}
