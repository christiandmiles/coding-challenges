namespace Examples.DataStructures
{
  public class StringBuilder
  {
    private ArrayList<string> _internalArray;

    public StringBuilder()
    {
      _internalArray = new ArrayList<string>();
    }

    public StringBuilder(string text)
    {
      _internalArray = new ArrayList<string>(new string[] { text });
    }

    public void Append(string text)
    {
      _internalArray.Add(text);
    }

    public override string ToString()
    {
      return string.Join("", _internalArray);
    }
  }
}