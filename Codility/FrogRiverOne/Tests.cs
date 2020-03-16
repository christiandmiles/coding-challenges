using NUnit.Framework;

namespace Examples.Codility.FrogRiverOne
{
  [TestFixture]
  public class Tests
  {
    private Solution _solution;

    public Tests()
    {
      _solution = new Solution();
    }

    [Test]
    public void CalculateCrossingTime_GivenExample_ReturnsCorrectResult()
    {
      var input = new int[] { 1, 3, 4, 2, 3, 2, 5 };
      var distance = 5;

      var result = _solution.CalculateCrossingTime(distance, input);

      Assert.AreEqual(6, result);
    }

  }
}