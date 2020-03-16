namespace Examples.Codility.FrogRiverOne
{
  public class Solution
  {
    public int CalculateCrossingTime(int X, int[] A)
    {
      var landed = new bool[X];
      var remaining = X;
      for (var i = 0; i < A.Length; i++)
      {
        var position = A[i] - 1;
        if (!landed[position])
        {
          landed[position] = true;
          remaining--;
        }
        if (remaining == 0)
        {
          return i;
        }
      }
      return -1;
    }
  }
}