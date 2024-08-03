using System;
using System.Collections.Generic;
using System.Text;

namespace ITCareer_OOP_Exam_1
{
    class Car
    {
        private int number;
        private double price;
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public double Price
        {
            get { return this.price; }
            set 
            {
                if (value < 1000) { throw new ArgumentException("Invalid car price!"); }
                this.price = value; 
            }
        }
        public Car(int number, double price)
        {
            this.Number = number;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Car number {this.Number} costs {this.Price.ToString("F2")}";
        }
    }
}
