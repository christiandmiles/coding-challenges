using System;

namespace Examples.ByteByByte.Knapsack
{
  public class Dynamic : ISolution
  {
    // This solution constructs the following matrix
    // You either take the value 1 row above, or you add the new weight to the value 1 row up, and w rows left
    // O(i*w)
    //    0   1   2   3   4   5  Weight
    // 0 [0,  0,  0,  0,  0,  0]
    // 1 [0,  6,  6,  6,  6,  6]
    // 2 [0,  6, 10, 16, 16,  16]
    // 3 [0,  6, 10, 16, 18,  22]
    // Items
    public int MaxValue(KnapsackItem[] items, int maxWeight)
    {
      int[,] cache = new int[items.Length + 1, maxWeight + 1];
      for (int i = 1; i <= items.Length; i++)
      {
        for (int j = 0; j <= maxWeight; j++)
        {
          // If including item[i-1] would exceed max Weight j, don't 
          // include the item. Otherwise take the max Value of including
          // or excluding the item
          if (items[i - 1].Weight > j) cache[i, j] = cache[i - 1, j];
          else cache[i, j] = Math.Max(cache[i - 1, j], cache[i - 1, j - items[i - 1].Weight] + items[i - 1].Value);
        }
      }

      return cache[items.Length, maxWeight];
    }
  }
}