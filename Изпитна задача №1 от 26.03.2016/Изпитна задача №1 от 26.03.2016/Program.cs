using System;
using System.Collections.Generic;

namespace Изпитна_задача__1_от_26._03._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double ckgz = double.Parse(Console.ReadLine());
            double ckgp = double.Parse(Console.ReadLine());
            int kgz = int.Parse(Console.ReadLine());
            int kgp = int.Parse(Console.ReadLine());
            double sumeuro = (ckgz * kgz + ckgp * kgp) * 1.94;
            Console.WriteLine(sumeuro);
        }
    }
}
