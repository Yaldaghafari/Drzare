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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = textBox1.Text;
                string Name = textBox2.Text;
                string MOBAIL = textBox3.Text;
                string Address = richTextBox1.Text;
                String con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "insert into Customers(Name , Mobail , Address) Values(@Name , @Mobail,@Address ) ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Mobail", MOBAIL);
                command.Parameters.AddWithValue("@Address", Address);
                command.ExecuteNonQuery();
                MessageBox.Show("Add succesfully");
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = textBox1.Text;
                string Name = textBox2.Text;
                string MOBAIL = textBox3.Text;
                string Address = richTextBox1.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection Connection = new SqlConnection(con);
                Connection.Open();
                string query = "Delete From Customers Where ID = @ID";
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
                MessageBox.Show("Remove succssefully");
                Connection.Close();

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
                string Name = textBox2.Text;
                string MOBAIL = textBox3.Text;
                string Address = richTextBox1.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "Update Customers  set Name = @Name , Mobail = @Mobail,Address = @Address Where ID= @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue ("ID" , ID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Mobail", MOBAIL);
                command.Parameters.AddWithValue("@Address", Address);
                command.ExecuteNonQuery();
                MessageBox.Show("Update succesfully");
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
        }
    }
}
