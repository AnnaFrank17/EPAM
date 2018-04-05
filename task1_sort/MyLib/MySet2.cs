using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class MySet2
    {

        private int[] _numbers = new int[0];

        public void Add(int item)
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
            foreach (int i in _numbers)
            {
                Console.WriteLine(i);
            }
        }

        public bool Check_same(int item)
        {
            foreach (int i in _numbers)
            {
                if (i == item) return true;
            }
            return false;

        }

        public void Remove(int item)
        {
            if (GetItemIfExist(item) == 0)
            {
                throw new Exception("Element not exist");
            }
            _numbers = _numbers.Where(a => !a.Equals(item)).ToArray();
        }

        public int? GetItemIfExist(int item)
        {
            return _numbers.FirstOrDefault(a => a.Equals(item));
        }
    }
}
