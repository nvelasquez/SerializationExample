using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyStoreHomeWork.DataClasses;

namespace MyStoreHomeWork
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(new ObjectList(tag1.PRODUCT));
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();            
            panel1.Controls.Add(new ProductsMantain(ProductsMantain.NEW));            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ProductsMantain(ProductsMantain.UPDATE)); 
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ObjectList(tag1.PRODUCT)); 
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new InvoiceForm()); 
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ObjectList(tag1.INVOICE)); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se pueden borrar productos.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDIParent1 md1 = new MDIParent1();
            md1.Show();
        }
    }
}
