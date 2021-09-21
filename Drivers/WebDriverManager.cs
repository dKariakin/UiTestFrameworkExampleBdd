using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Drivers
{
  public sealed class WebDriverManager
  {
    private readonly IWebDriver _webDriver;

    public WebDriverManager()
    {
      ChromeOptions options = new ChromeOptions
      {
        AcceptInsecureCertificates = true,
        PageLoadStrategy = PageLoadStrategy.Eager,
        UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore
      };

      _webDriver = new ChromeDriver(options);

      _webDriver.Manage().Window.Maximize();
    }

    public IWebDriver GetDriver()
    {
      return _webDriver;
    }
  }
}
