using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exam_Pharmacy
{
    class Pharmacy
    {
        private string name;
        private List<Medicine> ListofMedicine;
        public string Name
        {
            get { return this.name; }
            set
            {
                if(value.Length<3)
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }
        public Pharmacy(string name)
        {
            this.Name = name;
            ListofMedicine = new List<Medicine>();
        }
        public void Order(Medicine medicine)
        {
            ListofMedicine.Add(medicine);
        }
        public bool Sell(Medicine medicine)
        {
            bool a = false;
            if(ListofMedicine.Contains(medicine))
            {
                ListofMedicine.Remove(medicine);
                a = true;
            }
            return a;
        }
        public double CalculateTotalPrice()
        {
            double s = 0.00;
            if(ListofMedicine.Count > 0)
            {
                for(int i=0; i< ListofMedicine.Count; i++)
                {
                    s = s + ListofMedicine[i].Price;
                }
            }
            return s;
        }
        public Medicine GetMedicineWithHighestPrice()
        {
            double maxp = 0;
            Medicine maxp1;
            int k = 0;
            for (int i = 0; i < ListofMedicine.Count; i++)
            {
                if (maxp < ListofMedicine[i].Price)
                {
                    k = i;
                    maxp = ListofMedicine[i].Price;
                }
            }
            maxp1 = new Medicine(ListofMedicine[k].Name, ListofMedicine[k].Price);
            return maxp1;
        }
        public Medicine GetMedicineWithLowestPrice()
        {
            double maxp = 0;
            Medicine maxp1;
            int k = 0;
            for (int i = 0; i < ListofMedicine.Count; i++)
            {
                if (maxp > ListofMedicine[i].Price)
                {
                    k = i;
                    maxp = ListofMedicine[i].Price;
                }
            }
            maxp1 = new Medicine(ListofMedicine[k].Name, ListofMedicine[k].Price);
            return maxp1;
        }
        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }
        public void SellAllMedicines()
        {
            ListofMedicine.Clear();
        }
        public override string ToString()
        {
            string s;
            if (ListofMedicine.Count <= 0)
            {
                s = $"Pharmacy {this.Name} has {ListofMedicine.Count} medicines and they are:\n N/A";
                return s;
            }
            else
            {
                s = "Pharmacy " + this.Name + " has " + ListofMedicine.Count + " medicines and they are:";
                for (int i = 0; i < ListofMedicine.Count; i++)
                {
                    s = s + "\n" + "Medicine: " + ListofMedicine[i].Name + " with price " + ListofMedicine[i].Price.ToString("F2");
                }
                return s;
            }
        }
    }
}
//85т. от 100
//извършвам корекция в GetMedicineWithHighestPrice и GetMedicineWithLowestPrice, защото не актуализирам maxp и добре, че в 85% от случаите взима последния елемент или изобщо не го взима, за да ми даде 85 от 100