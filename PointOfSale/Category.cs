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
    public partial class Category : Sample3
    {
        Logics logics = new Logics();
        public Category()
        {
            InitializeComponent();
            logics.viewCategory(CategoryView);
            BTN();
            CategoryView.AllowUserToAddRows = false;
        }

        private void BTN()
        {
            CategoryView.Columns["deletebtn"].DisplayIndex = CategoryView.ColumnCount - 1;
            CategoryView.Columns["Editbtn"].DisplayIndex = CategoryView.ColumnCount - 2;
            CategoryView.Columns["ID"].Visible = false;
        }

        private void checkUpdate()
        {
            updateData();
            MessageBox.Show("Category is Updated", "Success");
            logics.viewCategory(CategoryView);
            BTN();
            nameText.Text = "";
            saveBtn.Text = "Save";
        }

        private void button1_Click(object sender, EventArgs e)
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
                        if (!logics.checkCategoryDuplication(nameText.Text))
                        {
                            MessageBox.Show("This Category already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nameText.Text = "";
                            nameText.Focus();
                        }
                        else
                        {
                            logics.addCategory(nameText.Text);
                            MessageBox.Show("Category is saved", "Success");
                            nameText.Text = "";
                            nameText.Focus();
                            logics.viewCategory(CategoryView);
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
                            if (!logics.checkCategoryDuplication(nameText.Text))
                            {
                                MessageBox.Show("This Category already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Category_Load(object sender, EventArgs e)
        {
            logics.viewCategory(CategoryView);
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
                logics.viewCategory(CategoryView);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            logics.SearchCategory(CategoryView,searchText.Text);
        }

        private void updateData()
        {
            logics.UpdateCategory(nameText.Text,catID);

        }

        public int catID;

        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            try
            {
                // Your Business Logic
                if (CategoryView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    CategoryView.CurrentCell.Selected = true;
                    catID = Convert.ToInt32(CategoryView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                    nameText.Text = CategoryView.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                }
            }

            catch
            {
                
            }
        }

        public string name;
        private void CategoryView_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        DataGridViewRow row = CategoryView.Rows[e.RowIndex];
                        catID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                        logics.deleteCategory(catID);
                        CategoryView.Rows.Remove(row);
                        logics.viewCategory(CategoryView);
                        BTN();
                        if(saveBtn.Text == "Update")
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
            MainClass.AlphaNumeric(nameText, CatError);
        }
    }
}
