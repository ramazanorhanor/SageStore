using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Domain.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string TaxNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Address { get; set; }

        public  ICollection< Product>? Products { get; set; }
    }
}
