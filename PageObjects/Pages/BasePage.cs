using Drivers;
using OpenQA.Selenium;

namespace PageObjects.Pages
{
  public abstract class BasePage : IPage
  {
    protected IWebDriver webDriver;
    protected abstract string pageAddress { get; }

    protected BasePage(WebDriverManager driverManager)
    {
      webDriver = driverManager.GetDriver();
    }

    public void OpenPage()
    {
      webDriver.Navigate().GoToUrl(pageAddress);
    }
  }
}
