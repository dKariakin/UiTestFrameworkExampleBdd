using System.Collections.Generic;
using System.Linq;
using Drivers;
using PageObjects.Pages;
using PageObjects.Pages.Google;

namespace PageObjects
{
  public sealed class PageObjectFactory
  {
    private readonly List<IPage> factory;

    public PageObjectFactory(WebDriverManager driverManager)
    {
      factory = new List<IPage>()
      {
        new GoogleMainPage(driverManager),
        new GoogleSearchResultPage(driverManager)
      };
    }

    public T GetFromFactory<T>() where T : IPage
    {
      T page = factory.OfType<T>().FirstOrDefault();

      if (page == null)
      {
        throw new KeyNotFoundException($"Page with type {typeof(T)} hasn't been added to the page factory");
      }
      
      return page;
    }
  }
}
