using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam_Pharmacy
{
    class Medicine
    {
        private string name;
        private double price;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set 
            {
                if(value<0)
                {
                    throw new ArgumentException("Invalid price");
                }
                this.price = value;
            }
        }
        public Medicine(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Medicine: {this.Name} with price {this.Price:f2}";
        }
    }
}
