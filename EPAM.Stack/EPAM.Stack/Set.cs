using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.Stack
{
    public class Set<T>
    {
        private IList<T> _set = new List<T>();

        public int Length => _set.Count;

        public void Add(T item)
        {
            if (_set.Contains(item))
            {
                throw new ArgumentException("Item already exist");
            }

            _set.Add(item);
        }

        public void Remove(T item)
        {
            if (!_set.Contains(item))
            {
                throw new IndexOutOfRangeException("Item didn't exist");
            }

            _set.Remove(item);
        }

        public T GetByIndex(int index)
        {
            if (index < 0 && index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            return _set[index];
        }

        public bool Contains(T item)
        {
            return _set.Contains(item);
        }
    }
}
