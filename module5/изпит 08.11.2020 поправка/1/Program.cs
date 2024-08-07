using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var st = Console.ReadLine().Split(':');
        StoreController storeController = new StoreController();
        while(st[0] != "Shutdown")
        {
            List<string> a = new List<string>();
            switch(st[0])
            {
                case "CreateStore":
                    a.Add(st[1]);
                    storeController.CreateStore(a);
                    break;
                case "ReceiveProduct":
                    for(int i=1; i<st.Length; i++)
                    {
                        a.Add(st[i]);
                    }
                    storeController.ReceiveProduct(a);
                    break;
                case "SellProduct":
                    for (int i = 1; i < st.Length; i++)
                    {
                        a.Add(st[i]);
                    }
                    storeController.SellProduct(a);
                    break;
                case "StoreInfo":
                    for (int i = 1; i < st.Length; i++)
                    {
                        a.Add(st[i]);
                    }
                    storeController.StoreInfo(a);
                    break;
            }
        }
        storeController.Shutdown();
    }
}
