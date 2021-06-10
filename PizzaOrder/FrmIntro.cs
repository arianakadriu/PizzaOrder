using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            guna2ProgressBar1.Value = startpoint;
            lblPercentage.Text = startpoint + "%";
            if (guna2ProgressBar1.Value==100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                FrmLogin login =  new FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void FrmIntro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
