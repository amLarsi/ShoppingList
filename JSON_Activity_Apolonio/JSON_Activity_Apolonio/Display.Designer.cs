using System;
using System.Windows.Forms;

namespace Apolonio
{
    partial class Display
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBox1;
        private Button btnOpenAddForm;

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
            this.listBox1 = new ListBox();
            this.btnOpenAddForm = new Button();
            this.SuspendLayout();

            // listBox1
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 229);
            this.listBox1.TabIndex = 0;

            // btnOpenAddForm
            this.btnOpenAddForm.Location = new System.Drawing.Point(12, 250);
            this.btnOpenAddForm.Name = "btnOpenAddForm";
            this.btnOpenAddForm.Size = new System.Drawing.Size(360, 40);
            this.btnOpenAddForm.TabIndex = 1;
            this.btnOpenAddForm.Text = "Add Groceries";
            this.btnOpenAddForm.UseVisualStyleBackColor = true;
            this.btnOpenAddForm.Click += new EventHandler(this.btnOpenAddForm_Click);

            // Display
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.btnOpenAddForm);
            this.Controls.Add(this.listBox1);
            this.Name = "Display";
            this.Text = "Shopping List";
            this.ResumeLayout(false);
        }
    }
}
