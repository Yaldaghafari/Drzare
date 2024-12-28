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

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = ya.Text;
                string Name = textBox2.Text;
                int Grade = int.Parse(textBox3.Text);
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp28\WindowsFormsApp28\SchoolDB.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "insert into Students(Name,Grade) VALUES(@Name,@Grade)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Grade", Grade);
                command.ExecuteNonQuery();
                MessageBox.Show("Add succesfully");
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = ya.Text;
                string Name = textBox2.Text;
                int Grade = int.Parse(textBox3.Text);
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp28\WindowsFormsApp28\SchoolDB.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = " Update Students set Name=@Name,Grade=@Grade Where Id =@Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("Name", Name);
                command.Parameters.AddWithValue("Grade", Grade);
                command.ExecuteNonQuery();
                MessageBox.Show("update succesfully");
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = ya.Text;
                string Name = textBox2.Text;
                int Grade= int.Parse(textBox3.Text);
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp28\WindowsFormsApp28\SchoolDB.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "Delete from Students where Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();
                MessageBox.Show("remove succesefully");
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
