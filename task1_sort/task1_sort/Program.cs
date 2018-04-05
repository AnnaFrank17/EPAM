using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;


namespace task1_sort
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MySet2 test = new MySet2();
            
            test.Add(20);
            test.Add(10);
            test.Add(8);
            Console.WriteLine("All int elements");
            test.Show();

            test.Remove(20);
            Console.WriteLine("Elements after remove");
            test.Show();
            Console.WriteLine();

            MyGeneric3<string> str= new MyGeneric3<string>();

            str.Add("first");
            str.Add("second");
            str.Add("third");
            Console.WriteLine("All string elements");
            str.Show();

            str.Remove("second");
            Console.WriteLine("Elements after remove");
            str.Show();

            MergSort sort = new MergSort();
            Console.WriteLine("Array: ");
            int[] arr = new[] {2, 8, 6, 4, 5, 3, 1, 12};
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            sort.Sort(arr);
            Console.WriteLine("Merge sort");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Performance");
            Console.WriteLine(Math.Log(arr.Length));
        }
    }
}
