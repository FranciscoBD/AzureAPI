using System;
using Xunit;

using AzureAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace AzureAPI.test
{
    public class UnitTest1
    {

        private ILogger<WeatherForecastController> _logger;
        
        [Fact]
        public void Test1()
        {

        }

        // Arrange, Act, Assert

        [Fact]
        public void GetReturnsCorrectWeather()
        {

            // Arrange --> Declaración de variables
            WeatherForecastController controller = new WeatherForecastController(_logger);

            // Act --> Invocación de métodos
            var returnValue = controller.Get(1);

            //Assert -- Pruebas 
            Assert.Equal("Cool", returnValue.Value);
        }

    }
}
