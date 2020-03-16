using NUnit.Framework;

namespace Examples.ByteByByte.MatrixProduct
{
  [TestFixture]
  public class Tests
  {
    private readonly ISolution _solution;

    public Tests()
    {
      _solution = new CachedSolution();
    }

    [Test]
    public void MatrxiProduct_InputsExample1_ReturnsCorrectResult()
    {
      var matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

      var result = _solution.MaxProduct(matrix);

      Assert.AreEqual(2016, result);
    }

    [Test]
    public void MatrxiProduct_InputsExample2_ReturnsCorrectResult()
    {
      var matrix = new int[3, 3] { { -1, 2, 3 }, { 4, 5, -6 }, { 7, 8, 9 } };

      var result = _solution.MaxProduct(matrix);

      Assert.AreEqual(1080, result);
    }

  }
}