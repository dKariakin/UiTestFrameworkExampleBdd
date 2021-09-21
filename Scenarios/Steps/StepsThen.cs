using System;
using TechTalk.SpecFlow;

namespace Scenarios.Steps
{
  [Binding]
  internal sealed class StepsThen : StepsBase
  {
    [Then("google main page still opened")]
    public void ThenGoogleMainPageOpened()
    {
      throw new NotImplementedException("Implement the step first");
    }
  }
}
