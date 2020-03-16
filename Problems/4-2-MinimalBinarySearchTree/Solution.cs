using System;

namespace Examples.Problems.MinimalBinarySearchTree
{

  public class BinarySearchNode
  {
    public int Data { get; set; }
    public BinarySearchNode LeftChild { get; set; }
    public BinarySearchNode RightChild { get; set; }

    public BinarySearchNode(int data)
    {
      Data = data;
    }
    public BinarySearchNode(int data, BinarySearchNode leftChild, BinarySearchNode rightChild)
    {
      Data = data;
      LeftChild = leftChild;
      RightChild = rightChild;
    }
  }
  public class Solution
  {

    public BinarySearchNode CreateBinarySearchTree(int[] sortedArray)
    {
      return CreateBinarySearchTree(sortedArray, 0, sortedArray.Length);
    }
    public BinarySearchNode CreateBinarySearchTree(int[] sortedArray, int startIndex, int count)
    {
      if (count == 0) return null;
      if (count == 1) return new BinarySearchNode(sortedArray[startIndex]);

      var middleIndex = GetMiddleIndex(startIndex, count);
      var middleValue = sortedArray[middleIndex];

      var rightChildStartIndex = middleIndex + 1;
      var rightChildCount = count - (rightChildStartIndex - startIndex);
      var leftChildCount = middleIndex - startIndex;

      Console.WriteLine($"Middle Index: {middleIndex}, Middle Value: {middleValue}, Right Start: {rightChildStartIndex}, Right Count: {rightChildCount}, Left Count: {leftChildCount}");

      var leftNode = CreateBinarySearchTree(sortedArray, startIndex, leftChildCount);
      var rightNode = CreateBinarySearchTree(sortedArray, rightChildStartIndex, rightChildCount);

      return new BinarySearchNode(middleValue, leftNode, rightNode);

    }

    public int GetMiddleIndex(int startIndex, int count)
    {
      return startIndex + (count / 2);
    }
  }
}