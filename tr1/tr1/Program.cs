using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tr1
{
    class Program
    {
        static void Main()
        {

            int[] array = { 11, 12, 123, 165, 156, 169, 18 };
            //  array.Dump();
            IPredicate<int> predicate = new PredicateDigit7();
            int[] result = array.FilterNumbers(predicate);
            string[] arrString = { "rgefds", "bdf" };
            string[] result1 = new arrString.FilterNumbers(new PredicateStringLengh());
        }
    }

    
    public interface IPredicate<T>
    {
        bool IsMach(int number);
    }

    public class PredicateDigit7: IPredicate<int>
    {
        public bool IsMach(int number) => IsDigit(Math.Abs(number), 7);

        public static bool IsDigit(int number, int digit) //как то дописать метод надо и возможно все заработает
        {

            while (number != 0)
            {

                int t = number % 10;
                if (t == 0) { }
                if (number < 0 || number > 9 ){ throw new ArgumentOutOfRangeException(); }
                
            }
            return true;
        }

    }

    public static class ArrayExtention
    {
        public static T[] FilterNumbers(this T[] sourse, IPredicate<T> predicate)
        {

            if(sourse == null)
            {
                throw new ArgumentNullException($"The value of {nameof(sourse) } can not be null");
            }
            if (predicate == null)
            {
                throw new ArgumentNullException($"The value of {nameof(predicate) } can not be null");
            }

            List<T> list = new List<T>();

            for(int i = 0; i<sourse.Length; i++)
            {
                if (predicate.IsMach(sourse[i]))
                {
                    list.Add(sourse[i]);
                }
            }
            return list.ToArray();
        }

    }

    public class PredicateStringLengh : IPredicate<string>
    {

        public bool IsMach(string item) => item.Length == 3;
    }
}
