using NUnit.Framework;

namespace Examples.ByteByByte.Knapsack
{
  [TestFixture]
  public class Tests
  {
    private readonly ISolution _solution;

    public Tests()
    {
      _solution = new Dynamic();
    }

    [Test]
    public void Knapsack_InputsExample_ReturnsCorrectResult()
    {
      var items = new KnapsackItem[] { new KnapsackItem(1, 6), new KnapsackItem(2, 10), new KnapsackItem(3, 12) };
      var maxWeight = 5;

      var result = _solution.MaxValue(items, maxWeight);

      Assert.AreEqual(22, result);
    }

  }
}