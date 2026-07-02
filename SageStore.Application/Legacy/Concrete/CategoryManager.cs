using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SageStore.Application.Legacy.Abstract;
using SageStore.Application.Legacy.Responses;
using SageStore.Domain.Entities;
using SageStore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Application.Legacy.Concrete
{
    public class CategoryManager(StoreContext context,IMapper mapper) : ICategoryService
    {
        public async Task<Category> AddAsync(Category category, CancellationToken token = default)
        {
            var hasCategory = await context.Categories.AnyAsync(c => c.Name == category.Name, cancellationToken: token);
            if (hasCategory)
            {
                throw new InvalidOperationException($"Category with name '{category.Name}' already exists.");
            }

                context.Categories.Add(category);
            await context.SaveChangesAsync(token);
            return category;
        }
        
        public async Task<IEnumerable<CategoryResponseDTO>> GetAllCategoriesAsync(CancellationToken token = default)
        {
            var data = await context.Categories.AsNoTracking().ToListAsync(cancellationToken: token);
            var categories=mapper.Map<IEnumerable<CategoryResponseDTO>>(data);
            return categories;
        }

        public Task<Category> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
