using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BlazorServerApp.Data
{
    public class WeatherForecastService
    {
        private const string WEATHER_FORECAST_URL = "https://WeatherForecastService/WeatherForecast";

        private readonly ILogger _logger;
        private readonly HttpClient _client;

        public WeatherForecastService(ILogger logger, HttpClient client)
        {
            _logger = logger;
            _client = client;
        }

        public Task<ICollection<WeatherForecast>> GetForecastAsync()
        {
            swaggerClient _c = new(WEATHER_FORECAST_URL, _client);

            var vals = _c.WeatherForecastAsync();
            return vals;
        }
    }
}
