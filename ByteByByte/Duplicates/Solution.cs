using System.Collections.Generic;
using System.Linq;

namespace Examples.ByteByByte.Duplicates
{
  public class Solution : ISolution
  {
    public HashSet<int> FindDuplicates(int[] items)
    {
      var seen = new Dictionary<int, bool>();
      var duplicates = new HashSet<int>();
      foreach (var item in items)
      {
        if (seen.GetValueOrDefault(item))
          duplicates.Add(item);
        seen[item] = true;
      }
      return duplicates;
    }
  }
}