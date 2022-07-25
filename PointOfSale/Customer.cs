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
    public partial class Customer : Sample3
    {
        Logics logics = new Logics();
        public Customer()
        {
            InitializeComponent();
            logics.viewCustomer(customerView);
            BTN();
            customerView.AllowUserToAddRows = false;
        }

        private void BTN()
        {
            customerView.Columns["DeleteBtn"].DisplayIndex = customerView.ColumnCount - 1;
            customerView.Columns["Editbtn"].DisplayIndex = customerView.ColumnCount - 2;
            customerView.Columns["CustomerID"].Visible = false;
        }

        private void clearBox()
        {
            nameText.Text = "";
            addressText.Text = "";
            nmbrText.Text = "";
            accountText.Text = "";
            emailText.Text = "";
        }

        private void saveCustomer()
        {
            logics.addCustomer(nameText.Text, addressText.Text, nmbrText.Text, accountText.Text, emailText.Text);
        }

        private void updateCustomer()
        {
            logics.updateCustomer(nameText.Text,customerID, addressText.Text, nmbrText.Text, accountText.Text, emailText.Text);
        }

        public int customerID;

        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            // Your Business Logic
            if (customerView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                customerView.CurrentCell.Selected = true;
                customerID = Convert.ToInt32(customerView.Rows[e.RowIndex].Cells["CustomerID"].FormattedValue.ToString());
                nameText.Text = customerView.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                addressText.Text = customerView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                nmbrText.Text = customerView.Rows[e.RowIndex].Cells["ContactNo"].FormattedValue.ToString();
                accountText.Text = customerView.Rows[e.RowIndex].Cells["AccountNo"].FormattedValue.ToString();
                emailText.Text = customerView.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            }
        }


        public string name;
        private void customerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) //Edit
                {
                    LoadEditData(e);
                    saveBtn.Text = "Update";
                    name = nameText.Text;
                }
                if (e.ColumnIndex == 1) //Delete
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this Customer ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // If 'Yes', do something here.
                        DataGridViewRow row = customerView.Rows[e.RowIndex];
                        int customerID = Convert.ToInt32(row.Cells["CustomerID"].Value.ToString());
                        logics.deleteCustomer(customerID);
                        customerView.Rows.Remove(row);
                        logics.viewCustomer(customerView);
                        BTN();
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

        private void checkUpdate()
        {
            MainClass.isEmpty(nmbrText);
            MainClass.isEmpty(accountText);
            updateCustomer();
            MessageBox.Show("Customer is Updated", "Success");
            logics.viewCustomer(customerView);
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
                    MessageBox.Show("Please enter customer name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (!logics.checkCustomerDuplication(nameText.Text))
                        {
                            MessageBox.Show("This Customer already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nameText.Text = "";
                            nameText.Focus();
                        }
                        else
                        {
                            MainClass.isEmpty(nmbrText);
                            MainClass.isEmpty(accountText);
                            saveCustomer();
                            MessageBox.Show("Customer is saved", "Success");
                            logics.viewCustomer(customerView);
                            BTN();
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
                            if (!logics.checkCustomerDuplication(nameText.Text))
                            {
                                MessageBox.Show("This Customer already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            logics.SearchCustomer(customerView, searchText.Text);
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
                logics.viewCustomer(customerView);
                BTN();
            }
        }

        private void nmbrText_Leave(object sender, EventArgs e)
        {
            MainClass.mobileNo(nmbrText, customerError);
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            MainClass.checkEmail(emailText, customerError);
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyAlphabet(nameText, customerError);
        }

        private void addressText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(addressText, customerError);
        }

        private void accountText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(accountText, customerError);
        }
    }
}
