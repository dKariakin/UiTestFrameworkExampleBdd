using System.Linq;
using Drivers;
using OpenQA.Selenium;

namespace PageObjects.Pages.Google
{
  public sealed class GoogleMainPage : BasePage
  {
    protected override string pageAddress => "www.google.com";

    public GoogleMainPage(WebDriverManager driverManager) : base(driverManager)
    {
    }

    private IWebElement GetSearchString() => webDriver.FindElement(By.Name("q"));

    private IWebElement GetSearchButton() => webDriver.FindElements(By.XPath("//form[@action='/search']/descendant::" +
        "center/input[@name!='q' and @type='submit' and not(@jsaction)]"))
                                                 .First(element => element.Displayed);
  }
}