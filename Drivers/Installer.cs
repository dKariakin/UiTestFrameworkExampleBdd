using SimpleInjector;

namespace Drivers
{
  public static class Installer
  {
    private static Container container;

    public static void Install()
    {
      if (container == null)
      {
        container = new Container();
      }

      container.Register(() => new WebDriverManager(), Lifestyle.Singleton);

      container.Verify();
    }
  }
}
