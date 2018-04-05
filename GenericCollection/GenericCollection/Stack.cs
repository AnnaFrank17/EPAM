using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    public sealed class Stack<T>
    {
        private T[] innerArray;
        private int capacity;
        //  private int count;


        private const int defaultCapacity = 4;
        public Stack() : this(defaultCapacity)
        {

        }

        public Stack(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException(nameof(capacity));
            }

            this.capacity = capacity;
            innerArray = new T[capacity];
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (Count == capacity)
            {
                capacity *= 2;

                T[] tempArray = innerArray;

                Array.Resize(ref innerArray, capacity);
                Array.Copy(tempArray, innerArray,Count);
            }

            innerArray[Count++] = item;
         
        }

        public T Pop()
        {
            T item = innerArray[Count];
            capacity /= 2;

            T[] tempArray = innerArray;
            
            Array.Resize(ref innerArray, capacity);
            Array.Copy(tempArray, innerArray, --Count);

            return item;
        }
    }
}
