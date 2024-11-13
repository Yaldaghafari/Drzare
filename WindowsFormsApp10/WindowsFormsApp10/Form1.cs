using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Vehicle
        {
            public abstract void Pedal();
        }
        public class Car : Vehicle
        {
            public override void Pedal()
            {
                MessageBox.Show("The car acceleration");
            }
        }
        public class Bike : Vehicle
        {
            public override void Pedal()
            {
                MessageBox.Show("push pedal");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            Bike bike = new Bike();
            car.Pedal();
            bike.Pedal();
        }
    }
}
