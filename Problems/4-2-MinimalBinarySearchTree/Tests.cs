using System.Collections.Generic;
using NUnit.Framework;

namespace Examples.Problems.MinimalBinarySearchTree
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
    public void CreateBinarySearchTree_InputsExampleWithOddCount_ReturnsCorrectResult()
    {
      var items = new int[] { 1, 2, 3, 4, 5, 6, 7 };

      var root = _solution.CreateBinarySearchTree(items);

      Assert.AreEqual(4, root.Data);
      Assert.AreEqual(2, root.LeftChild.Data);
      Assert.AreEqual(6, root.RightChild.Data);
      Assert.AreEqual(1, root.LeftChild.LeftChild.Data);
      Assert.AreEqual(3, root.LeftChild.RightChild.Data);
      Assert.AreEqual(5, root.RightChild.LeftChild.Data);
      Assert.AreEqual(7, root.RightChild.RightChild.Data);
    }

    [Test]
    public void CreateBinarySearchTree_InputsExampleWithGap_ReturnsCorrectResult()
    {
      var items = new int[] { 1, 2, 3, 6, 7, 8, 9 };

      var root = _solution.CreateBinarySearchTree(items);

      Assert.AreEqual(6, root.Data);
      Assert.AreEqual(2, root.LeftChild.Data);
      Assert.AreEqual(8, root.RightChild.Data);
      Assert.AreEqual(1, root.LeftChild.LeftChild.Data);
      Assert.AreEqual(3, root.LeftChild.RightChild.Data);
      Assert.AreEqual(7, root.RightChild.LeftChild.Data);
      Assert.AreEqual(9, root.RightChild.RightChild.Data);
    }

    [Test]
    public void CreateBinarySearchTree_InputsExampleWithEvenCount_ReturnsCorrectResult()
    {
      var items = new int[] { 1, 2, 3, 4, 5, 6 };

      var root = _solution.CreateBinarySearchTree(items);

      Assert.AreEqual(4, root.Data);
      Assert.AreEqual(2, root.LeftChild.Data);
      Assert.AreEqual(6, root.RightChild.Data);
      Assert.AreEqual(1, root.LeftChild.LeftChild.Data);
      Assert.AreEqual(3, root.LeftChild.RightChild.Data);
      Assert.AreEqual(5, root.RightChild.LeftChild.Data);
      Assert.AreEqual(null, root.RightChild.RightChild);
    }

  }
}