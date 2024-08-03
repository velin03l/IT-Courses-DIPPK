using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0.00;
            for(int i=1; i<=n; i++)
            {
                var st = Console.ReadLine();
                switch(st)
                {
                    case "t-shirt": sum = sum + 20.00; break;
                    case "jeans": sum = sum + 50.00; break;
                    case "trainers": sum = sum + 70.00; break;
                    case "jacket": sum = sum + 60.00; break;
                }
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
