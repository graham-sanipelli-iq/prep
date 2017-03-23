using System;

namespace code.utility.containers
{
  public class Dependencies
  {
    public static ICreateAContainerFacade startup = delegate
    {
      throw new NotImplementedException("This needs to be swapped up by a startup process");
    };

    public static IFetchDependencies fetch
    {
      get
      {
        return startup();
      }
    }
  }
}