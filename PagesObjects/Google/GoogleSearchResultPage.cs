using OpenQA.Selenium;

namespace PagesObjects.Google
{
  public class GoogleSearchResultPage
  {
    private IWebDriver _webDriver;

    private IWebElement SearchResults => _webDriver.FindElement(By.XPath("//div[@id='res']//div[@class='r']//h3"));

    public GoogleSearchResultPage(IWebDriver webDriver)
    {
      _webDriver = webDriver;
    }
  }
}
