using System;
using System.Collections;

namespace Module3HW1.Collection
{
    public class List<T> : IEnumerable
    {
        private T[] _array;

        public List()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            var newArray = new T[_array.Length + 1];
            for (var i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            newArray[newArray.Length - 1] = item;
            _array = newArray;
        }

        public void AddRange(T[] array)
        {
            foreach (var item in array)
            {
                Add(item);
            }
        }

        public void AddRange(List<T> list)
        {
            foreach (T item in list)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    RemoveAt(i);

                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _array.Length)
            {
                return;
            }

            var newArray = new T[_array.Length - 1];
            for (var i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            for (var i = index; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + 1];
            }

            _array = newArray;
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(_array, comparer);
        }

        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < _array.Length; i++)
            {
                yield return _array[i];
            }

            yield break;
        }
    }
}
