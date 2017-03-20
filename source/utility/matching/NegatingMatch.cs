namespace code.utility.matching
{
  public class NegatingMatch<Item> : IMatchA<Item>
  {
    IMatchA<Item> to_negate;

    public NegatingMatch(IMatchA<Item> to_negate)
    {
      this.to_negate = to_negate;
    }

    public bool matches(Item item)
    {
      return !to_negate.matches(item);
    }
  }
}