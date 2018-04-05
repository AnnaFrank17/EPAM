using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
   public class MyGeneric3<T>
    {
        private T[] _numbers = new T[0];

        public void Add(T item)
        {
            if (Check_same(item))
            {
                throw new Exception("already exist!");
            }

            Array.Resize(ref _numbers, _numbers.Length + 1);
            _numbers[_numbers.Length - 1] = item;
        }

        public void Show()
        {
            foreach (T i in _numbers)
            {
                Console.WriteLine(i);
            }
        }

        public bool Check_same(T item)
        {
            foreach (T i in _numbers)
            {
                if (i.GetHashCode() == item.GetHashCode()) return true;
            }
            return false;

        }

        public void Remove(T item)
        {
            if (GetItemIfExist(item) == null)
            {
                throw new Exception("Element not exist");
            }
            _numbers = _numbers.Where(a => !a.Equals(item)).ToArray();
        }

        public T GetItemIfExist(T item)
        {
            return _numbers.FirstOrDefault(a => a.Equals(item));
        }
    }
}
