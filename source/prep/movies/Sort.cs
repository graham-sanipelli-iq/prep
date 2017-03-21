using code.utility;
using code.utility.matching;
using System;

namespace code.prep.movies
{
  public class Sort<ItemToMatch>
  {
    public static ICompareTwoItems<PropertyType> by_descending<out PropertyType>(IGetTheValueOfAProperty<ItemToMatch, PropertyType> accessor) where PropertyType : IComparable<PropertyType>
    {
      return (a, b) => a.CompareTo(b);
    }
  }
}