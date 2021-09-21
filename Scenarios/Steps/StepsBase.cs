using PageObjects;

namespace Scenarios.Steps
{
  internal abstract class StepsBase
  {
    protected readonly PageObjectFactory pageFactory;

    protected StepsBase(PageObjectFactory factory)
    {
      pageFactory = factory;
    }
  }
}
