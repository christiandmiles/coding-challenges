namespace Examples.Codility.BinaryGap
{
  public class Solution
  {
    public int CalculateBinaryGap(int N)
    {
      var maxCount = 0;
      var currentCount = 0;
      var isGap = false;
      while (N > 0)
      {
        if ((N & 1) == 1)
        {
          if (currentCount > maxCount)
          {
            maxCount = currentCount;
          }
          currentCount = 0;
          isGap = true;
        }
        else if (isGap)
        {
          currentCount++;
        }
        N >>= 1;
      }
      return maxCount;
    }
  }
}