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
    public partial class Sample2 : Form
    {
        public Sample2()
        {
            InitializeComponent();
        }

        int disUnit = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox text = new TextBox();
            this.Controls.Add(text);
            text.Top = disUnit * 50;
            text.Left = 450;
            disUnit = disUnit + 1;
            text.ForeColor = Color.Gray;
            text.Font = new Font("arial", 20.25f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            text.Size = new Size(153, 29);
        }
    }
}
