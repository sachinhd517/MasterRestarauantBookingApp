using RestaurantBookingApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx.OnlineCourse.Data
{
    //public interface ICourseCategoryRepository
    //{
    //    CourseCategory? GetById(int id);

    //    List<CourseCategory> GetCourseCategories();
    //}

    public interface ICourseCategoryRepository
    {
        //Async method will all always return Task<T> and its method named as Async at suffix
        Task<CourseCategory?> GetByIdAsync(int id);

        Task<List<CourseCategory>> GetByCourseCategoriesAsync();

    }
}
