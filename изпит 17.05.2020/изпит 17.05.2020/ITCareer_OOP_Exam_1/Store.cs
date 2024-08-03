using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITCareer_OOP_Exam_1
{
    class Store
    {
        private string name;
        private List<Car> Car;
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value.Length < 5) { throw new ArgumentException("Invalid store name!"); }
                this.name = value; 
            }
        }
        public Store(string name)
        {
            this.Name = name;
            this.Car = new List<Car>();
        }
        public void AddCar(Car car)
        {
            Car.Add(car);
        }
        public bool SellCar(Car car) => this.Car.Remove(car);
        public double CalculateTotalPrice() => this.Car.Sum(a => a.Price);
        public Car GetCarWithHighestPrice()
        {
            double maxPrice = Car[0].Price;
            int maxNumber = Car[0].Number;
            for (int i = 0; i < Car.Count; i++)
            {
                if (Car[i].Price >= maxPrice)
                {

                }
            }

        }
        public Car GetCarWithLowestPrice() => this.Car.OrderBy(c => c.Price).FirstOrDefault();
        
        public void RenameStore(string newName)
        {
            this.Name = newName;
        }
        public void SellAllCars()
        {
            this.Car.Clear();
        }
        public override string ToString()
        {
            if (Car.Count >= 1)
            {
                return $"Store {this.Name} has {this.Car.Count} car/s:\n";
                for(int i=0; i<this.Car.Count; i++)
                {
                    return $"Car number {Car[i].Number} costs {Car[i].Price}";
                }
            }
            else
            {
                return $"Store {this.Name} has no available cars.";
            }
        }

    }
}
