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
    public partial class Manufacture : Sample3
    {
        Logics logics = new Logics();
        public Manufacture()
        {
            InitializeComponent();
            logics.viewManufacture(ManufactureView);
            BTN();
            ManufactureView.AllowUserToAddRows = false;
        }

        private void BTN()
        {
            ManufactureView.Columns["deletebtn"].DisplayIndex = ManufactureView.ColumnCount - 1;
            ManufactureView.Columns["Editbtn"].DisplayIndex = ManufactureView.ColumnCount - 2;
            ManufactureView.Columns["ID"].Visible = false;
        }

        private void checkUpdate()
        {
            updateData();
            MessageBox.Show("Manufacturer is Updated");
            logics.viewManufacture(ManufactureView);
            BTN();
            nameText.Text = "";
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
                        if (!logics.checkManufacturerDuplication(nameText.Text))
                        {
                            MessageBox.Show("This Manufacturer already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nameText.Text = "";
                            nameText.Focus();
                        }
                        else
                        {
                            logics.addManufacture(nameText.Text);
                            MessageBox.Show("Manufacturer is saved", "Success");
                            nameText.Text = "";
                            nameText.Focus();
                            logics.viewManufacture(ManufactureView);
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
                            if (!logics.checkManufacturerDuplication(nameText.Text))
                            {
                                MessageBox.Show("This Manufacturer already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Manufacture_Load(object sender, EventArgs e)
        {
            logics.viewManufacture(ManufactureView);
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
                logics.viewManufacture(ManufactureView);
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            logics.SearchManufacture(ManufactureView, searchText.Text);
        }

        private void updateData()
        {
            logics.UpdateManufacture(nameText.Text, ID);

        }

        public int ID;

        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            // Your Business Logic
            if (ManufactureView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ManufactureView.CurrentCell.Selected = true;
                ID = Convert.ToInt32(ManufactureView.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                nameText.Text = ManufactureView.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
            }
        }

        public string name;
        private void ManufactureView_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    var confirmResult = MessageBox.Show("Are you sure to delete this Manufacturer ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // If 'Yes', do something here.
                        DataGridViewRow row = ManufactureView.Rows[e.RowIndex];
                        ID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                        logics.deleteManufacture(ID);
                        ManufactureView.Rows.Remove(row);
                        logics.viewManufacture(ManufactureView);
                        BTN();
                        nameText.Text = "";
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
            MainClass.AlphaNumeric(nameText, ManfError);
        }
    }
}
