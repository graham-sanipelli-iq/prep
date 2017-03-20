namespace code.utility.matching
{
  public interface IMatchA<in Item>
  {
    bool matches(Item item);
  }
}