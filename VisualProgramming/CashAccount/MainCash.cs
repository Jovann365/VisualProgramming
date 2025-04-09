using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.CashAccount
{
    public partial class MainCash: Form
    {
        List<Item> items = new List<Item>();
        public MainCash()
        {
            InitializeComponent();
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItems.Count == 0)
            {
                return;
            }
            Item item = new Item(lbProducts.SelectedItem as Product, (int)nudCount.Value);
            items.Add(item);
            showItems();
            calc();
            nudCount.Value = 1;
        }

        private void showItems()
        {
            lbItems.Items.Clear();
            foreach (Item i in items)
            {
                lbItems.Items.Add(i);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            if (addProduct.ShowDialog() == DialogResult.OK)
            {
                lbProducts.Items.Add(addProduct.Product as Product);
                showItems();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedItems.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете ставката?", "Бришење ставка", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Item Item = lbItems.SelectedItem as Item;
                items.Remove(Item);
                lbItems.Items.Remove(Item);
                showItems();
                calc();
            }
        }

        public void calc()
        {
            if (lbItems.Items.Count == 0)
            {
                tbTotal.Text = "0";
                tbFull.Text = "0";
                return;
            }

            decimal total = 0;
            foreach (Item i in items)
            {
                total += i.Product.Price * (decimal)i.Count;
            }
            decimal full = total + (total * (nudTax.Value / 100));
            tbFull.Text = full.ToString();
            tbTotal.Text = total.ToString();
        }

        private void MainCash_Load(object sender, EventArgs e)
        {

        }

        private void nudTax_ValueChanged(object sender, EventArgs e)
        {
            calc();
        }
    }
}
