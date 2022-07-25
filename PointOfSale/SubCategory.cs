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
    public partial class SubCategory : Sample3
    {
        Logics log = new Logics();
        public SubCategory()
        {
            InitializeComponent();
            log.viewSubCategory(SubCategoryView);
            BTN();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            CategoryManager categoryManager = new CategoryManager();
            categoryBox.DataSource = categoryManager.GetCategories();
            categoryBox.DisplayMember = "Name";
            categoryBox.ValueMember = "ID";
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
            }
        }

        private void categoryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void saveSubCategory()
        {
            log.addSubCategory(nameText.Text, (int)categoryBox.SelectedValue);
        }

        public int ID;
        private void updateSubCategory()
        {
            log.UpdateSubCategory(nameText.Text, ID, (int)categoryBox.SelectedValue);
        }


        private void BTN()
        {
            SubCategoryView.Columns["deletebtn"].DisplayIndex = SubCategoryView.ColumnCount - 1;
            SubCategoryView.Columns["Editbtn"].DisplayIndex = SubCategoryView.ColumnCount - 2;
            SubCategoryView.Columns["ID"].Visible = false;
        }

        private void checkUpdate()
        {
            updateSubCategory();
            MessageBox.Show("Category is Updated", "Success");
            log.viewSubCategory(SubCategoryView);
            BTN();
            nameText.Text = "";
            categoryBox.SelectedIndex = 0;
            saveBtn.Text = "Save";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameText.Text == "")
                {
                    MessageBox.Show("Please enter some value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (!log.checkSubCategoryDuplication(nameText.Text))
                        {
                            MessageBox.Show("This Sub Category already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nameText.Text = "";
                            nameText.Focus();
                        }
                        else
                        {
                            saveSubCategory();
                            MessageBox.Show("Category is saved","Success");
                            categoryBox.SelectedIndex = 0;
                            nameText.Text = "";
                            nameText.Focus();
                            log.viewSubCategory(SubCategoryView);
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
                            if (!log.checkSubCategoryDuplication(nameText.Text))
                            {
                                MessageBox.Show("This Sub Category already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            // Your Business Logic
            if (SubCategoryView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                SubCategoryView.CurrentCell.Selected = true;
                ID = Convert.ToInt32(SubCategoryView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                categoryBox.Text = SubCategoryView.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
                nameText.Text = SubCategoryView.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
            }
        }

        public string name;
        private void SubCategoryView_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    var confirmResult = MessageBox.Show("Are you sure to delete this Category ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // If 'Yes', do something here.
                        DataGridViewRow row = SubCategoryView.Rows[e.RowIndex];
                        ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                        log.deleteSubCategory(ID);
                        SubCategoryView.Rows.Remove(row);
                        log.viewSubCategory(SubCategoryView);
                        nameText.Text = "";
                        categoryBox.SelectedIndex = 0;
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

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            MainClass.AlphaNumeric(nameText, SubCatError);
        }
    }
}
