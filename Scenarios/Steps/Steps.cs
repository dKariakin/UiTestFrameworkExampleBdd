using System;
using Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Scenarios.Steps
{
  //TODO Split this class to a different step classes
  [Binding]
  internal class Steps
  {
    private readonly IWebDriver webDriver;

    public Steps()
    {
      webDriver = new WebDriverManager().GetDriver();
    }

    [Given("google main page is opened")]
    public void GivenMainPageIsOpened()
    {
      webDriver.Navigate().GoToUrl("www.google.com");
    }

    [Given("query field is empty")]
    public void WhenQueryFieldIsEmpty()
    {
      throw new NotImplementedException("Implement the step first");
    }

    [When("user presses Google Search button")]
    public void WhenUserPerformesSearch()
    {
      throw new NotImplementedException("Implement the step first");
    }

    [Then("google main page still opened")]
    public void ThenGoogleMainPageOpened()
    {
      throw new NotImplementedException("Implement the step first");
    }
  }
}
