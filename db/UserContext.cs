using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PurpleHardware;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options) {}

    public DbSet<User> Users { get; set; }
    public DbSet<UserClient> UserClients { get; set; }
    public DbSet<UserEmployee> UserEmployees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<UserClient>().ToTable("UserClients");
        modelBuilder.Entity<UserEmployee>().ToTable("UserEmployees");
    }
}
