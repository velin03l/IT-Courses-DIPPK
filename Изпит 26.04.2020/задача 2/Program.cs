using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            for (int i = 0; i <= n.Length - 1; i++)
            {
                if (n[i] % 10 == 4 || n[i] % 10 == 8)
                {
                    list1.Add(n[i]);
                }
                if (n[i] % 10 == 5 || n[i] % 10 == 7)
                {
                    list2.Add(n[i]);
                }
                if (n[i] % 10 + ((n[i] % 1000 - n[i] % 100) / 100) + ((n[i] % 100 - n[i] % 10) / 10) == 15)
                {
                    list3.Add(n[i]);
                }
            }
            Console.WriteLine(string.Join(", ", list1));
            Console.WriteLine(string.Join(", ", list2));
            Console.WriteLine(string.Join(", ", list3));
        }
    }
}