using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Stack
{
    public class Enumerator<T>: IEnumerator<T>
    {
        private readonly T[] _collection;

        private int _index = -1;

        public int Length;

        public T Current => _collection[_index];

        object IEnumerator.Current => Current;

        public Enumerator(T[] arr)
        {
            _collection = arr;
            Length = arr.Length;
        }

        public void Dispose()
        {
            // Nothing to dispose.
        }

        public bool MoveNext()
        {
            _index++;
            return _index < Length;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
