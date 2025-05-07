using System;
using System.Windows.Forms;

namespace Apolonio
{
    partial class AddGroceriesForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnSave;
        private ListBox listBox1;
        private Label lblName;
        private Label lblQuantity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtQuantity = new TextBox();
            this.btnAdd = new Button();
            this.btnSave = new Button();
            this.listBox1 = new ListBox();
            this.lblName = new Label();
            this.lblQuantity = new Label();
            this.SuspendLayout();

            // lblName
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.Text = "Item Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 12);
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // lblQuantity
            this.lblQuantity.Location = new System.Drawing.Point(12, 45);
            this.lblQuantity.Size = new System.Drawing.Size(100, 23);
            this.lblQuantity.Text = "Quantity:";

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(120, 42);
            this.txtQuantity.Size = new System.Drawing.Size(200, 23);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(12, 75);
            this.btnAdd.Size = new System.Drawing.Size(308, 30);
            this.btnAdd.Text = "Add Item";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // listBox1
            this.listBox1.Location = new System.Drawing.Point(12, 115);
            this.listBox1.Size = new System.Drawing.Size(308, 150);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(12, 275);
            this.btnSave.Size = new System.Drawing.Size(308, 35);
            this.btnSave.Text = "Save and Close";
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // AddGroceriesForm
            this.ClientSize = new System.Drawing.Size(334, 325);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSave);
            this.Name = "AddGroceriesForm";
            this.Text = "Add Groceries";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
