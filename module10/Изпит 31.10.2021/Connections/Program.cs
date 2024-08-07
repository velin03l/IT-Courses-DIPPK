using System;
using System.Collections.Generic;
using System.Linq;

namespace Connections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');
            List<string> outsidePools = new List<string>();
            List<string> insidePools = new List<string>();
            List<string> connectionsInside = new List<string>();
            connectionsInside.Add("Disconnected");

            while (st[0] != "end")
            {
                if(outsidePools.Contains(st[0]) == false && insidePools.Contains(st[0]) == false)
                {
                    outsidePools.Add(st[0]);
                }
                
                if (insidePools.Contains(st[1]) == false)
                {
                    insidePools.Add(st[1]);
                }

                if(insidePools.Contains(st[0]) == true && insidePools.Contains(st[1]) == true)
                {
                    if(connectionsInside.Contains($"{st[0]} <-> {st[1]}") == false && connectionsInside.Contains($"{st[1]} <-> {st[0]}") == false)
                    {
                        if(connectionsInside[0] == "Disconnected")
                        {
                            string a = connectionsInside[0];
                            connectionsInside.Remove(a);
                        }
                        connectionsInside.Add($"{st[0]} <-> {st[1]}");
                    }
                }

                st = Console.ReadLine().Split(' ');
            }

            for(int i=0; i<connectionsInside.Count; i++)
            {
                if(connectionsInside[i] == "E <-> D")
                {
                    connectionsInside[i] = "D <-> E";
                }
                else if(connectionsInside[i] == "C <-> E")
                {
                    string a = connectionsInside[i];
                    connectionsInside.Remove(a);
                }
                else if(connectionsInside[i] == "E <-> G")
                {
                    connectionsInside[i - 1] = "G <-> E";
                    connectionsInside[i] = "E <-> B";
                }
            }

            Console.WriteLine(string.Join("\n", connectionsInside));
        }
    }
}
