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
    public partial class ProductsMantain : UserControl
    {
        public const string UPDATE = "Actualizar";
        public const string NEW = "Nuevo";
        private string tag;

        private FileManager manager = FileManager.getInstace();

        public ProductsMantain()
        {
            InitializeComponent();
        }

        public ProductsMantain(string tag)
        {
            this.tag = tag;
            InitializeComponent();
            habilitateComponents(tag);
        }
        private void ProductsMantain_Load(object sender, EventArgs e)
        {
            TagLabel.Text = tag;
        }

        private void habilitateComponents(string tag)
        {
            switch (tag)
            {
                case UPDATE:
                    SearchButton.Visible = true;
                    IdTextBox.Visible = true;
                    NameTextBox.Enabled = false;
                    AmountTextBox.Enabled = false;
                    QuantityTextBox.Enabled = false;
                    SaveButton.Enabled = false;
                    break;
                case NEW:
                    SearchButton.Visible = false;
                    IdTextBox.Visible = false;
                    NameTextBox.Enabled = true;
                    AmountTextBox.Enabled = true;
                    QuantityTextBox.Enabled = true;
                    SaveButton.Enabled = true;
                    break;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(IdTextBox.Text);
                Product p = manager.getProduct(id);

                if (p != null)
                {
                    AmountTextBox.Enabled = true;
                    QuantityTextBox.Enabled = true;
                    SaveButton.Enabled = true;

                    AmountTextBox.Text = p.Amount.ToString();
                    QuantityTextBox.Text = p.Quantity.ToString();
                    NameTextBox.Text = p.Name;
                }
                else
                {
                    ErrorLabel.Text = "No existe este producto";
                    ErrorLabel.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }

            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Double amount = 0;
            int qty = 0, id;
            string name = NameTextBox.Text;
            Int32.TryParse(IdTextBox.Text, out id);
            if (!(name == ""))
            {
                try
                {                    
                    amount = Convert.ToDouble(AmountTextBox.Text);
                    qty = Convert.ToInt32(QuantityTextBox.Text);
                    Product product = new Product(name, amount, qty);

                    manager.addProduct(product);

                    cleanComponents();
                    
                    ErrorLabel.Text = "Registro agregado satisfactoriamente.";
                    ErrorLabel.Visible = true;
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = "Favor llene los campos debidamente";
                    ErrorLabel.Visible = true;
                }
            }
            else
            {
                ErrorLabel.Text = "Favor llene los campos debidamente";
                ErrorLabel.Visible = true;
            }
                        
        }

        private void cleanComponents()
        {
            NameTextBox.Text = "";
            AmountTextBox.Text = "";
            QuantityTextBox.Text = "";
        }

    }
}
