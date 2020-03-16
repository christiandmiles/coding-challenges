using System;
using System.Collections.Generic;

namespace Examples.ByteByByte.Knapsack
{
  public class Recursive : ISolution
  {
    public int MaxValue(KnapsackItem[] items, int maxWeight)
    {
      return MaxValue(items, maxWeight, 0);
    }

    private int MaxValue(KnapsackItem[] items, int maxWeight, int i)
    {
      // Return when we reach the end of the list
      if (i == items.Length) return 0;

      // If item is heavier than remaining weight, skip item
      if (maxWeight - items[i].Weight < 0) return MaxValue(items, maxWeight, i + 1);

      // Try both including and excluding the current item
      return Math.Max(MaxValue(items, maxWeight - items[i].Weight, i + 1) + items[i].Value,
                      MaxValue(items, maxWeight, i + 1));
    }
  }
}