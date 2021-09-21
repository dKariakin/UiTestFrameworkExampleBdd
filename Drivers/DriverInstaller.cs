
using DryIoc;

namespace Drivers
{
  public class DriverInstaller
  {
    private readonly Container _container = new Container();

    public void Install()
    {
      _container.Register<WebDriverManager>(Reuse.Singleton);
    }
  }
}
