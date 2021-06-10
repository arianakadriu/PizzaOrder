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
    public partial class FrmViewOrders : Form
    {
        public FrmViewOrders()
        {
            InitializeComponent();
            FillGrid();
        }

        private void guna2BtnBack_Click(object sender, EventArgs e)
        {
            FrmBilling bill = new FrmBilling();
            bill.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UP95E9T\SQLEXPRESS;Initial Catalog=PizzaOrderDB;Integrated Security=True");

        private void FillGrid()
        {
            Con.Open();
            string query = "select * from Billing";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DgvSells.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FrmViewOrders_Load(object sender, EventArgs e)
        {

        }

        private void guna2DgvSells_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
