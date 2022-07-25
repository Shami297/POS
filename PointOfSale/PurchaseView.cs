using POS_Logics;
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
    public partial class PurchaseView : Form
    {
        Logics log = new Logics();
        public PurchaseView()
        {
            InitializeComponent();
        }

        private void BTN()
        {
            purchasView.Columns["DetailBtn"].DisplayIndex = purchasView.ColumnCount - 1;
            purchasView.Columns["PurchaseID"].Visible = false;
        }

        private void populateVendor()
        {
            VendorManager vendorManager = new VendorManager();

            vendorBox.DisplayMember = "Name";
            vendorBox.ValueMember = "ID";
            vendorBox.DataSource = vendorManager.GetVendors();

        }
        private void PurchaseView_Load(object sender, EventArgs e)
        {
            populateVendor();
            log.viewAllPurchases(purchasView);
            BTN();

        }

        private void vendorBox_TextChanged(object sender, EventArgs e)
        {
            int VenID = (int)vendorBox.SelectedValue;
            log.viewPurchase(VenID, purchasView);
            BTN();
            purchasView.Columns["DetailBtn"].Visible = true;
            backBtn.Text = "Back";
        }

        private void purchasView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) //Detail;
                {
                    int purchaseID = Convert.ToInt32(purchasView.Rows[e.RowIndex].Cells["PurchaseID"].FormattedValue.ToString());
                    log.viewPurchaseDetail(purchaseID, purchasView);
                    purchasView.Columns["DetailBtn"].Visible = false;
                    backBtn.Text = "MainView";

                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(backBtn.Text == "MainView")
            {
                log.viewAllPurchases(purchasView);
                BTN();
                purchasView.Columns["DetailBtn"].Visible = true;
                backBtn.Text = "Back";
            }
            else
            {
                this.Close();
                Product p = new Product();
                p.Show();
                p.BringToFront();
            }

        }
    }
}
