using SageStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Application.Legacy.Responses
{
    public class CategoryResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
