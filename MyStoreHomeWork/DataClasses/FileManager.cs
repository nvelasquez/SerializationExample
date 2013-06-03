using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyStoreHomeWork.DataClasses
{
    class FileManager
    {
        private static readonly string StorePath = @"C:\StoreHomeWrk\files";
        private static readonly string ProductFilePath = StorePath + @"\product.mfile";
        private static readonly string InvoiceFilePath = StorePath + @"\invoice.mfile";

        private static FileManager INSTANCE;
        private BinaryFormatter Serializer = new BinaryFormatter();
       
        private int ProductId = 1000;
        private int InvoiceId = 1000;

        private FileManager()
        {
            if (!Directory.Exists(StorePath))
            {
                Directory.CreateDirectory(StorePath);
            }

            if (!File.Exists(ProductFilePath))
            {
                File.Create(ProductFilePath).Close();
            }

            if (!File.Exists(InvoiceFilePath))
            {
                File.Create(InvoiceFilePath).Close();                
            }
        }

        public static FileManager getInstace()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new FileManager();
            }
            return INSTANCE;
        }

        public List<Product> getProductsData()
        {
            List<Product> list = Deserialize(ProductFilePath) as List<Product>;
            return list;
        }

        public Product getProduct(int id)
        {
            List<Product> list = Deserialize(ProductFilePath) as List<Product>;
            foreach (Product p in list)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }
        
        public void addProduct(Product product)
        {
            bool exists = false;
            Product mProduct = null;
            List<Product> Products = new List<Product>();

            {
                Products = Deserialize(ProductFilePath) as List<Product>;
                if (Products != null)
                {
                    if (product.Id != 0 && (product.Id%1000)>0)
                    {
                        try
                        {
                            mProduct = Products.ElementAt(product.Id % 1000);
                        }
                        catch (IndexOutOfRangeException e)
                        {

                        }
                        catch (NullReferenceException e)
                        {

                        }
                    }
                    else
                    {
                        foreach (Product p in Products)
                        {
                            if (product.Name == p.Name)
                            {
                                mProduct = p;
                            }
                        }
                    }
                }
                else
                {
                    Products = new List<Product>();
                }
                

                if (mProduct != null)
                {
                    exists = true;
                    Products.Remove(mProduct);
                    mProduct.Amount = product.Amount;
                    if (product.Quantity > mProduct.Quantity)
                    {
                        mProduct.Quantity = product.Quantity;
                    }                    
                    Products.Add(mProduct);
                }
            }
            

            if (!exists)
            {                
                ProductId = ProductId + Products.Count() + 1;
                product.Id = ProductId;
                Products.Add(product);
            }
            
            Stream write = File.Open(ProductFilePath, FileMode.Create);
            Serializer.Serialize(write, Products);
            write.Close();
            
        }

        public void addProduct(List<Product> products)
        {
            Stream stream = File.Open(ProductFilePath, FileMode.Create);
            Serializer.Serialize(stream, products);
            stream.Close();
        }

        static object Deserialize(string file)
        {
            var ret = new object();
            var fmt = new BinaryFormatter();

            try
            {
                using (FileStream fs = File.Open(file, FileMode.Open))
                {
                    ret = fmt.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                
            }
            return ret;
        }

        public void addInvoice(Invoice invoice)
        {
            List<Invoice> Invoices = new List<Invoice>(); ;

            Invoices = Deserialize(InvoiceFilePath) as List<Invoice>;

            if (Invoices != null)
            {
                InvoiceId += Invoices.Count() + 1;
            }
            else
            {
                Invoices = new List<Invoice>();
                InvoiceId += 1;
            }
            invoice.Id = InvoiceId;
            Invoices.Add(invoice);

            Stream write = File.Open(InvoiceFilePath, FileMode.Create);
            Serializer.Serialize(write, Invoices);
            write.Close();
        }

        public List<Invoice> getInvoiceData()
        {
            List<Invoice> list = Deserialize(InvoiceFilePath) as List<Invoice>;
            return list;
        }

    }
}
