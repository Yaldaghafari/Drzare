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
    public partial class payable : Form
    {
        public payable()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu mainmenu = new mainmenu();
            mainmenu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int CUSTID = int.Parse(txtCustID.Text);
                DateTime DATE = DateTime.Parse(txtData.Text);
                float AMOUNT = float.Parse(txtAmount.Text);
                string DETAIL = txtDetails.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();

                
                string query = "INSERT INTO Payble(CustomerID ,Date, Amount , Details) VALUES ( @CustomerID, @Date , @Amount, @Details)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", CUSTID);
                command.Parameters.AddWithValue("@Date", DATE);
                command.Parameters.AddWithValue("@Amount", AMOUNT);
                command.Parameters.AddWithValue("@Details", DETAIL);
                command.ExecuteNonQuery();
                MessageBox.Show("ADD TO LIST");
                connection.Close();


            }

            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = textBox1.Text;
                int CUSTID = int.Parse(txtCustID.Text);
                DateTime DATE = DateTime.Parse(txtData.Text);
                float AMOUNT = float.Parse(txtAmount.Text);
                string DETAIL = txtDetails.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "DELETE FROM  WHERE ID = @ID ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID",ID);
                command.ExecuteNonQuery();
                MessageBox.Show("remove succssefuly");
                connection.Close();

            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string ID = textBox1.Text;
                int CUSTID = int.Parse(txtCustID.Text);
                DateTime DATE = DateTime.Parse(txtData.Text);
                float AMOUNT = float.Parse(txtAmount.Text);
                string DETAIL = txtDetails.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yalda\source\repos\WindowsFormsApp34\WindowsFormsApp34\Database1.mdf;Integrated Security=True";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                string query = "UPDATE Payble SET CustomerID =@CustomerID ,Date=@Date, Amount=@Amount, Details=@Details WHERE ID=@ID ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@CustomerID", CUSTID);
                command.Parameters.AddWithValue("@Date", DATE);
                command.Parameters.AddWithValue("@Amount", AMOUNT);
                command.Parameters.AddWithValue("@Details", DETAIL);
                command.ExecuteNonQuery();
                MessageBox.Show("UPDATE SUCCESFULLY");
                connection.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
