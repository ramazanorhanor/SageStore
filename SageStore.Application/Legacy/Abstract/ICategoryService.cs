using SageStore.Application.Legacy.DTOs;
using SageStore.Application.Legacy.Responses;
using SageStore.Domain.Entities;
namespace SageStore.Application.Legacy.Abstract
{
    public interface ICategoryService
    {
       Task< IEnumerable<CategoryResponseDTO>> GetAllCategoriesAsync(CancellationToken token=default);

       Task<CategoryResponseDTO> AddAsync(CreateCategoryDTO category, CancellationToken token = default);
    }
}
