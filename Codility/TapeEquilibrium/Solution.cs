using System;

namespace Examples.Codility.TapeEquilibrium
{
  public class Solution
  {
    public int FindEquilibrium(int[] A)
    {
      long leftSideTotal = 0;
      long rightSideTotal = 0;
      for (var i = 0; i < A.Length; i++)
      {
        rightSideTotal += A[i];
      }
      long currentMin = int.MaxValue;
      for (var i = 0; i < A.Length - 1; i++)
      {
        rightSideTotal -= A[i];
        leftSideTotal += A[i];
        long difference = Math.Abs(rightSideTotal - leftSideTotal);
        currentMin = difference < currentMin ? difference : currentMin;

      }
      return (int)currentMin;
    }
  }
}