using System.Collections.Generic;
using NUnit.Framework;

namespace Examples.Codility.BinaryGap
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
    public void CalculateBinaryGap_Inputs1041_Returns5()
    {
      var N = 1041;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(5, result);
    }

    [Test]
    public void CalculateBinaryGap_Inputs15_Returns0()
    {
      var N = 15;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(0, result);
    }

    [Test]
    public void CalculateBinaryGap_Inputs32_Returns0()
    {
      var N = 32;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(0, result);
    }

    [Test]
    public void CalculateBinaryGap_InputExtremes1_Returns0()
    {
      var N = 1;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(0, result);
    }

    [Test]
    public void CalculateBinaryGap_InputExtremes5_Returns1()
    {
      var N = 5;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(1, result);
    }

    [Test]
    public void CalculateBinaryGap_InputExtremesMax_Returns0()
    {
      var N = int.MaxValue;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(0, result);
    }

    [Test]
    public void CalculateBinaryGap_InputTrailingZeros6_Returns0()
    {
      var N = 6;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(0, result);
    }

    [Test]
    public void CalculateBinaryGap_InputTrailingZeros328_Returns2()
    {
      var N = 328;

      var result = _solution.CalculateBinaryGap(N);

      Assert.AreEqual(2, result);
    }

  }
}