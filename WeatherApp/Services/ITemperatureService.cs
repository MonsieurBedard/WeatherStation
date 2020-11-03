using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public interface ITemperatureService
    {
        public Task<TemperatureModel> GetTempAsync();
    }
}
