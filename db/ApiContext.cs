using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PurpleHardware;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options) {}

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().ToTable("Products");
    }
}
