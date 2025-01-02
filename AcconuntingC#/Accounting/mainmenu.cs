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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            payable payable = new payable();
            payable.Show();
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receivable receivable = new Receivable();   
            receivable.Show();
        }

        private void accountingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
