using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] string1 = Console.ReadLine().Split(' ');
            char[] input = new char[string1.Length];
            for(int j = 0; j<string1.Length; j++)
            {
                input[j] = char.Parse(string1[j]);
            }

            int i = input.Length;
            string st = Console.ReadLine();
            List<string> list = new List<string>();
            list.Add("No permutations...");
            List<char> list1 = new List<char>();

            while (st != "end")
            {
                if(st.Length == i)
                {
                    list1 = new List<char>();
                    for (int j = 0; j < i; j++)
                    {                        
                        for (int k = 0; k < i; k++)
                        {
                            if (input[j] == st[k])
                            {
                                if (list1.Contains(st[k]) == false)
                                { 
                                    list1.Add(st[k]);
                                }
                            }
                        }
                    }

                    if(list1.Count == i)
                    {                        
                        if(list[0] == "No permutations...")
                        {
                            string a = list[0];
                            list.Remove(a);
                        }
                        list.Add(st);
                    }
                }

                st = Console.ReadLine();
            }

            

            for (int j = 0; j < list.Count; j++)
            {
                string a = list[j];
                string st1 = "";
                for(int k=0; k < a.Length; k++)
                {
                    st1 = st1 + a[k] + " ";
                }
                list[j] = st1;
            }

            Console.WriteLine(string.Join("\n", list));
        }
    }
}