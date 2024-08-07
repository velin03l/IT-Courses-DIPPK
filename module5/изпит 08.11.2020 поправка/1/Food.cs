using System;
using System.Collections.Generic;
using System.Text;

public class Food:Product
{
    public Food(string name, int quantity, double deliverPrice, double percentageMarkup):base(name, quantity, deliverPrice, percentageMarkup)
    {
        if(percentageMarkup>100)
        {
            throw new ArgumentException("Foob percentage markup cannot be above 100%!");
        }
    }
}
