namespace Examples.Codility.PermMissingElem
{
  public class Solution
  {
    public int FindMissingElement(int[] A)
    {
      var fullXor = 0;
      var subsetXor = 0;
      for (var i = 1; i <= A.Length + 1; i++)
      {
        fullXor ^= i;
      }
      foreach (var a in A)
      {
        subsetXor ^= a;
      }
      return fullXor ^ subsetXor;
    }
  }
}