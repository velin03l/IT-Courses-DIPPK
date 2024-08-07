using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public abstract class Product
{
    private string name;
    private int quantity;
    private double deliverPrice;
    private double percentageMarkup;
    public string Name
    {
        get { return this.name; }
        private set
        {
            if(value == "" ||  value == null)
            {
                throw new ArgumentException("Product name must not be null or empty!");
            }
            this.name = value;
        }
    }
    public int Quantity
    {
        get { return this.quantity; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Quantity cannot be less or equal to 0!");
            }
            this.quantity = value;
        }
    }
    public double DeliverPrice
    {
        get { return this.deliverPrice; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Deliver price cannot be less or equal to 0!");
            }
            this.deliverPrice = value;
        }
    }
    public double PercentageMarkup
    {
        get { return this.percentageMarkup; }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
            }
            this.percentageMarkup = value;
        }
    }
    public double FinalPrice
    {
        get;
    }
    public Product(string name, int quantity, double deliverPrice, double percentageMarkup)
    {
        this.Name = name;
        this.Quantity = quantity;
        this.DeliverPrice = deliverPrice;
        this.PercentageMarkup = percentageMarkup;
        this.FinalPrice = DeliverPrice + (DeliverPrice * PercentageMarkup / 100);
    }
    public override string ToString()
    {
        string a = $"****Product: {this.Name} <{this.Quantity}>" + "\n";
        a = a + $"****Deliver Price: {this.DeliverPrice}" + "\n";
        a = a + $"****Percentage Markup: {this.PercentageMarkup}" + "\n";
        a = a + $"****Final Price: {this.FinalPrice}";
        return a;
    }
}

