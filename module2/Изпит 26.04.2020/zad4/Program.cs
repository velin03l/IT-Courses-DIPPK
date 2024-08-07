using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(new string[] { " - " }, StringSplitOptions.None);
            SortedDictionary<string, int> sast = new SortedDictionary<string, int>();
            while (st[0] != "END")
            {                
                if(sast.ContainsKey(st[0]))
                {
                    sast[st[0]] = sast[st[0]] + int.Parse(st[1]);
                }
                else
                {
                    sast[st[0]] = int.Parse(st[2]);
                }
                st = Console.ReadLine().Split(new string[] { " - " }, StringSplitOptions.None);
            }
            foreach (KeyValuePair<string,int> x in sast)
            {
                Console.WriteLine("{0} -> {1}", x.Key, x.Value);
            }
        }
    }
}
