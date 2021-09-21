using Drivers;
using OpenQA.Selenium;

namespace PageObjects.Pages.Google
{
  public sealed class GoogleSearchResultPage : BasePage
  {
    public GoogleSearchResultPage(WebDriverManager driverManager) : base(driverManager)
    {
    }

    protected override string pageAddress => throw new System.NotImplementedException();

    private IWebElement SearchResults => webDriver.FindElement(By.XPath("//div[@id='res']//div[@class='r']//h3"));
  }
}