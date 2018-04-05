using System;

namespace EPAM.Stack
{
    public sealed class Stack<T>
    {
        private T[] innerArray;

        private const int defaultCapacity = 4;

        public static int Version { get; private set; }

        public int Capacity { get; private set; }

        public Stack() : this(defaultCapacity)
        {

        }

        public Stack(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException(nameof(capacity));
            }

            Capacity = capacity;
            innerArray = new T[capacity];
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (Count == Capacity)
            {
                Capacity *= 2;

                T[] tempArray = innerArray;

                Array.Resize(ref innerArray, Capacity);
                Array.Copy(tempArray, innerArray, Count);
            }

            innerArray[Count++] = item;
            Version++;

        }

        public T Pop()
        {
            if (innerArray.Length < 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T item = innerArray[--Count];
            innerArray[Count] = default(T);
            Version++;

            return item;
        }

        public T Peek()
        {
            if (innerArray.Length < 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            T item = innerArray[Count - 1];

            return item;
        }

        public void Trim()
        {
            Capacity = Count;

            Array.Resize(ref innerArray, Capacity);
        }
    }
}