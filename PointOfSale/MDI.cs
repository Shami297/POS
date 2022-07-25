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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDF_Load(object sender, EventArgs e)
        {
            
            Sample2 sample2 = new Sample2();
            Login login = new Login();
            //sample.MdiParent = this;
            //sample.Dock = DockStyle.Fill;
            //sample.Show();
            //MainClass.showWin(login, this);
            
        }
    }
}
