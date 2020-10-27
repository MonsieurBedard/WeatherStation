using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        private ITemperatureService TemperatureService;

        public DelegateCommand<String> GetTempCommand { get; set; }

        public TemperatureViewModel()
        {
            GetTempCommand = new DelegateCommand<string>(GetTemp);
        }

        private void GetTemp(string obj)
        {
            if (TemperatureService == null)
            {
                throw new NullReferenceException();
            }
        }

        public object CelsiusInFahrenheit(double c)
        {
            double result = (c * 9 / 5) + 32;
            return Math.Round(result, 1);
        }

        public object FahrenheitInCelsius(double f)
        {
            double result = (f - 32) * 5 / 9;
            return Math.Round(result, 1);
        }
    }
}
