using System;
using System.Collections.Generic;
using System.Text;

public class Drink:Product
{
    public Drink(string name, int quantity, double deliverPrice, double percentageMarkup):base(name, quantity, deliverPrice, percentageMarkup)
    {
        if(percentageMarkup>200)
        {
            throw new ArgumentException("Drink percentage markup cannot be above 200%!");
        }
    }
}

