using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StoreController
{
    private List<Store> stores = new List<Store>();
    public string CreateStore(List<string> args)
    {        
        if (stores.Any(x => x.Name == args[0]))
        {
            return $"Store {args[0]} is already registered!";
        }
        else
        {
            Store store = new Store(args[0], args[1]);
            stores.Add(store);
            return $"Store {store.Name} was successfully registerd in the system!";
        }
    }
    public string ReceiveProduct(List<string> args)
    {
        string type = args[0];
        string name = args[1];
        int quantity = int.Parse(args[2]);
        double price = double.Parse(args[3]);
        double percentageMarkup = double.Parse(args[4]);
        string storeName = args[5];
        Product product;
        if (type == "Food")
        {
            product = new Food(name, quantity, price, percentageMarkup);
        }
        else if (type == "Drink")
        {
            product = new Drink(name, quantity, price, percentageMarkup);
        }
        else { return $"Product {type} is invalid!"; }
        List<string> list = new List<string>();
        for (int i = 0; i < stores.Count; i++)
        {
            list.Add(stores[i].Name);
        }
        if(list.Contains(storeName))
        {
            int br = 0;
            for(int i=0; i<list.Count; i++)
            {
                if(list[i] == storeName)
                {
                    br = i;
                }
            }
            if (stores[br].ReceiveProduct(product) == true)
            {
                return $"Product {product.Name} was successfully delivered to {stores[br].Name}!";
            }
            else
            {
                return $"Product {product.Name} was already delivered to {storeName}!";
            }
        }
        else
        {
            return $"Invalid Store: {storeName}. Cannot find it in system!";
        }
    }
    public string SellProduct(List<string> args)
    {
        string name = args[0];
        int quantity = int.Parse(args[1]);
        string storeName = args[2];
        List<string> list = new List<string>();
        for (int i = 0; i < stores.Count; i++)
        {
            list.Add(stores[i].Name);
        }
        if (list.Contains(storeName))
        {
            int br = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == storeName)
                {
                    br = i;
                }
            }
            if(stores[br].SellProduct(name, quantity) == true)
            {
                return $"Product {name} was successfully bought from {stores[br].Name}!";
            }
            else { return $"Product {name} was already sold out!"; }
        }
        else { return $"Invalid Store: {storeName}. Cannot find it in system!"; }
    }
    public string StoreInfo(List<string> args)
    {
        List<string> list = new List<string>();
        for (int i = 0; i < stores.Count; i++)
        {
            list.Add(stores[i].Name);
        }
        if (list.Contains(args[0]))
        {
            int br = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == args[0])
                {
                    br = i;
                }
            }
            return stores[br].ToString();
        }
        else { return $"Invalid Store: {args[0]}. Cannot find it in system!"; }
    }
    public string Shutdown()
    {
        stores = stores.OrderByDescending(x => x.Revenue).ThenBy(y => y.Name).ToList();
        string a = $"Stores: {stores.Count}" + "\n";
        double revenues = 0;
        for (int i=0; i<stores.Count; i++)
        {
            a = a + stores[i].ToString() + "\n";
            revenues = revenues + stores[i].Revenue;
        }
        a = a + $"System Store Revenues: {revenues:F2}BGN";
        return a;
    }
}
