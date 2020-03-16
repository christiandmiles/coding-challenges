using System;

namespace Examples.ByteByByte.MedianOfArrays
{
  public class SameLengthInputs : ISolution
  {
    public double Median(int[] array1, int[] array2)
    {
      if (array1.Length != array2.Length) throw new ArgumentException("Same length inputs required.");
      if (array1.Length == 0) return 0;
      if (array1.Length == 1) return (array1[0] + array2[0]) / 2.0;

      // split the arrays by their median until we have 2 length 2 arrays
      var (smallArray1, smallArray2) = SplitByMedianRecursive(array1, array2);

      var lowerMedian = smallArray1[0] > smallArray2[0] ? smallArray1[0] : smallArray2[0];
      var upperMedian = smallArray1[1] < smallArray2[1] ? smallArray1[1] : smallArray2[1];

      return (lowerMedian + upperMedian) / 2.0;
    }

    // Removes lower half of array with lowest median
    // and highest half of array with highest median
    // until each array is length 2
    private Tuple<int[], int[]> SplitByMedianRecursive(int[] array1, int[] array2)
    {
      var numItems = array1.Length;
      if (numItems <= 2)
      {
        return new Tuple<int[], int[]>(array1, array2);
      }
      var numItemsToRemove = (int)Math.Floor((numItems - 1) / 2.0);
      var array1Median = Median(array1);
      var array2Median = Median(array2);
      var resultArray1 = new int[numItems - numItemsToRemove];
      var resultArray2 = new int[numItems - numItemsToRemove];
      if (array1Median > array2Median)
      {
        Array.Copy(array1, 0, resultArray1, 0, numItems - numItemsToRemove);
        Array.Copy(array2, numItemsToRemove, resultArray2, 0, numItems - numItemsToRemove);
      }
      else
      {
        Array.Copy(array1, numItemsToRemove, resultArray1, 0, numItems - numItemsToRemove);
        Array.Copy(array2, 0, resultArray2, 0, numItems - numItemsToRemove);
      }

      return SplitByMedianRecursive(resultArray1, resultArray2);
    }

    private double Median(int[] input)
    {
      var totalLength = input.Length;
      var isOdd = (totalLength % 2) > 0;
      if (isOdd)
      {
        var index = ((totalLength + 1) / 2) - 1;
        return input[index];
      }
      else
      {
        var index = totalLength / 2;
        var result = (input[index] + input[index - 1]) / 2.0;
        return result;
      }
    }
  }
}