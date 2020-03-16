using System;

namespace Examples.ByteByByte.MedianOfArrays
{
  public class SortedInputsOrderLogN : ISolution
  {
    public double Median(int[] array1, int[] array2)
    {
      if (array1.Length + array2.Length == 0) return 0;
      if (array1.Length == 0 || array2.Length == 0)
      {
        var array = array1.Length == 0 ? array2 : array1;
        return Median(array);
      }
      if (array1.Length == 1 && array2.Length == 1) return (array1[0] + array2[0]) / 2.0;


      var smallArray = array1.Length <= array2.Length ? array1 : array2;
      var largeArray = array1.Length > array2.Length ? array1 : array2;

      // split the arrays by their median until we have 2 length 2 arrays
      var (resultSmallArray, resultLargeArray) = SplitByMedianRecursive(smallArray, largeArray);

      if (resultSmallArray.Length == 0)
      {
        return Median(resultLargeArray);
        // case small: 1
      }
      else if (resultSmallArray.Length == 1)
      {
        // case small: 1, large: 1
        if (resultLargeArray.Length == 1)
        {
          return (resultSmallArray[0] + resultLargeArray[0]) / 2.0;
          // case small: 1, large: even
        }
        else if (resultLargeArray.Length % 2 == 0)
        {
          var index = resultLargeArray.Length / 2;
          if (resultSmallArray[0] < resultLargeArray[index])
          {
            return resultLargeArray[index];
          }
          else if (resultSmallArray[0] > resultLargeArray[index + 1])
          {
            return resultLargeArray[index + 1];
          }
          else
          {
            return resultSmallArray[0];
          }
          // case small: 1, large: odd
        }
        else
        {
          var index = (resultLargeArray.Length - 1 / 2);
          // case less than the item below large array median
          if (resultSmallArray[0] < resultLargeArray[index - 1])
          {
            return (resultLargeArray[index - 1] + resultLargeArray[index]) / 2.0;
            // case more than the item above large array median
          }
          else if (resultSmallArray[0] > resultLargeArray[index + 1])
          {
            return (resultLargeArray[index + 1] + resultLargeArray[index]) / 2.0;
            // case next to large array median
          }
          else
          {
            return (resultSmallArray[0] + resultLargeArray[index]) / 2.0;
          }
        }
        // case small: 2
      }
      else
      {
        // case small: 2, large: 2
        if (resultLargeArray.Length == 2)
        {
          var lowerMedian = resultSmallArray[0] > resultLargeArray[0] ? resultSmallArray[0] : resultLargeArray[0];
          var upperMedian = resultSmallArray[1] < resultLargeArray[1] ? resultSmallArray[1] : resultLargeArray[1];

          return (lowerMedian + upperMedian) / 2.0;
          // case small: 2, large: even
        }
        else if (resultLargeArray.Length % 2 == 0)
        {
          var arr = new int[]{
            resultLargeArray[resultLargeArray.Length / 2],
            resultLargeArray[resultLargeArray.Length / 2 - 1],
            Math.Max(resultSmallArray[0], resultLargeArray[resultLargeArray.Length / 2 - 2]),
            Math.Min(resultSmallArray[1], resultLargeArray[resultLargeArray.Length / 2 + 1])
          };
          return Median(arr);
          // case small: 2, large: odd
        }
        else
        {
          var index = (resultLargeArray.Length - 1) / 2;
          var valueLow = Math.Max(resultSmallArray[0], resultLargeArray[index - 1]);
          var valueHigh = Math.Min(resultSmallArray[1], resultLargeArray[index + 1]);

          if (resultLargeArray[index] >= valueLow && resultLargeArray[index] <= valueHigh)
          {
            return resultLargeArray[index];
          }
          else if (resultLargeArray[index] < valueLow && valueLow < valueHigh)
          {
            return valueLow;
          }
          else
          {
            return valueHigh;
          }
        }
      }
    }

    // Removes lower half of array with lowest median
    // and highest half of array with highest median
    // until each array is length 2
    private Tuple<int[], int[]> SplitByMedianRecursive(int[] smallArray, int[] largeArray)
    {
      var numItems = smallArray.Length;
      var largeArrayNumItems = largeArray.Length;
      if (numItems <= 2)
      {
        return new Tuple<int[], int[]>(smallArray, largeArray);
      }
      var numItemsToRemove = (int)Math.Floor((numItems - 1) / 2.0);
      var smallArrayMedian = Median(smallArray);
      var largeArrayMedian = Median(largeArray);
      var smallArrayResult = new int[numItems - numItemsToRemove];
      var largeArrayResult = new int[largeArrayNumItems - numItemsToRemove];
      if (smallArrayMedian > largeArrayMedian)
      {
        Array.Copy(smallArray, 0, smallArrayResult, 0, numItems - numItemsToRemove);
        Array.Copy(largeArray, numItemsToRemove, largeArrayResult, 0, largeArrayNumItems - numItemsToRemove);
      }
      else
      {
        Array.Copy(smallArray, numItemsToRemove, smallArrayResult, 0, numItems - numItemsToRemove);
        Array.Copy(largeArray, 0, largeArrayResult, 0, largeArrayNumItems - numItemsToRemove);
      }

      return SplitByMedianRecursive(smallArrayResult, largeArrayResult);
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