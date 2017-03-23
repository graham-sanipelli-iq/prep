namespace code.utility.iteration
{
  public class AveragingVisitor<Element, Result> : IProcessAndReturnAValue<Element, Result>
  {
    SummingVisitor<Element, Result> summer;
    Result result;
    int numItems;

    public AveragingVisitor(SummingVisitor<Element, Result> summer)
    {
      this.summer = summer;
      numItems = 0;
    }

    public void process(Element value)
    {
      summer.process(value);
      numItems++;
    }

    public Result get_result()
    {
      var result = summer.get_result();
      return (dynamic)result / numItems;
    }
  }
}