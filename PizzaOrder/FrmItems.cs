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
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
            FillGrid();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UP95E9T\SQLEXPRESS;Initial Catalog=PizzaOrderDB;Integrated Security=True");
        
        private void FillGrid()
        {
            Con.Open();
            string query = "select * from Items";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DgvProducts.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void guna2BtnSave_Click(object sender, EventArgs e)
        {
            if (guna2TxtItemName.Text=="" || guna2TxtPrice.Text=="" || guna2TxtQty.Text=="" || comboCategory.SelectedIndex==-1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Items values ('" + guna2TxtItemName.Text + "','" + comboCategory.SelectedItem.ToString() +  "'," + guna2TxtPrice.Text + "," + guna2TxtQty.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item saved successfully!");
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

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int key = 0;
        private void guna2DgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TxtItemName.Text = guna2DgvProducts.SelectedRows[0].Cells[1].Value.ToString();
            comboCategory.SelectedItem = guna2DgvProducts.SelectedRows[0].Cells[2].Value.ToString();
            guna2TxtPrice.Text = guna2DgvProducts.SelectedRows[0].Cells[3].Value.ToString();
            guna2TxtQty.Text = guna2DgvProducts.SelectedRows[0].Cells[4].Value.ToString();

            if (guna2TxtItemName.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(guna2DgvProducts.SelectedRows[0].Cells[0].Value.ToString());
            }



        }

        private void Reset()
        {
            guna2TxtItemName.Text = "";
            comboCategory.SelectedIndex = -1;
            guna2TxtPrice.Text = "";
            guna2TxtQty.Text = "";
            key = 0;
        }
        private void guna2BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void guna2BtnDelete_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete * from Items where ItId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item deleted successfully!");
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
            if (guna2TxtItemName.Text == "" || guna2TxtPrice.Text == "" || guna2TxtQty.Text == "" || comboCategory.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Items set ItName='"+guna2TxtItemName.Text+"',ItCat='"+comboCategory.SelectedItem.ToString()+"',ItPrize='"+guna2TxtPrice.Text+"',ItQty='"+guna2TxtQty.Text+"' where ItId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item updated successfully!");
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

        private void label2_Click(object sender, EventArgs e)
        {
            FrmCustomers customers = new FrmCustomers();
            customers.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterByCat()
        {
            Con.Open();
            string query = "select * from Items where ItCat='"+comboFilterCat.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DgvProducts.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCat();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
