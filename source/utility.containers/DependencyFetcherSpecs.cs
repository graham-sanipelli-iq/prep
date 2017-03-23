using System;
using developwithpassion.specifications;
using Machine.Fakes.Adapters.Rhinomocks;
using Machine.Specifications;

namespace code.utility.containers
{
  [Subject(typeof(DependencyFetcher))]
  public class DependencyFetcherSpecs
  {
    public abstract class concern : use_engine<RhinoFakeEngine>.observe<IFetchDependencies, DependencyFetcher>
    {

    }

    public class when_asked_for_instance_of_object : concern
    {
      Because b = () => 
        sut.get<Object>();

      It returns_instance_of_object = () =>
      {
        result.ShouldNotBeNull();
        result.ShouldBeOfExactType(typeof(Object));       
      };

      static object result;
    }

  }
}