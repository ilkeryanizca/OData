using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData.Api.Constants;

namespace OData.Api.Controllers
{
    [ApiController]
    [Route("odata/weatherforecast")]
    public class WeatherForecastController : ODataController
    {
        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            var listOfForecast = Enumerable.Range(1, 5).Select(index =>
            {
                var temperatureC = Random.Shared.Next(-20, 55);

                var summary = Definitions.TemperatureRanges
                .First(range => temperatureC >= range.MinDegree && temperatureC <= range.MaxDegree)
                .Summary;

                return new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = temperatureC,
                    Summary = summary
                };
            })
            .AsQueryable();

            return Ok(listOfForecast);
        }
    }
}
