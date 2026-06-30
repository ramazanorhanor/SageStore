using SageStore.Domain.Entities;
namespace SageStore.Application.Legacy.Abstract
{
    public interface ICategoryService
    {
       Task< IEnumerable<Category>> GetAllCategoriesAsync(CancellationToken token=default);
       Task< Category > GetCategoryByIdAsync(int id);   
       Task< Category> AddAsync(Category category, CancellationToken token = default);
    }
}
