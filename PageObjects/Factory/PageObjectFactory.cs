using System.Collections.Generic;
using Drivers;
using PageObjects.Pages;
using PageObjects.Pages.Google;

namespace PageObjects
{
  public sealed class PageObjectFactory
  {
    private readonly IDictionary<string, IPage> factory;

    public PageObjectFactory(WebDriverManager driverManager)
    {
      factory = new Dictionary<string, IPage>()
      {
        { nameof(GoogleMainPage), new GoogleMainPage(driverManager) },
        { nameof(GoogleSearchResultPage), new GoogleSearchResultPage(driverManager) }
      };
    }

    public T GetFromFactory<T>() where T : IPage
    {
      if (factory.TryGetValue(typeof(T).FullName, out IPage page))
      {
        return (T)page;
      }

      throw new KeyNotFoundException($"Page with type {typeof(T)} hasn't been added to the page factory");
    }
  }
}
