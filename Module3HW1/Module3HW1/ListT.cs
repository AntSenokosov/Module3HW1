using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1
{
    public class ListT<T>
    {
        private T[] _list;
        private int _count = 0;
        private int _position = -1;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Add(T item)
        {
            _count++;
            Array.Resize(ref _list, _count);
            _position++;
            _list[_position] = item;
        }

        public void AddRange(ICollection<T> collection)
        {
            foreach (T element in collection)
            {
                _count++;
                Array.Resize(ref _list, _count);
                _position++;
                _list[_position] = element;
            }
        }

        public bool Remove(T item)
        {
            foreach (T value in _list)
            {
                if (value.Equals(item))
                {
                    int index = Array.IndexOf(_list, item);
                    RemoveAt(index);
                    return true;
                }
            }

            return false;
        }

        public bool IndexList(int index)
        {
            if ((index < 0) || (index >= Count))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RemoveAt(int index)
        {
            if (IndexList(index) == false)
            {
                return false;
            }

            for (var i = index; i < _count - 1; i++)
            {
                _list[i] = _list[i + 1];
            }

            _list[_count - 1] = default(T);
            _count--;

            return true;
        }

        public void Sort()
        {
            Array.Sort(_list);
        }

        public IEnumerator GetEnumerator()
        {
            for (var i = 0; i < _count; i++)
            {
                yield return _list[i];
            }
        }
    }
}
