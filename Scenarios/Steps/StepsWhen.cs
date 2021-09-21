using System;
using TechTalk.SpecFlow;

namespace Scenarios.Steps
{
  [Binding]
  internal sealed class StepsWhen : StepsBase
  {
    [When("user presses Google Search button")]
    public void WhenUserPerformesSearch()
    {
      throw new NotImplementedException("Implement the step first");
    }
  }
}
