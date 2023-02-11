using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

   // private readonly ILogger<WeatherForecastController> _logger;

  public WeatherForecastController()
  {
  }

//   public WeatherForecastController(ILogger<WeatherForecastController> logger)
//     {
//         _logger = logger;
//     }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "value1", "value2 "};
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "Ira Merrill";
    }
}
