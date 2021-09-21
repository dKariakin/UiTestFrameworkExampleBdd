using System;
using PageObjects;
using TechTalk.SpecFlow;

namespace Scenarios.Steps
{
  [Binding]
  internal sealed class StepsWhen : StepsBase
  {
    public StepsWhen(PageObjectFactory factory) : base(factory)
    {
    }

    [When("user presses Google Search button")]
    public void WhenUserPerformesSearch()
    {
      throw new NotImplementedException("Implement the step first");
    }
  }
}
