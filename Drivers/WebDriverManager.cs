using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Drivers
{
  public class WebDriverManager
  {
    private IWebDriver _webDriver;

    private void Initialize()
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
      if (_webDriver == null)
      {
        Initialize();
      }

      return _webDriver;
    }
  }
}
