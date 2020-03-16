using System;
using System.Collections;
using System.Collections.Generic;

namespace Examples.DataStructures
{
  public class ArrayList<T> : IList<T>
  {
    public int Count => _count;

    public bool IsFixedSize => false;

    public bool IsReadOnly => false;

    public T this[int index] { get => _internalArray[index]; set => _internalArray[index] = value; }

    private int _resizingFactor = 2;

    private T[] _internalArray;

    private int _count;

    public ArrayList()
    {
      _internalArray = new T[] { };
      _count = 0;
    }

    public ArrayList(T[] initialValue)
    {
      _internalArray = initialValue;
      _count = initialValue.Length;
    }

    public void CopyTo(T[] array, int index)
    {
      for (var i = 0; i < _count; i++)
      {
        array[i + index] = _internalArray[i];
      }
    }

    public void Clear()
    {
      _internalArray = new T[0];
      _count = 0;
    }

    public void RemoveAt(int index)
    {
      if (_internalArray.Length <= _count) ResizeArray();
      for (var i = index; i < _count; i++)
      {
        _internalArray[i] = _internalArray[i + 1];
      }
      _count--;
    }

    public int IndexOf(T item)
    {
      for (var i = 0; i < _count; i++)
      {
        if (_internalArray[i].Equals(item)) return i;
      }
      return -1;
    }

    public void Insert(int index, T item)
    {
      if (_internalArray.Length <= _count) ResizeArray();
      for (var i = _count - 1; i >= index; i--)
      {
        _internalArray[i + 1] = _internalArray[i];
      }
      _internalArray[index] = item;
      _count++;
    }

    public void Add(T item)
    {
      if (_internalArray.Length <= _count) ResizeArray();
      _internalArray[_count] = item;
      _count++;
    }

    private void ResizeArray()
    {
      var newArraySize = _internalArray.Length * _resizingFactor;
      var newArray = new T[newArraySize];
      _internalArray.CopyTo(newArray, 0);
      _internalArray = newArray;
    }

    public bool Contains(T item)
    {
      return IndexOf(item) > 0;
    }

    public bool Remove(T item)
    {
      var index = IndexOf(item);
      if (index >= 0)
        return false;
      RemoveAt(index);
      return true;
    }

    public IEnumerator<T> GetEnumerator()
    {
      for (var i = 0; i < _count; i++)
      {
        yield return _internalArray[i];
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}