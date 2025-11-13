using LearningApp.Core.Entities;
using LearningApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Data
{
    public class CourseCategoryRepository(LearningAppDbContext dbContext) : ICourseCategoryRepository
    {
        private readonly LearningAppDbContext dbContext = dbContext;

        public Task<CourseCategory?> GetByIdAsync(int id)
        {
            var data = dbContext.CourseCategories.FindAsync(id).AsTask();
            return data;
        }

        public Task<List<CourseCategory>> GetCourseCategoryAsync()
        {
            var data = dbContext.CourseCategories.ToListAsync();
            return data;
        }
    }
}
