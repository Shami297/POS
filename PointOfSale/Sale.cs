using POS_Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Sale : Form
    {
        Logics log = new Logics();
        //private static System.Timers.Timer aTimer;
        public Sale()
        {
            InitializeComponent();
            cartGV.AllowUserToAddRows = false;
            //// Create a timer and set a two second interval.
            //aTimer = new System.Timers.Timer();
            //aTimer.Interval = 2000;

            //// Hook up the Elapsed event for the timer. 
            //aTimer.Elapsed += OnTimedEvent;

            //// Have the timer fire repeated events (true is the default)
            //aTimer.AutoReset = true;

            //// Start the timer
            //aTimer.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Product p = new Product();
            p.Show();
            p.BringToFront();
        }

        private void populateCustomer()
        {
            CustomerManager customerManager = new CustomerManager();

            customerBox.DisplayMember = "Name";
            customerBox.ValueMember = "ID";
            customerBox.DataSource = customerManager.GetCustomers();

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            log.saleTextbox(ref saleNameTxt);
            populateCustomer();
        }

        private void addToCart()
        {
            // Add products in Grid View
            if (saleNameTxt.Text == "")
            {
                MessageBox.Show("Select Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saleNameTxt.Focus();
            }
            else if (SaleQtyTxt.Text == "" || SaleQtyTxt.Text == "0")
            {
                MessageBox.Show("Enter Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PriceTxt.Text == "" || PriceTxt.Text == "0")
            {
                MessageBox.Show("Enter Product Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cartGV.Rows.Add(productID, product.Trim(), PriceTxt.Text, SaleQtyTxt.Text, TotalAmountTxt.Text);
                afterCart();
                clearControl();
            }
        }

        private void clearControl()
        {
            saleNameTxt.Text = "";
            PriceTxt.Text = "";
            SaleQtyTxt.Text = "";
            TotalAmountTxt.Text = "";
            AvailableQtyTxt.Text = "";
            saleNameTxt.Focus();
        }

        private void clearBox()
        {
            SubTotalTxt.Text = "";
            TaxAmtTxt.Text = "";
            DiscountAmountTxt.Text = "";
            FlatDiscTxt.Text = "";
            TotalTxt.Text = "";
            TotalPaymentTxt.Text = "";
            PaymentDueTxt.Text = "";
            cmbPaymentType.Text = "";
            notesText.Text = "";
            cartGV.Rows.Clear();
            customerBox.SelectedValue = 1;
            clearControl();
        }
        private void afterCart()
        {
            if (SubTotalTxt.Text == "")
            {
                SubTotalTxt.Text = TotalAmountTxt.Text;
            }
            else
            {
                float subTotal, grosstotal, total;
                subTotal = (float)Convert.ToDouble(SubTotalTxt.Text);
                grosstotal = (float)Convert.ToDouble(TotalAmountTxt.Text);
                total = subTotal + grosstotal;
                SubTotalTxt.Text = total.ToString();
            }
            clearControl();
        }

        public int productID = 0;
        public string product;


        private void productData()
        {
            int pid = 0, salePrice = 0, trgtQty = 0, mid = 0;
            string s1 = saleNameTxt.Text;
            product = s1.Trim();
            if (saleNameTxt.Text.Contains("|"))
            {
                product = s1.Substring(0, s1.IndexOf("|"));
                string mnfName = s1.Split('|').Last();
                mid = log.getMnfID(mnfName.Trim());
            }
            else
            {
                if (!log.checkProductName(s1))
                {
                    goto Here;
                }
                else
                {
                    MessageBox.Show("This Product does not Exist","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    saleNameTxt.Text = "";
                    saleNameTxt.Focus();
                }
            }
            Here:
            if (mid == 0)
            {
                mid = 1;
            }
            DBconnection.conn.Open();
            SqlCommand sql_cmnd = new SqlCommand("SPR_Purchase", DBconnection.conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@Opcode", SqlDbType.VarChar).Value = 3;
            sql_cmnd.Parameters.AddWithValue("@Record", SqlDbType.VarChar).Value = product;
            sql_cmnd.Parameters.AddWithValue("@Mnf_ID", SqlDbType.Int).Value = mid;
            SqlDataReader dataReader = sql_cmnd.ExecuteReader();
            while (dataReader.Read())
            {
                pid = Convert.ToInt32(dataReader[0].ToString());
                salePrice = Convert.ToInt32(dataReader[1].ToString());
                trgtQty = Convert.ToInt32(dataReader[2].ToString());
            }
            DBconnection.conn.Close();
            productID = pid;
            AvailableQtyTxt.Text = log.getAvailQty(productID).ToString();
            PriceTxt.Text = salePrice.ToString();
            SaleQtyTxt.Text = trgtQty.ToString();
        }

        private void customerBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void saleNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                foreach (DataGridViewRow row in cartGV.Rows)
                {
                    int addedProId = Convert.ToInt32(row.Cells["idGV"].Value.ToString());
                    if (productID == addedProId)
                    {
                        MessageBox.Show("This product exists  in cart","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearControl();
                        return;
                    }
                }
                productData();
                SaleQtyTxt.SelectAll();
                SaleQtyTxt.Focus();
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void CalculatePrice()
        {
            if (SaleQtyTxt.Text == "" || SaleQtyTxt.Text == "0")
            {
                TotalAmountTxt.Text = "";
            }
            else
            {
                float price, quan, total;
                price = (float)Convert.ToDouble(PriceTxt.Text);
                quan = (float)Convert.ToDouble(SaleQtyTxt.Text);
                total = price * quan;
                TotalAmountTxt.Text = total.ToString();
            }
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(PriceTxt, saleError);
            MainClass.isEmpty(PriceTxt);
            CalculatePrice();
        }

        private void PurQtyTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(SaleQtyTxt, saleError);
            MainClass.isEmpty(SaleQtyTxt);
            //MainClass.isEmpty(AvailableQtyTxt);
            AvailableQtyTxt.Text = log.getAvailQty(productID).ToString();
            int availQty = Convert.ToInt32(AvailableQtyTxt.Text);
            int buyQty = Convert.ToInt32(SaleQtyTxt.Text);
            if(buyQty > availQty)
            {
                MessageBox.Show("Quantity Exceeded from Stock"+ Environment.NewLine +"      Stock available is " + availQty,"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaleQtyTxt.Text = "";
            }
            CalculatePrice();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            saleNameTxt.Clear();
            clearControl();
            saleNameTxt.Focus();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            addToCart();
            productID = 0;
        }

        private void PurQtyTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addToCart();
                productID = 0;
            }
        }

        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            // Your Business Logic
            if (cartGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                cartGV.CurrentCell.Selected = true;
                productID = Convert.ToInt32(cartGV.Rows[e.RowIndex].Cells["idGV"].FormattedValue.ToString());
                saleNameTxt.Text = cartGV.Rows[e.RowIndex].Cells["nameGV"].FormattedValue.ToString();
                PriceTxt.Text = cartGV.Rows[e.RowIndex].Cells["priceGV"].FormattedValue.ToString();
                SaleQtyTxt.Text = cartGV.Rows[e.RowIndex].Cells["quanGV"].FormattedValue.ToString();
                TotalAmountTxt.Text = cartGV.Rows[e.RowIndex].Cells["totalGV"].FormattedValue.ToString();
            }
        }

        private void cartGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5) //Edit
                {
                    AvailableQtyTxt.Text = log.getAvailQty(productID).ToString();
                    LoadEditData(e);
                    DataGridViewRow row = cartGV.Rows[e.RowIndex];
                    float subTotal = (float)Convert.ToDouble(SubTotalTxt.Text);
                    float grossToatal = (float)Convert.ToDouble(row.Cells["totalGV"].Value.ToString());
                    float Total = subTotal - grossToatal;
                    SubTotalTxt.Text = Total.ToString();
                    cartGV.Rows.Remove(row);
                    SaleQtyTxt.Focus();
                }
                if (e.ColumnIndex == 6) //DELETE
                {
                    DataGridViewRow row = cartGV.Rows[e.RowIndex];
                    float subTotal = (float)Convert.ToDouble(SubTotalTxt.Text);
                    float grossToatal = (float)Convert.ToDouble(row.Cells["totalGV"].Value.ToString());
                    float Total = subTotal - grossToatal;
                    SubTotalTxt.Text = Total.ToString();
                    cartGV.Rows.Remove(row);
                    if (cartGV.Rows.Count == 0)
                    {
                        SubTotalTxt.Text = "";
                    }
                }
            }
        }

        private void SubTotalTxt_TextChanged(object sender, EventArgs e)
        {
            if (SubTotalTxt.Text == "")
            {
                TotalPaymentTxt.Text = "";
            }
            else
            {
                TotalPaymentTxt.Text = SubTotalTxt.Text;
            }
        }

        private void DiscountPerTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(DiscountPerTxt, saleError);
            if (DiscountPerTxt.Text != "" && SubTotalTxt.Text != "")
            {
                float subTotal, discount, amount, gTotal;
                discount = (float)Convert.ToDouble(DiscountPerTxt.Text);
                subTotal = (float)Convert.ToDouble(SubTotalTxt.Text);
                amount = (discount * subTotal) / 100;
                DiscountAmountTxt.Text = amount.ToString();
                gTotal = subTotal - amount;
                TotalTxt.Text = gTotal.ToString();
                TotalPaymentTxt.Text = gTotal.ToString();
            }
            else if (DiscountPerTxt.Text == "")
            {
                TotalTxt.Text = "";
                TotalPaymentTxt.Text = SubTotalTxt.Text;
                DiscountAmountTxt.Text = "";
            }
        }

        private void DiscountPerTxt_MouseClick(object sender, MouseEventArgs e)
        {
            DiscountPerTxt.SelectAll();
        }

        int saleInvoiceID;
        private int saveInvoice()
        {
            MainClass.isEmpty(DiscountAmountTxt);
            int customerID = (int)customerBox.SelectedValue;
            float discountAmount = (float)Convert.ToDouble(DiscountAmountTxt.Text);
            float DP = (float)Convert.ToDouble(DiscountPerTxt.Text);
            if (discountAmount == 0)
            {
                DP = 0;
            }
            float amount = (float)Convert.ToDecimal(TotalPaymentTxt.Text);
            int invoiceNo = generateNO();
            log.addSale(invoiceNo, customerID,0,0,DP,discountAmount,0,amount,1,notesText.Text);
            saleInvoiceID = log.getSaleInvoiceID();
            return saleInvoiceID;
        }

        int count = 0;
        private int saveInvoiceDetails()
        {
            int saleID, proID;
            saleID = saleInvoiceID;
            foreach (DataGridViewRow row in cartGV.Rows)
            {
                proID = 0;
                proID = Convert.ToInt32(row.Cells["idGV"].Value.ToString());
                float quantity = (float)Convert.ToDouble(row.Cells["quanGV"].Value.ToString());
                float total = (float)Convert.ToDouble(row.Cells["totalGV"].Value.ToString());
                float price = (float)Convert.ToDouble(row.Cells["priceGV"].Value.ToString());
                log.addSaleDetail(saleID,proID,quantity,price,total);
                //Inventory Update
                log.UpdateInventory(proID,quantity);

                count++;
            }
            return count;
        }

        private int generateNO()
        {
            int purchaseNO = log.getInvoiceNO();
            purchaseNO += 1;
            return purchaseNO;
        }

        private void saveBtn()
        {
            if (cartGV.Rows.Count > 0)
            {

                saveInvoice();
                saveInvoiceDetails();

                //afterSave();
                if (count > 0)
                {
                    var confirmResult = MessageBox.Show("Do you want to print receipt ?",
                     "Confirm Receipt!!",
                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Purchase Invoice Saved", "Success");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to Generat Purchase Invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select Products", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveBtn();
            clearBox();
            //receiptGroup.Enabled = false;
            //productGroup.Enabled = true;
            saleNameTxt.Focus();
        }

        private void SubTotalTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (SubTotalTxt.Text == "")
            {
                TotalPaymentTxt.Text = "";
            }
            else
            {
                TotalPaymentTxt.Text = SubTotalTxt.Text;
            }
        }
    }
}
