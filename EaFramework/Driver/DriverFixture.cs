using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace DriverFixture.Driver
{
    public class DriverFixture
    {
        public IWebDriver Driver {get;}

        public DriverFixture()
        {
            Driver = GetDriverType(BrowserType.Firefox);
            Driver.Navigate().GoToUrl("https://google.com");
        }

        private IWebDriver GetDriverType(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new ChromeDriver(),
                BrowserType.Firefox => new FirefoxDriver(),
                BrowserType.Edge => new EdgeDriver(),
                _ => new ChromeDriver()
            };
        }

        public enum BrowserType
        {
            Chrome,
            Firefox,
            Edge
        }
    }
}