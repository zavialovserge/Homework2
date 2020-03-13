using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    public class CustomList<T> : IEnumerable, IEnumerator
    {
        private T[] _elements;
        public int _count = 0;
        private int _current = -1;
        public CustomList()
        {
            _elements = new T[4];
        }
        public CustomList(int capacity)
        {
            _elements = new T[capacity];
        }

        public void Add(T element)
        {

            if (_count >= _elements.Length)
            {
                Array.Resize(ref _elements, _elements.Length * 2);
            }

            _elements[_count] = element;

            ++_count;
        }
        public T Current => _elements[_current];

        object IEnumerator.Current => Current;

        public IEnumerator GetEnumerator() { return _elements.GetEnumerator(); }
        public void RemoveAt(int index)
        {
            if (index < 0)
                return;
            if (index >= _elements.Length) return;

            for (var i = index; i < _elements.Length-1; i++)
            {
                _elements[i] = _elements[i+1];
            }

            //_current = -1;
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(_elements, item);
        }
        public bool MoveNext()
        {
            ++_current;

            return _current < _count;
            //if (_count < _elements.Length - 1)
            //{
            //    _count++;
            //    return true;
            //}
            //else
            //{
            //    Reset();
            //    return false;
            //}
        }

        public void Reset()
        {
            _current = -1;
        }


    }
}
