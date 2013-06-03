using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStoreHomeWork.DataClasses
{
    [Serializable()]
    class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; }

        public Product(String Name, double Amount)
        {
            this.Name = Name;
            this.Amount = Amount;
            this.Quantity = 0;
        }


        public Product(String Name, double Amount, int Quantity)
        {
            this.Name = Name;
            this.Amount = Amount;
            this.Quantity = Quantity;
        }

        public Product(int id, String Name, double Amount, int Quantity)
        {
            this.Id = id;
            this.Name = Name;
            this.Amount = Amount;
            this.Quantity = Quantity;
        }
    }
}
