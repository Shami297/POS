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
    public partial class Vendor : Sample3
    {
        Logics log = new Logics();
        public Vendor()
        {
            InitializeComponent();
            vendorView.AllowUserToAddRows = false;
            showData();
            BTN();
        }

        private void clearBox()
        {
            nameText.Text = "";
            addressText.Text = "";
            nmbrText.Text = "";
            personText.Text = "";
            emailText.Text = "";
        }
        private void saveData()
        {
            log.addVender(nameText.Text,addressText.Text,(nmbrText.Text),personText.Text,emailText.Text);
        }
        private void BTN()
        {
            vendorView.Columns["DeleteBtn"].DisplayIndex = vendorView.ColumnCount - 1;
            vendorView.Columns["Editbtn"].DisplayIndex = vendorView.ColumnCount - 2;
            vendorView.Columns["VendorID"].Visible = false;
        }

        private void updateVendor()
        {
            log.updateVendor(nameText.Text, vendorID, addressText.Text, (nmbrText.Text), personText.Text, emailText.Text);
        }
        private void showData()
        {
            log.showVender(vendorView);
        }

        private void checkUpdate()
        {
            updateVendor();
            MessageBox.Show("Vendor is Updated","Success");
            log.showVender(vendorView);
            BTN();
            clearBox();
            saveBtn.Text = "Save";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameText.Text == "")
                {
                    MessageBox.Show("Please enter vendor name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nameText.Text.Trim().Length == 0) // only Spaces Not allowed
                {
                    MessageBox.Show("Only Spaces are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameText.Text = "";
                    nameText.Focus();
                }
                else
                {
                    
                     if (saveBtn.Text == "Save")
                    {
                        if (!log.checkVendorDuplication(nameText.Text))
                        {
                            MessageBox.Show("This Vendor already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nameText.Text = "";
                            nameText.Focus();
                        }
                        else
                        {
                            saveData();
                            MessageBox.Show("Vendor is Saved","Success");
                            showData();
                            clearBox();
                        }
                        
                    }
                    else if (saveBtn.Text == "Update")
                    {
                        if(name == nameText.Text)
                        {
                            checkUpdate();
                        }
                        else
                        {
                            if (!log.checkVendorDuplication(nameText.Text))
                            {
                                MessageBox.Show("This Vendor already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                nameText.Text = "";
                                nameText.Focus();
                            }
                            else
                            {
                                checkUpdate();
                            }
                        }
                       
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DBconnection.conn.Close();
            }

        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            nameText.Focus();
        }


        public int vendorID;
        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            // Your Business Logic
            if (vendorView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                vendorView.CurrentCell.Selected = true;
                vendorID = Convert.ToInt32(vendorView.Rows[e.RowIndex].Cells["vendorID"].FormattedValue.ToString());
                nameText.Text = vendorView.Rows[e.RowIndex].Cells["VendorName"].FormattedValue.ToString();
                addressText.Text = vendorView.Rows[e.RowIndex].Cells["VendorAddress"].FormattedValue.ToString();
                nmbrText.Text = vendorView.Rows[e.RowIndex].Cells["ContactNo"].FormattedValue.ToString();
                personText.Text = vendorView.Rows[e.RowIndex].Cells["ContactPerson"].FormattedValue.ToString();
                emailText.Text = vendorView.Rows[e.RowIndex].Cells["VendorEmail"].FormattedValue.ToString();
            }
        }

        public string name;
        private void vendorView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.RowIndex == 0 && (e.ColumnIndex == 0 || e.ColumnIndex == 1))
                {
                    return;
                }
                if (e.ColumnIndex == 0) //Edit
                {
                    LoadEditData(e);
                    saveBtn.Text = "Update";
                    name = nameText.Text;
                }
                if (e.ColumnIndex == 1) //Delete
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this Vendor ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // If 'Yes', do something here.
                        DataGridViewRow row = vendorView.Rows[e.RowIndex];
                        int customerID = Convert.ToInt32(row.Cells["VendorID"].Value.ToString());
                        log.deleteVendor(customerID);
                        vendorView.Rows.Remove(row);
                        log.showVender(vendorView);
                        BTN();
                        clearBox();
                        if (saveBtn.Text == "Update")
                        {
                            saveBtn.Text = "Save";
                        }
                    }
                    else
                    {
                        // If 'No', do something here.
                        return;
                    }

                }
            }
            
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            log.SearchVendor(vendorView, searchText.Text);
            BTN();
        }

        private void searchText_Enter(object sender, EventArgs e)
        {
            if (searchText.Text == "Search...")
            {
                searchText.Text = "";
                searchText.ForeColor = Color.Black;
            }
        }

        private void searchText_Leave(object sender, EventArgs e)
        {
            if (searchText.Text == "")
            {
                searchText.Text = "Search...";
                searchText.ForeColor = Color.Gray;
                log.showVender(vendorView);
                BTN();
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(nameText, vendorError);
        }

        private void addressText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(addressText, vendorError);
        }

        private void nmbrText_Leave(object sender, EventArgs e)
        {
            MainClass.mobileNo(nmbrText, vendorError);
        }

        private void personText_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyAlphabet(personText, vendorError);
        }


        private void emailText_TextChanged(object sender, EventArgs e)
        {
            MainClass.checkEmail(emailText, vendorError);
        }
    }
}
