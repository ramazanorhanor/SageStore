using Microsoft.EntityFrameworkCore;
using SageStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Persistence.Contexts;

public class StoreContext:DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options): base(options)
    {
            
    }
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Supplier> Suppliers { get; set; } = null!;
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Server=localhost;Database=SageStoreDb;User Id=sa;Password=1q2w3e4r+!;TrustServerCertificate=True;");
    //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
    //    base.OnConfiguring(optionsBuilder);
    //}
}
