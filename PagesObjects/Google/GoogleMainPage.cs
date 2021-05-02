using System.Linq;
using OpenQA.Selenium;

namespace PagesObjects.Google
{
  public class GoogleMainPage
  {
    private IWebDriver _webDriver;

    private IWebElement GetSearchString() => _webDriver.FindElement(By.Name("q"));

    private IWebElement GetSearchButton() => _webDriver.FindElements(By.XPath("//form[@action='/search']/descendant::" +
        "center/input[@name!='q' and @type='submit' and not(@jsaction)]"))
                                                 .First(element => element.Displayed);

    public GoogleMainPage(IWebDriver webDriver)
    {
      _webDriver = webDriver;
    }
  }
}
