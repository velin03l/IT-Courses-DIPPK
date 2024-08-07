using System;
using System.Collections.Generic;
using System.Text;

public class Store
{
    private string name;
    private string type;
    private double revenue;
    private List<Product> products = new List<Product>();
    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value == "" || value == null)
            {
                throw new ArgumentException("Store name must not be null or empty!");
            }
            this.name = value;
        }
    }
    public string Type
    {
        get { return this.type; }
        private set
        {
            if (value == "" || value == null)
            {
                throw new ArgumentException("Store type must not be null or empty!");
            }
            this.type = value;
        }
    }
    public double Revenue
    {
        get { return this.revenue; }
        private set { this.revenue = value; }
    }
    public Store(string name, string type)
    {
        this.Name = name;
        this.Type = type;
        this.Revenue = 0;
        this.products = new List<Product>();
    }
    public bool ReceiveProduct(Product product)
    {
        if (products.Contains(product))
        {
            return false;
        }
        else
        {
            products.Add(product);
            return true;
        }
    }
    public bool SellProduct(string name, int quantity)
    {
        for(int i=0; i<products.Count; i++)
        {
            if(products[i].Name == name && products[i].Quantity >= quantity)
            {
                this.Revenue = this.Revenue + quantity * products[i].FinalPrice;
                products[i].Quantity = products[i].Quantity - quantity;
                if(products[i].Quantity == 0)
                {
                    Product product = products[i];
                    products.Remove(product);
                }
                return true;
            }
        }
        return false;        
    }
    public Product GetProduct(string name)
    {
        for(int i=0; i<products.Count; i++)
        {
            if(products[i].Name == name)
            {
                Product product = products[i];
                return product;
            }
        }
        return null;
    }
    public override string ToString()
    {
        string a = $"****Store: {this.Name} <{this.Type}>" + "\n";
        a = a + $"****Available products: <{products.Count}>" + "\n";
        for(int i=0; i<products.Count; i++)
        {
            a = a + $"****** {products[i].Name} ({products[i].Quantity})" + "\n";
        }
        a = a + $"****Revenue: <{this.Revenue:F2}BGN>";
        return a;
    }
}
