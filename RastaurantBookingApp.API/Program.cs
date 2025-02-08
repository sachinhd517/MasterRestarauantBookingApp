
using Edx.OnlineCourse.Data;
using Edx.OnlineCourse.Service;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingApp.Data.Entities;
using ICourseCategoryRepository = Edx.OnlineCourse.Data.ICourseCategoryRepository;

namespace RastaurantBookingApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // we have 2 parts here, one is service configuration for DI and 2nd one is Middlewares
            //#region Service Configuration
            builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            //DB configuration goes here

            builder.Services.AddDbContext<OnlineCourseDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbContext"),
                    provideroption => provideroption.EnableRetryOnFailure());
            });


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            // configure the services
            builder.Services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
