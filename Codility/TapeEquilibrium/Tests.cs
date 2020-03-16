using NUnit.Framework;

namespace Examples.Codility.TapeEquilibrium
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
    public void FindEquilibrium_InputIsSmallAndContainsNegatives_ReturnsCorrectSolution()
    {
      var input = new int[] { -1000, 1000 };

      var result = _solution.FindEquilibrium(input);

      Assert.AreEqual(2000, result);
    }
  }
}