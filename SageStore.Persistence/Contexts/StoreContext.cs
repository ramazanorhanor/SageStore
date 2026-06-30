using Microsoft.EntityFrameworkCore;
using SageStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Persistence.Contexts;

public class StoreContext:DbContext
{
    public StoreContext()
    {
            
    }
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Supplier> Suppliers { get; set; } = null!;
}
