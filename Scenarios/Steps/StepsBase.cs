using Drivers;
using DryIoc;
using PageObjects;

namespace Scenarios.Steps
{
  internal abstract class StepsBase
  {
    protected readonly PageObjectFactory pageFactory;
    private readonly Container container;

    protected StepsBase()
    {
      container = new Container();
      container.Register<WebDriverManager>(Reuse.Singleton);
      container.Register<PageObjectFactory>(Reuse.Singleton);

      pageFactory = container.Resolve<PageObjectFactory>();
    }
  }
}
