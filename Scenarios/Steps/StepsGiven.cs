using System;
using PageObjects.Pages.Google;
using TechTalk.SpecFlow;

namespace Scenarios.Steps
{
  [Binding]
  internal sealed class StepsGiven : StepsBase
  {
    [Given("google main page is opened")]
    public void GivenMainPageIsOpened()
    {
      pageFactory.GetFromFactory<GoogleMainPage>().OpenPage();
    }

    [Given("query field is empty")]
    public void WhenQueryFieldIsEmpty()
    {
      throw new NotImplementedException("Implement the step first");
    }
  }
}
