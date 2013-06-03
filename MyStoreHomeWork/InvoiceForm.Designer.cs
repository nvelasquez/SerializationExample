namespace MyStoreHomeWork
{
    partial class InvoiceForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Facturacion = new System.Windows.Forms.Label();
            this.AvailableGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClientTextBoxt = new System.Windows.Forms.TextBox();
            this.ErrorLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Facturacion
            // 
            this.Facturacion.AutoSize = true;
            this.Facturacion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facturacion.Location = new System.Drawing.Point(184, 0);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(83, 22);
            this.Facturacion.TabIndex = 2;
            this.Facturacion.Text = "TagLabel";
            // 
            // AvailableGridView1
            // 
            this.AvailableGridView1.BackgroundColor = System.Drawing.Color.White;
            this.AvailableGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableGridView1.Location = new System.Drawing.Point(3, 114);
            this.AvailableGridView1.Name = "AvailableGridView1";
            this.AvailableGridView1.Size = new System.Drawing.Size(415, 170);
            this.AvailableGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Productos Disponibles";
            // 
            // OrderGridView2
            // 
            this.OrderGridView2.BackgroundColor = System.Drawing.Color.White;
            this.OrderGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView2.Location = new System.Drawing.Point(6, 362);
            this.OrderGridView2.Name = "OrderGridView2";
            this.OrderGridView2.Size = new System.Drawing.Size(412, 154);
            this.OrderGridView2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Productos Agregados";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(202, 307);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(294, 307);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancelar Orden";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(3, 254);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 9;
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.Location = new System.Drawing.Point(343, 531);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.InvoiceButton.TabIndex = 10;
            this.InvoiceButton.Text = "Facturar";
            this.InvoiceButton.UseVisualStyleBackColor = true;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Nombre del Cliente";
            // 
            // ClientTextBoxt
            // 
            this.ClientTextBoxt.Location = new System.Drawing.Point(114, 38);
            this.ClientTextBoxt.Name = "ClientTextBoxt";
            this.ClientTextBoxt.Size = new System.Drawing.Size(100, 20);
            this.ClientTextBoxt.TabIndex = 12;
            // 
            // ErrorLabel3
            // 
            this.ErrorLabel3.AutoSize = true;
            this.ErrorLabel3.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel3.Location = new System.Drawing.Point(3, 74);
            this.ErrorLabel3.Name = "ErrorLabel3";
            this.ErrorLabel3.Size = new System.Drawing.Size(35, 13);
            this.ErrorLabel3.TabIndex = 13;
            this.ErrorLabel3.Text = "label3";
            this.ErrorLabel3.Visible = false;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorLabel3);
            this.Controls.Add(this.ClientTextBoxt);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailableGridView1);
            this.Controls.Add(this.Facturacion);
            this.Name = "InvoiceForm";
            this.Size = new System.Drawing.Size(448, 562);
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Facturacion;
        private System.Windows.Forms.DataGridView AvailableGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrderGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ClientTextBoxt;
        private System.Windows.Forms.Label ErrorLabel3;
    }
}
