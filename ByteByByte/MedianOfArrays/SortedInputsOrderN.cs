namespace Examples.ByteByByte.MedianOfArrays
{
  public class SortedInputsOrderN : ISolution
  {
    public double Median(int[] array1, int[] array2)
    {
      var totalLength = array1.Length + array2.Length;

      if (totalLength == 0) return 0;

      var isOdd = (totalLength % 2) > 0;
      var highestIndexRequired = isOdd ? ((totalLength + 1) / 2) - 1 : totalLength / 2;

      var array1Pointer = 0;
      var array2Pointer = 0;
      var highestValue = 0;
      var secondHighestValue = 0;
      for (var i = 0; i <= highestIndexRequired; i++)
      {
        secondHighestValue = highestValue;
        var array1Value = array1Pointer >= array1.Length ? (int?)null : array1[array1Pointer];
        var array2Value = array2Pointer >= array2.Length ? (int?)null : array2[array2Pointer];
        if (array1Value == null || array2Value < array1Value)
        {
          highestValue = array2[array2Pointer];
          array2Pointer++;
        }
        else
        {
          highestValue = array1[array1Pointer];
          array1Pointer++;
        }
      }
      var result = isOdd ? highestValue : (highestValue + secondHighestValue) / 2.0;
      return result;
    }
  }
}