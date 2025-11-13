using LearningApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController(ICourseCategoryServices categoryServices) : ControllerBase
    {
        private readonly ICourseCategoryServices categoryServices = categoryServices;

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await categoryServices.GetByIdAsync(id);

            if (category == null) { 
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await categoryServices.GetCourseCategoriesAsync();
            return Ok(categories);
        }
    }
}
