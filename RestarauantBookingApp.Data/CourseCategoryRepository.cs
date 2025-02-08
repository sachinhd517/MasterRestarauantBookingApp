using Microsoft.EntityFrameworkCore;
using RestaurantBookingApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx.OnlineCourse.Data
{
    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        private readonly OnlineCourseDbContext dbContext;

        public CourseCategoryRepository(OnlineCourseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<CourseCategory?> GetByIdAsync(int id)
        {
            var data = dbContext.CourseCategories.FindAsync(id).AsTask();
            return data;
        }

        public Task<List<CourseCategory>> GetByCourseCategoriesAsync()
        {
            var data = dbContext.CourseCategories.ToListAsync();
            return data;
        }
       
    }
}
