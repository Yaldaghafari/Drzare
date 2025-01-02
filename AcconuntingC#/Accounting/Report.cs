using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime StartDate = DateTime.Parse(textBox2.Text);
                DateTime EndDate = DateTime.Parse(textBox3.Text);
                string Report = Reportt.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "INSERT INTO Report (StartDate,EndDate,Report)VALUES (@StartDate,@EndDate,@Report)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", StartDate);
                command.Parameters.AddWithValue("@EndDate", EndDate);
                command.Parameters.AddWithValue("@Report", Report);
                command.ExecuteNonQuery();
                MessageBox.Show("ADD SUCCESFULLY");
                connection.Close();


            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);


            }





        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                string ID = textBox1.Text;
                DateTime StartDate = DateTime.Parse(textBox2.Text);
                DateTime EndDate = DateTime.Parse(textBox3.Text);
                string Report = Reportt.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "DELETE FROM Report WHERE ID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("ID",ID);
                command.ExecuteNonQuery();
                MessageBox.Show("REMOVE SUCCSSEFULLY");
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = textBox1.Text;
                DateTime StartDate = DateTime.Parse(textBox2.Text);
                DateTime EndDate = DateTime.Parse(textBox3.Text);
                string Report = Reportt.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "UPDATE Report SET StartDate= @StartDate ,EndDate=@EndDate ,Report=@Report WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("ID", ID);
                command.Parameters.AddWithValue("@StartDate", StartDate);
                command.Parameters.AddWithValue("@EndDate", EndDate);
                command.Parameters.AddWithValue("@Report", Report);
                command.ExecuteNonQuery();
                MessageBox.Show("ADD SUCCESFULLY");
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
