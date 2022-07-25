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

namespace PointOfSale
{
    public partial class Invoice : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=Yoanserver;Initial Catalog=YOANPOS;Persist Security Info=True;User ID=pos;Password=pospass");
        public Invoice()
        {
            InitializeComponent();
        }
    }
}
