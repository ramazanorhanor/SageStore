using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int SupplierId { get; set; }
    public string Name { get; set; }= null!;
    public string Description { get; set; }=null!;
    public decimal UnitPrice { get; set; }
    public int StockQuantity { get; set; }

    public Category Category { get; set; } = null!;
    public Supplier Supplier { get; set; }=null!;
}
