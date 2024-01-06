using Application.Repositories;
using Domain.Models.Auxiliary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
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
        private readonly InMemoryDatabase _database; // only for test
         
        public WeatherForecastController(ILogger<WeatherForecastController> logger, InMemoryDatabase db)
        {
            _logger = logger;
            _database = db;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("get-partners")]
        public List<PartnerTypeModel> GetPartners()
        {
            return _database.PartnerTypesDB.ToList();
        }

        [HttpGet]
        [Route("get-techs")]
        public List<TechnologyModel> GetTechs()
        {
            return _database.TechnologiesDB.ToList();
        }

        [HttpGet]
        [Route("get-countries")]
        public List<CountryModel> GetCountries()
        {
            return _database.CountriesDB.ToList();
        }

        [HttpGet]
        [Route("get-orgs")]
        public List<OrganizationModel> GetOrgs()
        {
            return _database.OrganizationsDB.ToList();
        }

        [HttpGet]
        [Route("get-sectors")]
        public List<SectorModel> GetSectors()
        {
            return _database.SectorsDB.ToList();
        }
    }
}