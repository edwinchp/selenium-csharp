using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace selenium_csharp;

public class UnitTest1 : IDisposable
{
    private readonly IWebDriver _driver;

    public void Dispose()
    {
        _driver.Close();
    }

    public UnitTest1()
    {
        _driver = GetDriverType("edge");
    }

    private IWebDriver GetDriverType(string browserType)
    {
        return browserType switch
        {
            "chrome" => new ChromeDriver(),
            "firefox" => new FirefoxDriver(),
            "edge" => new EdgeDriver(),
            _ => new ChromeDriver()
        };
    }

    [Fact]
    public void Test1()
    {
        _driver.Navigate().GoToUrl("https://google.com");
    }

    [Fact]
    public void Test2()
    {
        _driver.Navigate().GoToUrl("https://youtube.com");
    }

    [Fact]
    public void Test3()
    {
        _driver.Navigate().GoToUrl("https://udemy.com");
    }
}