using System.Collections.Generic;
using NUnit.Framework;

namespace Examples.ByteByByte.Duplicates
{
  [TestFixture]
  public class Tests
  {
    private readonly ISolution _solution;

    public Tests()
    {
      _solution = new Solution();
    }

    [Test]
    public void Duplicates_InputsExample1_ReturnsCorrectResult()
    {
      var items = new int[] { 1, 2, 3 };

      var result = _solution.FindDuplicates(items);

      CollectionAssert.AreEquivalent(new HashSet<int> { }, result);
    }

    [Test]
    public void Duplicates_InputsExample2_ReturnsCorrectResult()
    {
      var items = new int[] { 1, 2, 2 };

      var result = _solution.FindDuplicates(items);

      CollectionAssert.AreEquivalent(new HashSet<int> { 2 }, result);
    }

    [Test]
    public void Duplicates_InputsExample3_ReturnsCorrectResult()
    {
      var items = new int[] { 3, 3, 3 };

      var result = _solution.FindDuplicates(items);

      CollectionAssert.AreEquivalent(new HashSet<int> { 3 }, result);
    }

    [Test]
    public void Duplicates_InputsExample4_ReturnsCorrectResult()
    {
      var items = new int[] { 2, 1, 2, 1 };

      var result = _solution.FindDuplicates(items);

      CollectionAssert.AreEquivalent(new HashSet<int> { 1, 2 }, result);
    }

  }
}