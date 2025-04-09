using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming.Cars
{
    public partial class MainCars: Form
    {
        List<Model> Models = new List<Model>();
        List<Car> Cars = new List<Car>();
        public MainCars()
        {
            InitializeComponent();
            calcAverage();
            calcEconomic();
            calcExpensive();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            if (addBrand.ShowDialog() == DialogResult.OK)
            {
                Models.Add(addBrand.Model as Model);
                showModels();
                ddBrand.Items.Add(addBrand.Model);
            }
        }

        private void showModels()
        {
            lbModels.Items.Clear();
            foreach (Model m in Models)
            {
                lbModels.Items.Add(m);
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car(ddBrand.SelectedItem as Model, tbName.Text, (decimal)nudSpending.Value, (int)nudPrice.Value));
            showCars();
            calcAverage();
            calcEconomic();
            calcExpensive();
            tbName.Text = "";
            nudPrice.Value = 0;
            nudSpending.Value = 0;
            ddBrand.SelectedItem = null;
        }

        private void showCars()
        {
            lbCars.Items.Clear();
            foreach (Car c in Cars)
            {
                lbCars.Items.Add(c);
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (lbCars.SelectedItems.Count == 0)
                {
                    return;
                }
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете колата?", "Бришење кола", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Car delete = lbCars.SelectedItem as Car;
                lbCars.Items.Remove(delete);
                Cars.Remove(delete);
                calcAverage();
                calcEconomic();
                calcExpensive();
            }
        }

        private void calcAverage()
        {
            if (Cars.Count == 0)
            {
                tbAverage.Text = "0";
                return;

            }


            decimal sum = 0;
            foreach (Car c in Cars)
            {
                sum += c.Spending;
            }
            tbAverage.Text = (sum / Cars.Count).ToString();
        }

        public void calcEconomic()
        {
            if (Cars.Count == 0)
            {
                tbEconomic.Text = "";
                return;
            }

            Car economic = Cars[0];
            foreach (Car c in Cars)
            {
                if (c.Spending < economic.Spending)
                {
                    economic = c;
                }
            }
            tbEconomic.Text = economic.ToString();
        }

        public void calcExpensive()
        {
            if (Cars.Count == 0)
            {
                tbEconomic.Text = "";
                return;
            }

            Car expensive = Cars[0];
            foreach (Car c in Cars)
            {
                if (c.Price > expensive.Price)
                {
                    expensive = c;
                }
            }
            tbExpensive.Text = expensive.ToString();
        }
    }
}
