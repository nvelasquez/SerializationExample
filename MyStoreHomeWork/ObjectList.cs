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
    public partial class ObjectList : UserControl
    {
        private tag1 tag;

        private FileManager manager = FileManager.getInstace();

        public ObjectList()
        {
            InitializeComponent();
        }

        public ObjectList(tag1 tag)
        {
            this.tag = tag;
            InitializeComponent();
        }

        private void ObjectList_Load(object sender, EventArgs e)
        {
            label1.Text = tag.ToString();
            switch (tag)
            {
                case tag1.PRODUCT:
                    dataGridView1.DataSource = manager.getProductsData();
                    break;
                case tag1.INVOICE:
                    dataGridView1.DataSource = manager.getInvoiceData();
                    break;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public enum tag1 { 
    
        PRODUCT,
        INVOICE
    }
}
