﻿namespace DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}

