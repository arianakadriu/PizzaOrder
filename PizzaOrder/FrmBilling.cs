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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
            FillGrid();
            DisplayCostumers();
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
        int key = 0;
        int stock = 0;
        //int CustKey = 0;
        private void UpdateQty()
        {
            try
            {
                int newStock = stock - Convert.ToInt32(guna2TxtQty.Text);
                Con.Open();
                string query = "update Items set ItQty=" + newStock + " where ItId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Item updated successfully!");
                Con.Close();
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       // int n = 0;
        int GrdTotal = 0;
        private void guna2BtnAdd_Click(object sender, EventArgs e)
        {
            if (guna2TxtQty.Text=="" || Convert.ToInt32(guna2TxtQty.Text)>stock)
            {
                MessageBox.Show("Not enough stocks left");
            }
            else
            {
                int n = Convert.ToInt32(guna2TxtBillId.Text);
                int total = Convert.ToInt32(guna2TxtQty.Text)*Convert.ToInt32(guna2TxtPrice.Text)*Convert.ToInt32(guna2TxtSize.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(guna2DgvBill);
                newRow.Cells[0].Value= n;
                newRow.Cells[1].Value = guna2TxtProductName.Text;
                newRow.Cells[2].Value = guna2TxtPrice.Text;
                newRow.Cells[3].Value = guna2TxtQty.Text;
                newRow.Cells[4].Value = guna2TxtSize.Text;
                newRow.Cells[5].Value = total;
                guna2DgvBill.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                lblTotal.Text = GrdTotal + "€";
                n++;
                UpdateQty();
            }
        }
       
        private void guna2DgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TxtProductName.Text = guna2DgvProducts.SelectedRows[0].Cells[1].Value.ToString();
            guna2TxtPrice.Text = guna2DgvProducts.SelectedRows[0].Cells[3].Value.ToString();
            

            if (guna2TxtProductName.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(guna2DgvProducts.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(guna2DgvProducts.SelectedRows[0].Cells[4].Value.ToString());

            }

        }

        private void DisplayCostumers()
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
        private void guna2DgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void guna2TxtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TxtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("update customers set CustomerName=@CustomerName, CustomerLastName=@CustomerLastName, CustomerAddress=@CustomerAddress, CustomerPhone=@CustomerPhone where CustomerId=@CustomerId", Con);
            cmd.Parameters.AddWithValue("@CustomerId", int.Parse(guna2TxtCustomerId.Text));

            cmd.ExecuteNonQuery();
           
            Con.Close();
            FillGrid();
        }

        private void guna2BtnPrint_Click(object sender, EventArgs e)
        {
           try
             {
                /*Con.Open();
                string query = "insert into Bill values (" + CustKey +"," + GrdTotal + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill saved successfully!");
                Con.Close();
                FillGrid();*/
                
                Con.Open();

                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT dbo.Billing ON; insert into Billing (BillId, CustomerId, Amount) values (@BillId, @CustomerId, @Amount)", Con);
                cmd.Parameters.AddWithValue("@BillId", int.Parse(guna2TxtBillId.Text));
                cmd.Parameters.AddWithValue("@CustomerId", int.Parse(guna2TxtCustomerId.Text));
                cmd.Parameters.AddWithValue("@Amount", GrdTotal);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill saved successfully!");
                Con.Close();
                FillGrid();
            }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
           /* try
            {

                Con.Open();

                SqlCommand cmd = new SqlCommand("insert into Bill (BillId, CustomerId, Amount) values (@BillId, @CustomerId, @Amount)", Con);
                cmd.Parameters.AddWithValue("@BillId", int.Parse(guna2TxtBillId.Text));
                cmd.Parameters.AddWithValue("@CustomerId", int.Parse(guna2TxtCustomerId.Text));
                cmd.Parameters.AddWithValue("@Amount", GrdTotal);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill saved successfully!");
                Con.Close();
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void guna2BtnReset_Click(object sender, EventArgs e)
        {
            FrmViewOrders order = new FrmViewOrders();
            order.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pizza Order", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in guna2DgvBill.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("Grand Total: € " + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("**************PizzaOrder**************" , new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(11, pos + 85));
            guna2DgvBill.Rows.Clear();
            guna2DgvBill.Refresh();
            pos = 100;
            GrdTotal =0;
        }
    }
    
}
