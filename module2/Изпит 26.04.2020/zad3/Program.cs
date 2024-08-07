using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> st1 = new List<string>();
            List<string> st2 = new List<string>();
            for(int i = 1; i<=n; i++)
            {
                var st = Console.ReadLine();
                if (st1.Contains(st))
                {
                    st1.Remove(st);
                }
                if (st2.Contains(st))
                {
                    st2.Remove(st);
                }
                if (st[0] >= 'A' && st[0] <= 'Z' && st.Length > 7 && (st.Contains('i') || st.Contains('I')))
                {
                    st1.Add(st);
                }
                else { st2.Add(st); }
            }
            Console.WriteLine("Special words: " + string.Join(", ", st1));
            Console.WriteLine("Other words: " + string.Join(", ", st2));
        }
    }
}
