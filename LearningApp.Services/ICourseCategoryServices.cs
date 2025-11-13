using LearningApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Services
{
    public interface ICourseCategoryServices
    {
        Task<CourseCategoryModel> GetByIdAsync(int id);
        Task<List<CourseCategoryModel>> GetCourseCategoriesAsync();
    }
}
