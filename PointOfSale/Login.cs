using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Login : Sample2
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Product sample = new Product();
            sample.Show();
            this.Hide();
            // MDI mDI = new MDI();
            //MainClass.showWin(sample, this, mDI);
            //MainClass.showWin(sample, mDI);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
