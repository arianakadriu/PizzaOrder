using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PizzaOrder
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            FillGrid();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UP95E9T\SQLEXPRESS;Initial Catalog=PizzaOrderDB;Integrated Security=True");

        private void FillGrid()
        {
            Con.Open();
            string query = "select * from customers";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DgvCustomers.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmItems items = new FrmItems();
            items.Show();
            this.Hide();
        }

        private void Reset()
        {
            guna2TxtCustomerId.Text = "";
            guna2TxtName.Text = "";
            guna2TxtLastName.Text = "";
            guna2TxtAddress.Text = "";
            guna2TxtPhone.Text = "";
            
        }

        private void guna2BtnSave_Click(object sender, EventArgs e)
        {
            if (guna2TxtCustomerId.Text == "" || guna2TxtName.Text == "" || guna2TxtLastName.Text == "" || guna2TxtAddress.Text=="" || guna2TxtPhone.Text=="")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {

                    Con.Open();
                  
                    SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT dbo.customers ON; insert into customers (CustomerId, CustomerName, CustomerLastName, CustomerAddress, CustomerPhone) values (@CustomerId, @CustomerName, @CustomerLastName, @CustomerAddress, @CustomerPhone)", Con);
                    cmd.Parameters.AddWithValue("@CustomerId", int.Parse(guna2TxtCustomerId.Text));
                    cmd.Parameters.AddWithValue("@CustomerName", guna2TxtName.Text);
                    cmd.Parameters.AddWithValue("@CustomerLastName", guna2TxtLastName.Text);
                    cmd.Parameters.AddWithValue("@CustomerAddress", guna2TxtAddress.Text);
                    cmd.Parameters.AddWithValue("@CustomerPhone", guna2TxtPhone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer saved successfully!");
                    Con.Close();
                    FillGrid();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2BtnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("update customers set CustomerName=@CustomerName, CustomerLastName=@CustomerLastName, CustomerAddress=@CustomerAddress, CustomerPhone=@CustomerPhone where CustomerId=@CustomerId", Con);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(guna2TxtCustomerId.Text));
            cmd.Parameters.AddWithValue("@CustomerName", guna2TxtName.Text);
            cmd.Parameters.AddWithValue("@CustomerLastName", guna2TxtLastName.Text);
            cmd.Parameters.AddWithValue("@CustomerAddress", guna2TxtAddress.Text);
            cmd.Parameters.AddWithValue("@CustomerPhone", guna2TxtPhone.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer updated successfully!");
            Con.Close();
            FillGrid();
            Reset();
        }

        private void guna2BtnDelete_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("delete customers where CustomerId=@CustomerId", Con);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(guna2TxtCustomerId.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer deleted successfully!");
            Con.Close();
            FillGrid();
            Reset();
        }

        private void guna2BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void guna2DgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
