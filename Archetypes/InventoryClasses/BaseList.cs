using System;
using System.Collections;
using System.Collections.Generic;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.InventoryClasses
{
    public class BaseList<T> : Archetype, IList<T>
    {
        private List<T> list { get; } = new List<T>();

        public T this[int index]
        {
            get
            {
                return list[index];
            }

            set
            {
                list[index] = value;
            }
        }

        public int Count
        {
            get
            {
                List<T> t = new List<T>();
                return t.Count;
            }
        }

        public bool IsReadOnly { get; }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                var contains = list.Contains(item);
                return contains;
            }
            return true;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            var index = list.IndexOf(item);
            return index;
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            list.Remove(item);
            return true;
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
