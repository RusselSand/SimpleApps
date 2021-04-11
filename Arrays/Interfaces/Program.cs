using System;
using System.Collections.Generic;

namespace Interfaces
{

    static class MyExtensions
    {
        public static List<T> AddItems<T>(this List<T> list, params T[] array) {
            foreach (T element in array)
            {
                list.Add(element);
            }
            return list;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>().AddItems(1, 2, 3);
            foreach (int element in intList)
            {
                Console.WriteLine(element);
            }
            var strList = new List<string>().AddItems("one").AddItems("two");
            foreach (string element in strList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
