using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStoreHomeWork.DataClasses
{
    [Serializable()]
    class Invoice
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<Product> Products { get; set; }
        public double Monto { get; set; }
        public int Productos { get; set; }

        public Invoice(List<Product> products, string name)
        {
            this.Cliente = name;
            this.Products = products;
        }

        public void calculateAmount()
        {
            foreach (Product p in Products)
            {
                Monto += p.Amount;
            }

            Productos = Products.Count();
        }
    }
}
