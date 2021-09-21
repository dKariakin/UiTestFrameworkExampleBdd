using System;
using PageObjects;
using TechTalk.SpecFlow;

namespace Scenarios.Steps
{
  [Binding]
  internal sealed class StepsThen : StepsBase
  {
    public StepsThen(PageObjectFactory factory) : base(factory)
    {
    }

    [Then("google main page still opened")]
    public void ThenGoogleMainPageOpened()
    {
      throw new NotImplementedException("Implement the step first");
    }
  }
}
