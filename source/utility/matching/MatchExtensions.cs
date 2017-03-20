namespace code.utility.matching
{
  public static class MatchExtensions
  {
    public static IMatchA<Element> or<Element>(this IMatchA<Element> left, IMatchA<Element> right)
    {
      return new OrMatch<Element>(left, right);
    }

    public static IMatchA<Element> not<Element>(this IMatchA<Element> to_negate)
    {
      return new NegatingMatch<Element>(to_negate);
    }
  }
}