using System;

namespace Examples.ByteByByte.MatrixProduct
{
  public class CachedSolution : ISolution
  {
    public int MaxProduct(int[,] matrix)
    {
      var maxValues = new int[matrix.GetLength(0), matrix.GetLength(1)];
      var minValues = new int[matrix.GetLength(0), matrix.GetLength(1)];
      for (var i = 0; i < matrix.GetLength(0); i++)
      {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
          if (i == 0 && j == 0)
          {
            maxValues[i, j] = matrix[i, j];
            minValues[i, j] = matrix[i, j];
          }
          else if (i == 0)
          {
            maxValues[i, j] = Math.Max(maxValues[i, j - 1] * matrix[i, j], minValues[i, j - 1] * matrix[i, j]);
            minValues[i, j] = Math.Min(maxValues[i, j - 1] * matrix[i, j], minValues[i, j - 1] * matrix[i, j]);
          }
          else if (j == 0)
          {
            maxValues[i, j] = Math.Max(maxValues[i - 1, j] * matrix[i, j], minValues[i - 1, j] * matrix[i, j]);
            minValues[i, j] = Math.Min(maxValues[i - 1, j] * matrix[i, j], minValues[i - 1, j] * matrix[i, j]);
          }
          else
          {
            maxValues[i, j] = Math.Max(
              Math.Max(maxValues[i - 1, j] * matrix[i, j], maxValues[i, j - 1] * matrix[i, j]),
              Math.Max(minValues[i - 1, j] * matrix[i, j], minValues[i, j - 1] * matrix[i, j])
            );
            minValues[i, j] = Math.Min(
              Math.Min(maxValues[i - 1, j] * matrix[i, j], maxValues[i, j - 1] * matrix[i, j]),
              Math.Min(minValues[i - 1, j] * matrix[i, j], minValues[i, j - 1] * matrix[i, j])
            );
          }
        }
      }
      var result = maxValues[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      return result;
    }
  }
}