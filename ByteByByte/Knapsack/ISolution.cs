namespace Examples.ByteByByte.Knapsack
{
  public interface ISolution
  {
    int MaxValue(KnapsackItem[] items, int maxWeight);
  }

  public class KnapsackItem
  {
    public int Weight { get; set; }
    public int Value { get; set; }

    public KnapsackItem(int weight, int value)
    {
      this.Weight = weight;
      this.Value = value;
    }
  }
}