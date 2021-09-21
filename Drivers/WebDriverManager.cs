using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Drivers
{
  public sealed class WebDriverManager
  {
    private readonly Lazy<IWebDriver> _webDriver = new Lazy<IWebDriver>(() =>
    {
      IWebDriver driver;
      ChromeOptions options = new ChromeOptions
      {
        AcceptInsecureCertificates = true,
        PageLoadStrategy = PageLoadStrategy.Eager,
        UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore
      };

      driver = new ChromeDriver(options);

      driver.Manage().Window.Maximize();
      
      return driver;
    });

    public IWebDriver GetDriver()
    {
      return _webDriver.Value;
    }
  }
}
