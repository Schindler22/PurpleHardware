using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PurpleHardware;

public class ApiContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public string DbPath { get; }
    public ApiContext(){ 
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "PurpleHardware.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    } 
}
