using System.Collections.Generic;
using NUnit.Framework;

namespace Examples.Codility.PermMissingElem
{
  [TestFixture]
  public class Tests
  {
    private readonly Solution _solution;

    public Tests()
    {
      _solution = new Solution();
    }

    [Test]
    public void CalculateBinaryGap_InputsEmpty_Returns1()
    {
      var A = new int[] { };

      var result = _solution.FindMissingElement(A);

      Assert.AreEqual(1, result);
    }

    [Test]
    public void CalculateBinaryGap_InputsSingleValue_ReturnsCorrectResult()
    {
      var A = new int[] { 1 };

      var result = _solution.FindMissingElement(A);

      Assert.AreEqual(2, result);
    }

    [Test]
    public void CalculateBinaryGap_InputsMissingFirst_ReturnsFirst()
    {
      var A = new int[] { 2, 3, 4, 5, 6 };

      var result = _solution.FindMissingElement(A);

      Assert.AreEqual(1, result);
    }

    [Test]
    public void CalculateBinaryGap_InputsMissingLast_ReturnsLast()
    {
      var A = new int[] { 1, 2, 3, 4, 5 };

      var result = _solution.FindMissingElement(A);

      Assert.AreEqual(6, result);
    }



    [Test]
    public void CalculateBinaryGap_InputLarge_ReturnsCorrectResult()
    {
      var inputSize = 2000000;
      var A = new int[inputSize];
      var j = 1;
      for (var i = 0; i < inputSize; i++)
      {
        A[i] = j;
        j++;
        if (j == 6)
        {
          j++;
        }
      }

      var result = _solution.FindMissingElement(A);

      Assert.AreEqual(6, result);
    }

  }
}