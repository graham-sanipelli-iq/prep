using System.Collections;
using System.Collections.Generic;

namespace code.prep.movies
{
  public class Iterator<Item> : IEnumerable<Item>
  {
    IEnumerable<Item> items;

    public Iterator(IEnumerable<Item> items)
    {
      this.items = items;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<Item> GetEnumerator()
    {
      return items.GetEnumerator();
    }
  }
}