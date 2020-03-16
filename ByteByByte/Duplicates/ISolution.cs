using System.Collections.Generic;

namespace Examples.ByteByByte.Duplicates
{
  public interface ISolution
  {
    HashSet<int> FindDuplicates(int[] items);
  }
}