using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string Username = textuser.Text;
            string Password = textpass.Text;
            if (Username == "yalda" && Password == "1234")
            {
                this.Hide();
                mainmenu mainmenu = new mainmenu();
                mainmenu.Show();
               

            }
            else
            {
                MessageBox.Show("nam karbary ya ramze obor shoma eshtebah ast.");
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
