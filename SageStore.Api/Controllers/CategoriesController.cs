using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SageStore.Application.Legacy.Abstract;
using SageStore.Application.Legacy.Concrete;
using SageStore.Application.Legacy.DTOs;
using SageStore.Domain.Entities;

namespace SageStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryService categoryService) : ControllerBase
    {
        public async Task<IActionResult> GetAsync()
        {
            var categories = categoryService.GetAllCategoriesAsync().Result;
            return Ok(categories);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreateCategoryDTO category)
        {
            var categories =await categoryService.AddAsync(category);
            return Created($"api/categories/",categories);
        }
    }
}
