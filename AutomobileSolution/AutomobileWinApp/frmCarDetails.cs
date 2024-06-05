using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        internal ICarRepository CarRepository;
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public ICarRepository MyProperty { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Car CarInfo { get; set; }
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            lbCarId.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                lbCarId.Text = CarInfo.CarId.ToString();
                txtCarName.Text = CarInfo.CarName.ToString();
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarId = int.Parse(txtCarId.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrUpdate == false)
                {
                    new CarRepository().InsertCar(car);
                }
                else
                {
                    new CarRepository().UpdateCar(car);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update Car");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
