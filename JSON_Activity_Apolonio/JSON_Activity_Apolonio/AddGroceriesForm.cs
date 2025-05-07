using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Apolonio
{
    public partial class AddGroceriesForm : Form
    {
        private List<GroceryItem> groceries = new List<GroceryItem>();
        private string filePath = "D:\\VS Code Projects\\JSON_Apolonio\\shoppinglist.json";
        private int currentId = 1;

        public AddGroceriesForm()
        {
            InitializeComponent();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var existingItems = JsonSerializer.Deserialize<List<GroceryItem>>(json);
                if (existingItems != null)
                {
                    groceries = existingItems;
                    currentId = groceries.Max(item => item.Id) + 1;

                    foreach (var item in groceries)
                    {
                        listBox1.Items.Add($"ID: {item.Id} - Name: {item.Name} - Quantity: {item.Quantity}");
                    }
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (groceries.Count >= 5)
            {
                MessageBox.Show("Maximum of 5 items only.");
                return;
            }

            string name = txtName.Text.Trim();
            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            var item = new GroceryItem
            {
                Id = currentId++,
                Name = name,
                Quantity = quantity
            };

            groceries.Add(item);
            listBox1.Items.Add($"ID: {item.Id} - {item.Name} - Qty: {item.Quantity}");

            txtName.Clear();
            txtQuantity.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(groceries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            MessageBox.Show("Groceries saved!");
            this.Close();
        }
    }
}
