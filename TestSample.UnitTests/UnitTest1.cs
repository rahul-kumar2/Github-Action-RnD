using HelloWorldAPI.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSample.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILogger<WeatherForecastController> logger = null;
            WeatherForecastController d = new WeatherForecastController(logger);
            d.GetData();

        }
    }
}