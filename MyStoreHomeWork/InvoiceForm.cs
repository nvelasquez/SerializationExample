using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyStoreHomeWork.DataClasses;

namespace MyStoreHomeWork
{
    public partial class InvoiceForm : UserControl
    {
        private FileManager manager = FileManager.getInstace();
        private List<Product> added = new List<Product>();
        private List<Product> available;
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            available = manager.getProductsData();
            AvailableGridView1.DataSource = available;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product p = available.ElementAt(AvailableGridView1.CurrentCell.RowIndex);
            if (p.Quantity > 0)
            {
                available.ElementAt(AvailableGridView1.CurrentCell.RowIndex).Quantity -= 1;
                added.Add(p);

                OrderGridView2.DataSource = added;
                OrderGridView2.Refresh();
                AvailableGridView1.Refresh();
                MakeMessage("Agregado");
            }
            else
            {
                MakeMessage("Producto no disponible.");
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            if (added.Count() <= 0 || ClientTextBoxt.Text == "")
            {
                MakeMessage("Favor completar la informacion correctamente.");
            }
            else
            {
                Invoice invoice = new Invoice(added, ClientTextBoxt.Text);
                invoice.calculateAmount();
                manager.addProduct(available);
                manager.addInvoice(invoice);
                MakeMessage("Factura creada, ver en listar.");
            }          

            cancel();
        }

        private void cancel()
        {
            OrderGridView2.DataSource = null;
            OrderGridView2.Refresh();
            available = manager.getProductsData();
            AvailableGridView1.DataSource = available;
            added.Clear();

            AvailableGridView1.Refresh();
        }

        void MakeMessage(string message)
        {
            ErrorLabel3.Text = message;
            ErrorLabel3.Visible = true;
        }
    }
}
