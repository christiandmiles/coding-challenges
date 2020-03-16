using NUnit.Framework;

namespace Examples.ByteByByte.MedianOfArrays
{
  [TestFixture]
  public class Tests
  {
    private readonly ISolution _solution;

    public Tests()
    {
      _solution = new SortedInputsOrderLogN();
    }

    [Test]
    public void Median_InputIsEven_ReturnCorrectAnswer()
    {
      var arr1 = new int[] { 1, 3, 5 };
      var arr2 = new int[] { 2, 4, 6 };

      var result = _solution.Median(arr1, arr2);

      Assert.AreEqual(3.5, result);
    }

    [Test]
    public void Median_InputIsOdd_ReturnCorrectAnswer()
    {
      var arr1 = new int[] { 1, 3, 5 };
      var arr2 = new int[] { 2, 4 };

      var result = _solution.Median(arr1, arr2);

      Assert.AreEqual(3.0, result);
    }


    [Test]
    public void Median_InputLongerExample_ReturnCorrectAnswer()
    {
      var arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
      var arr2 = new int[] { 0, 0, 0, 0, 10, 10 };

      var result = _solution.Median(arr1, arr2);

      Assert.AreEqual(2.5, result);
    }

    [Test]
    public void Median_InputsAreEmpty_ReturnZero()
    {
      var arr1 = new int[] { };
      var arr2 = new int[] { };

      var result = _solution.Median(arr1, arr2);

      Assert.AreEqual(0, result);
    }

    [Test]
    public void Median_SingleInput_ReturnSingleValue()
    {
      var arr1 = new int[] { 1 };
      var arr2 = new int[] { };

      var result = _solution.Median(arr1, arr2);

      Assert.AreEqual(1, result);
    }
  }
}