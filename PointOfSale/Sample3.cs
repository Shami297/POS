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
    public partial class Sample3 : Form
    {
        public Sample3()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            this.Hide();
            product.Show();
            product.BringToFront();
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendor vendor = new Vendor();
            this.Hide();
            vendor.Show();
            vendor.BringToFront();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
            customer.BringToFront();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            this.Hide();
            category.Show();
            category.BringToFront();
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubCategory subcategory = new SubCategory();
            this.Hide();
            subcategory.Show();
            subcategory.BringToFront();
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manufacture manufacture = new Manufacture();
            this.Hide();
            manufacture.Show();
            manufacture.BringToFront();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            this.Hide();
            purchase.Show();
            purchase.BringToFront();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void logoutToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void logoutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void structureToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void structureToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void productToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void productToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void vendorToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void vendorToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void customerToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void customerToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void categoryToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void categoryToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void subCategoryToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void subCategoryToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void manufacturerToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void manufacturerToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void invoicesToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void invoicesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void addToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void addToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void viewToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void viewToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void purchaseToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void purchaseToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void addToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void addToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void viewToolStripMenuItem1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void viewToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void reportsToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void reportsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void monthlyReportToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void monthlyReportToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void annualReportToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void annualReportToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseView view = new PurchaseView();
            this.Hide();
            view.Show();
            view.BringToFront();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            this.Hide();
            sale.Show();
            sale.BringToFront();
        }
    }
}
