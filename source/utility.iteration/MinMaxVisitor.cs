using System;
using code.utility.core;

namespace code.utility.iteration
{
  public delegate bool Comparer<Element>(Element a, Element b);

  public class MinMaxVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result> where Result : IComparable<Result>
  {
    IGetTheValueOfAProperty<Element, Result> accessor;
    Result min;
    bool hasBeenSet;
    Comparer<Result> comparer;

    public MinMaxVisitor(IGetTheValueOfAProperty<Element, Result> accessor, Comparer<Result> comparer)
    {
      this.accessor = accessor;
      hasBeenSet = false;
      this.comparer = comparer;
    }

    public void process(Element value)
    {
      var valueProperty = accessor(value);
      if(comparer(valueProperty, min) || !hasBeenSet)
      {
        min = valueProperty;
        hasBeenSet = true;
      }
    }

    public Result get_result()
    {
      return min;
    }
  }
}