using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public interface IWeatherForecastService
    {
        Task<ICollection<WeatherForecast>> GetForecastAsync();
    }
}