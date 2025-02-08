using Edx.OnlineCourse.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx.OnlineCourse.Service
{
    // when you create always create these file in separate file.
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository categoryRepository;

        public CourseCategoryService(ICourseCategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<CourseCategoryModel?> GetByIdAsync(int id)
        {
            var data = await categoryRepository.GetByIdAsync(id);
            // when we need data, we need to await for the call to get data
            // we cant return as our return model is different than entity model

            //This await tells the compiler to pause the execution untill data is returned from the repository
            return new CourseCategoryModel()
            {
                CategoryId = data.CategoryId,
                CategoryName = data.CategoryName,
                Description = data.Description
            };
        }

        public async Task<List<CourseCategoryModel>> GetByCourseCategoriesAsync()
        {
            var data = await categoryRepository.GetCourseCategories();
            var modelData = data.Select(x => new CourseCategoryModel()
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();

            return modelData;
        }
    }
   
}
