using Microsoft.AspNetCore.Mvc;
using RestarauantBookingApp.Data.Entities;

namespace RastaurantBookingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, OnlineCourseDbContext dbContext)
        {
            _logger = logger;
            DbContext = dbContext;
        }

        public OnlineCourseDbContext DbContext { get; }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get => Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //{
        //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //    TemperatureC = Random.Shared.Next(-20, 55),
        //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //})
        //    .ToArray();

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var courses = DbContext.Courses.ToList();
            return Ok(courses);
        }
    }
}
