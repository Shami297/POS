using POS_Logics;
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
    public partial class Product : Sample3
    {
        Logics log = new Logics();
        public Product()
        {
            InitializeComponent();
            log.viewProduct(productView);
            BTN();
            productView.AllowUserToAddRows = false;
        }

        public void clearBox()
        {
            nameText.Text = "";
            descrpText.Text = "";
            categoryBox.SelectedIndex = 0;
            subCategoryBox.SelectedIndex = 0;
            ManfBox.SelectedIndex = 0;
            costText.Text = "";
            listText.Text = "";
            saleText.Text = "";
            locationText.Text = "";
            MinimumText.Text = "";
            TargetText.Text = "";
            barcodeText.Text = "";
        }

        private void BTN()
        {
            productView.Columns["DeleteBtn"].DisplayIndex = productView.ColumnCount - 1;
            productView.Columns["Editbtn"].DisplayIndex = productView.ColumnCount - 2;
            productView.Columns["ProductID"].Visible = false;
        }

        private void saveData()
        {
            // int catID = (int)categoryBox.SelectedValue;
            //int manfID = (int)ManfBox.SelectedValue;
            log.addProduct(nameText.Text,
                barcodeText.Text,
             (int)categoryBox.SelectedValue,
            (int)ManfBox.SelectedValue,
            (int)subCategoryBox.SelectedValue,
                descrpText.Text,
               costText.Text == "" ? 0 : Convert.ToInt32(costText.Text),
               listText.Text == "" ? 0 : Convert.ToInt32(listText.Text),
               saleText.Text == "" ? 0 : Convert.ToInt32(saleText.Text),
                1,
                MinimumText.Text == "" ? 0 : Convert.ToInt32(MinimumText.Text),
                TargetText.Text == "" ? 0 : Convert.ToInt32(TargetText.Text),
                locationText.Text);
            //log.addProduct(nameText.Text, subCategoryBox.SelectedValue, categoryBox.SelectedValue, ManfBox.SelectedValue, descrpText.Text, Convert.ToInt32(costText.Text), Convert.ToInt32(listText.Text), Convert.ToInt32(saleText.Text), 1, Convert.ToInt32(MinimumText.Text), Convert.ToInt32(TargetText.Text), locationText.Text);

        }


        private void updateData()
        {
            int catID = (int)categoryBox.SelectedValue;
            int manfID = (int)ManfBox.SelectedValue;
            int subCatID = (int)subCategoryBox.SelectedValue;
            log.updateProduct(nameText.Text,barcodeText.Text, proID, catID, manfID, subCatID, descrpText.Text, Convert.ToInt32(costText.Text), Convert.ToInt32(listText.Text), Convert.ToInt32(saleText.Text), Convert.ToInt32(MinimumText.Text), Convert.ToInt32(TargetText.Text), locationText.Text);

        }

        private void manufacturer()
        {
            ManufacturerManager manufacturer = new ManufacturerManager();
            ManfBox.DisplayMember = "Name";
            ManfBox.ValueMember = "ID";
            ManfBox.DataSource = manufacturer.GetManufacturers();
        }

        private void SubCategory()
        {
            int catid = (int)categoryBox.SelectedValue;
            SubCategoryManager subCategoryManager = new SubCategoryManager();
            subCategoryBox.DisplayMember = "Name";
            subCategoryBox.ValueMember = "ID";
            subCategoryBox.DataSource = subCategoryManager.GetSubCategories(catid);
        }

        private void CategoryManager()
        {
            CategoryManager categoryManager = new CategoryManager();
            categoryBox.DisplayMember = "Name";
            categoryBox.ValueMember = "ID";
            categoryBox.DataSource = categoryManager.GetCategories();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            nameText.Focus();
            manufacturer();
            CategoryManager();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (searchText.Text == "Search...")
            {
                searchText.Text = "";
                searchText.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (searchText.Text == "")
            {
                searchText.Text = "Search...";
                searchText.ForeColor = Color.Gray;
                log.viewProduct(productView);
                BTN();
            }
        }

        private void toUpdate()
        {
            MainClass.isEmpty(costText);
            MainClass.isEmpty(listText);
            MainClass.isEmpty(saleText);
            MainClass.isEmpty(MinimumText);
            MainClass.isEmpty(TargetText);
            updateData();
            MessageBox.Show("Product is Updated", "Success");
            log.viewProduct(productView);
            BTN();
            clearBox();
            saveBtn.Text = "Save";
        }

        private bool checkEmpty()
        {
            if (nameText.Text == "")
            {
                MessageBox.Show("Please enter product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameText.Focus();
                return false;
            }
            else if (nameText.Text.Trim().Length == 0) // only Spaces Not allowed
            {
                MessageBox.Show("Only Spaces are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameText.Text = "";
                nameText.Focus();
                return false;
            }
            else if (barcodeText.Text == "")
            {
                MessageBox.Show("Please enter Product Barcode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                barcodeText.Focus();
                return false;
            }
            else if (barcodeText.Text.Trim().Length == 0) // only Spaces Not allowed
            {
                MessageBox.Show("Only Spaces are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameText.Text = "";
                barcodeText.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmpty())
                {
                    if (saveBtn.Text == "Update")
                    {
                        if (name == nameText.Text)
                        {
                            if (barcode == barcodeText.Text)
                            {
                                toUpdate();
                                nameText.Focus();
                            }

                            // Add another Barcode

                            if (barcode != barcodeText.Text)
                            {
                                var confirmResult = MessageBox.Show("Are you sure to add another Barcode for this Product ??",
                                         "Confirm Addition!!",
                                         MessageBoxButtons.YesNo);
                                if (confirmResult == DialogResult.Yes)
                                {
                                    if (!log.checkBarcodeDuplication(barcodeText.Text, proID))
                                    {
                                        MessageBox.Show("This barcode already exist", "Error",                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        barcodeText.Text = "";
                                        barcodeText.Focus();
                                    }
                                }
                                else
                                {
                                    // If 'No', do something here.
                                    barcodeText.Text = barcode;
                                    barcodeText.Focus();
                                }
                            }

                            
                            else
                            {
                                toUpdate();
                                nameText.Focus();
                            }
                        }
                        else
                        {
                            if (!log.checkProductDuplication(nameText.Text, proID, (int)ManfBox.SelectedValue))
                            {
                                MessageBox.Show("This Product already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                nameText.Text = "";
                                nameText.Focus();
                            }
                            else if (!log.checkBarcodeDuplication(barcodeText.Text, proID))
                            {
                                MessageBox.Show("This barcode already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                barcodeText.Text = "";
                                barcodeText.Focus();
                            }
                            else
                            {
                                toUpdate();
                                nameText.Focus();
                            }
                        }
                    }
                    else if (saveBtn.Text == "Save")
                    {
                        if (!log.checkProductDuplication(nameText.Text, proID, (int)ManfBox.SelectedValue))
                        {
                            MessageBox.Show("This Product already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nameText.Text = "";
                            nameText.Focus();
                        }
                        else if (!log.checkBarcodeDuplication(barcodeText.Text, proID))
                        {
                            MessageBox.Show("This barcode already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            barcodeText.Text = "";
                            barcodeText.Focus();
                        }
                        else
                        {
                            saveData();
                            MessageBox.Show("Product is saved","Success");
                            log.viewProduct(productView);
                            BTN();
                            clearBox();
                            nameText.Focus();
                        }
                    }
                }
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                // MessageBox.Show("Please enter valid values");
                DBconnection.conn.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            log.SearchProduct(productView, searchText.Text);
            BTN();
        }


        public int proID;
        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            // Your Business Logic
            if (productView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                productView.CurrentCell.Selected = true;
                proID = Convert.ToInt32(productView.Rows[e.RowIndex].Cells["ProductID"].FormattedValue.ToString());
                nameText.Text = productView.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                barcodeText.Text = productView.Rows[e.RowIndex].Cells["Barcode"].FormattedValue.ToString();
                descrpText.Text = productView.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                categoryBox.Text = productView.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
                subCategoryBox.Text = productView.Rows[e.RowIndex].Cells["SubCategory"].FormattedValue.ToString();
                ManfBox.Text = productView.Rows[e.RowIndex].Cells["Manufacturer"].FormattedValue.ToString();
                costText.Text = productView.Rows[e.RowIndex].Cells["Cost"].FormattedValue.ToString();
                listText.Text = productView.Rows[e.RowIndex].Cells["ListPrice"].FormattedValue.ToString();
                saleText.Text = productView.Rows[e.RowIndex].Cells["SalePrice"].FormattedValue.ToString();
                locationText.Text = productView.Rows[e.RowIndex].Cells["Location"].FormattedValue.ToString();
                MinimumText.Text = productView.Rows[e.RowIndex].Cells["MinimumQty"].FormattedValue.ToString();
                TargetText.Text = productView.Rows[e.RowIndex].Cells["TargetQty"].FormattedValue.ToString();
            }
        }

        public string name, barcode;
        private void productView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) //Edit
                {
                    LoadEditData(e);
                    saveBtn.Text = "Update";
                    name = nameText.Text;
                    barcode = barcodeText.Text;
                }
                if (e.ColumnIndex == 1) //Delete
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this Product ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // If 'Yes', do something here.
                        DataGridViewRow row = productView.Rows[e.RowIndex];
                        int proID = Convert.ToInt32(row.Cells["ProductID"].Value.ToString());
                        log.deleteProduct(proID);
                        productView.Rows.Remove(row);
                        log.viewProduct(productView);
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

        private void categoryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ManfBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void subCategoryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void costText_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(costText, productError);
        }

        private void listText_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(listText, productError);
        }

        private void saleText_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(saleText, productError);
        }

        private void MinimumText_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(MinimumText, productError);
        }

        private void TargetText_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(TargetText, productError);
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(nameText, productError);
        }

        private void descrpText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(descrpText, productError);
        }

        private void locationText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(locationText, productError);
        }

        private void barcodeText_TextChanged(object sender, EventArgs e)
        {
            MainClass.alphaNumericSpecial(barcodeText, productError);
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBox txtRun = new TextBox();
            txtRun.Name = "txtDynamic";
            txtRun.Location = new System.Drawing.Point(20, 18);
            txtRun.Size = new System.Drawing.Size(200, 25);
            // Add the textbox control to the form's control collection         
            this.Controls.Add(txtRun);
        }

        int disUnit = 1;

        private void barcodeText_DoubleClick(object sender, EventArgs e)
        {
            //TextBox text = new TextBox();
            //this.Controls.Add(text);
            //text.Top = disUnit * 70;
            //text.Left = 420;
            //disUnit = disUnit + 1;
            //text.ForeColor = Color.Gray;
            //text.Font = new Font("arial", 20.25f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            //text.Size = new Size(153, 29);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            TextBox text = new TextBox();
            this.Controls.Add(text);
            text.Top = disUnit * 70;
            text.Left = 420;
            disUnit = disUnit + 1;
            text.ForeColor = Color.Gray;
            text.Font = new Font("arial", 20.25f, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            text.Size = new Size(153, 29);
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategory();
        }
    }
}
