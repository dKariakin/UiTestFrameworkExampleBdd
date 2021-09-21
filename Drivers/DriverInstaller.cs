
namespace Drivers
{
  public class DriverInstaller
  {
    private static readonly Container _container = new Container();

    public void Install()
    {
      _container.Register(() => new WebDriverManager(), Lifestyle.Singleton);

      _container.Verify();
    }
  }
}
