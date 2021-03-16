using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManageStateExampleWithStatepattern.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ManageStateExampleWithStatepattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            Clock clock = new Clock();
            clock.ModeButton(); //va in stato modifica ore
            clock.ChangeButton(); //aggiunge un'ora
            clock.ModeButton(); //va in stato modifica minuti
            clock.ChangeButton(); //aggiunge un minuto
            clock.ChangeButton(); //aggiunge un minuto
            clock.ModeButton(); //stato nromale
        }
    }
}
