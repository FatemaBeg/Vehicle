using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VechicleAppPractice2.Model;

namespace VechicleAppPractice2
{
    public partial class Vehicle : Form
    {
        VehicalManager vehicle = new VehicalManager();

        List<double> speedsinfo = new List<double>();

        public Vehicle()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
            vehicle.VehicleName = vehicleNameTextBox.Text;
            vehicle.VehicleRegistrationNo = vehicleRegNoTextBox.Text;

         
            MessageBox.Show("Registration succesfull");
            vehicleNameTextBox.Text = "";
            vehicleRegNoTextBox.Text = "";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(speedTextBox.Text))
            {
                speedsinfo.Add(Convert.ToDouble(speedTextBox.Text));
                    speedTextBox.Text="";
            }
            else
            {
                MessageBox.Show("Please Enter speed");
                return;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            vehicleNameTextBox.Text = vehicle.VehicleName;
            vehicleRegNoTextBox.Text = vehicle.VehicleRegistrationNo;

            minSpeedTextBox.Text = speedsinfo.Min().ToString();
            maxSpeedTextBox.Text = speedsinfo.Max().ToString();
            averageSpeedTextBox.Text = speedsinfo.Average().ToString();
        }

        private void speedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
