
using Edx.OnlineCourse.Core.Models;

namespace Edx.OnlineCourse.Service
{
    public interface ICourseCategoryRepository
    {
        Task<CourseCategoryModel?> GetByIdAsync(int id);

        Task<List<CourseCategoryModel>> GetCourseCategories();
    }
}