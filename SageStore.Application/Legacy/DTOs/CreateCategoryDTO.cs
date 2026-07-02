using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Application.Legacy.DTOs
{
    public class CreateCategoryDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
