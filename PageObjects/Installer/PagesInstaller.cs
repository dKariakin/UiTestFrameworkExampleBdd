using DryIoc;

namespace PageObjects
{
  public class PagesInstaller
  {
    public PagesInstaller(Container container)
    {
      container.Register<PageObjectFactory>(Reuse.Singleton);
    }
  }
}
