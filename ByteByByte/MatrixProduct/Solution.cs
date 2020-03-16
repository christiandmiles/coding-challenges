using System;

namespace Examples.ByteByByte.MatrixProduct
{
  public class Solution : ISolution
  {
    public int MaxProduct(int[,] matrix)
    {
      var result = MaxProduct(matrix, 0, 0);
      Console.WriteLine(result);
      return result;
    }

    public int MaxProduct(int[,] matrix, int i, int j)
    {
      Console.WriteLine($"i:{i}/{matrix.GetLength(0)} j:{j}/{matrix.GetLength(1)}");
      if (matrix.GetLength(0) - 1 == i && matrix.GetLength(1) - 1 == j) return matrix[i, j];
      if (matrix.GetLength(0) - 1 == i) return MaxProduct(matrix, i, j + 1) * matrix[i, j];
      if (matrix.GetLength(1) - 1 == j) return MaxProduct(matrix, i + 1, j) * matrix[i, j];

      return Math.Max(MaxProduct(matrix, i + 1, j) * matrix[i, j], MaxProduct(matrix, i, j + 1) * matrix[i, j]);
    }
  }
}