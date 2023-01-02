﻿using Microsoft.EntityFrameworkCore;

namespace DansBigBarginBarn.Models
{
    public class AppDbContext : DbContext 
    {

        public DbSet<Product> Products { get; set; }




        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
