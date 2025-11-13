using LearningApp.Core.Models;
using LearningApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Services
{
    public class CourseCategoryServices(ICourseCategoryRepository categoryRepository) : ICourseCategoryServices
    {
        private readonly ICourseCategoryRepository categoryRepository = categoryRepository;

        public async Task<CourseCategoryModel> GetByIdAsync(int id)
        {
            var data = await categoryRepository.GetByIdAsync(id);
            return new CourseCategoryModel
            {
                CategoryId = data.CategoryId,
                CategoryName = data.CategoryName,
                Description = data.Description
            };
        }

        public async Task<List<CourseCategoryModel>> GetCourseCategoriesAsync()
        {
            var data = await categoryRepository.GetCourseCategoryAsync();
            var modelData = data.Select(c => new CourseCategoryModel
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                Description = c.Description
            }).ToList();

            return modelData;
        }
    }
}
