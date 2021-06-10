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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          

            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-UP95E9T\SQLEXPRESS;Initial Catalog=PizzaOrderDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Login where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'",Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboRole.SelectedItem.ToString();

            if(dt.Rows.Count>0)
            {
                for (int i=0;i<dt.Rows.Count;i++)
                {
                    if (dt.Rows[i]["role"].ToString()==cmbItemValue)
                    {
                        MessageBox.Show("You are logged in as " + dt.Rows[i][2]);
                        if (comboRole.SelectedIndex==0)
                        {
                            FrmItems items = new FrmItems();
                            items.Show();
                            this.Hide();
                        }
                        else
                        {
                            FrmBilling bill = new FrmBilling();
                            bill.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect. Try again!");
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
         
        }
    }
}
