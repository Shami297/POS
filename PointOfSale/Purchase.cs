using CrystalDecisions.CrystalReports.Engine;
using POS_Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Purchase : Form
    {
        Logics log = new Logics();
        public Purchase()
        {
            InitializeComponent();
            cartGV.AllowUserToAddRows = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Product p = new Product();
            p.Show();
            p.BringToFront();
        }

        private void populateVendor()
        {
            VendorManager vendorManager = new VendorManager();

            vendorBox.DisplayMember = "Name";
            vendorBox.ValueMember = "ID";
            vendorBox.DataSource = vendorManager.GetVendors();

        }
        private void Purchase_Load(object sender, EventArgs e)
        {
            log.productTextbox(ref ProductNameTxt);
            populateVendor();
        }


        private void addToCart()
        {
            // Add products in Grid View
            if (ProductNameTxt.Text == "")
            {
                MessageBox.Show("Select Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductNameTxt.Focus();
            }
            else if (PurQtyTxt.Text == "" || PurQtyTxt.Text == "0")
            {
                MessageBox.Show("Enter Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PriceTxt.Text == "" || PriceTxt.Text == "0")
            {
                MessageBox.Show("Enter Product Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cartGV.Rows.Add(productID, product.Trim(),PriceTxt.Text,PurQtyTxt.Text,TotalAmountTxt.Text);
                afterCart();
                clearControl();
            }
        }

        private void clearControl()
        {
            ProductNameTxt.Text = "";
            PriceTxt.Text = "";
            PurQtyTxt.Text = "";
            TotalAmountTxt.Text = "";
            AvailableQtyTxt.Text = "";
            ProductNameTxt.Focus();
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
            vendorBox.SelectedValue = 1;
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
                subTotal =(float) Convert.ToDouble(SubTotalTxt.Text);
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
            string s1 = ProductNameTxt.Text;
            product = s1.Trim();
            if (ProductNameTxt.Text.Contains("|"))
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
                    ProductNameTxt.Text = "";
                    ProductNameTxt.Focus();
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
            PriceTxt.Text = salePrice.ToString();
            PurQtyTxt.Text = trgtQty.ToString();
            productID = pid;
            AvailableQtyTxt.Text = log.getAvailQty(productID).ToString();
        }


        private void vendorBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void LoadEditData(DataGridViewCellEventArgs e)
        {
            // Your Business Logic
            if (cartGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                cartGV.CurrentCell.Selected = true;
                productID = Convert.ToInt32(cartGV.Rows[e.RowIndex].Cells["idGV"].FormattedValue.ToString());
                ProductNameTxt.Text = cartGV.Rows[e.RowIndex].Cells["nameGV"].FormattedValue.ToString();
                PriceTxt.Text = cartGV.Rows[e.RowIndex].Cells["priceGV"].FormattedValue.ToString();
                PurQtyTxt.Text = cartGV.Rows[e.RowIndex].Cells["quanGV"].FormattedValue.ToString();
                TotalAmountTxt.Text = cartGV.Rows[e.RowIndex].Cells["totalGV"].FormattedValue.ToString();
                AvailableQtyTxt.Text = log.getAvailQty(productID).ToString();
            }
        }


        private void cartGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5) //Edit
                {
                    if(productGroup.Enabled == false)
                    {
                        productGroup.Enabled = true;
                        receiptGroup.Enabled = false;
                    }
                    LoadEditData(e);
                    DataGridViewRow row = cartGV.Rows[e.RowIndex];
                    float subTotal = (float)Convert.ToDouble(SubTotalTxt.Text);
                    float grossToatal = (float)Convert.ToDouble(row.Cells["totalGV"].Value.ToString());
                    float Total = subTotal - grossToatal;
                    SubTotalTxt.Text = Total.ToString();
                    cartGV.Rows.Remove(row);
                    PurQtyTxt.Focus();
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

        private void NewRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase purchase = new Purchase();
            purchase.Show();
        }

        private void ProductNameTxt_KeyDown(object sender, KeyEventArgs e)
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
                        //int grossTotal = Convert.ToInt32(row.Cells["totalGV"].Value.ToString());
                        //int quantity = Convert.ToInt32(row.Cells["quanGV"].Value.ToString());
                        //int quan = Convert.ToInt32(PurQtyTxt.Text);
                        //quan = quantity + quan;
                        //grossTotal += Convert.ToInt32(TotalAmountTxt.Text);
                        //row.Cells["quanGV"].Value = quan.ToString();
                        //row.Cells["totalGV"].Value = grossTotal.ToString();
                        //SubTotalTxt.Text = (Convert.ToInt32(TotalAmountTxt.Text) + Convert.ToInt32(SubTotalTxt.Text)).ToString();
                    }
                }
                productData();
                PurQtyTxt.SelectAll();
                PurQtyTxt.Focus();
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void DiscountPerTxt_MouseClick(object sender, MouseEventArgs e)
        {
            DiscountPerTxt.SelectAll();
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

        private void CalculatePrice()
        {
            if (PurQtyTxt.Text == "" || PurQtyTxt.Text == "0")
            {
                TotalAmountTxt.Text = "";
            }
            else
            {
                float price, quan, total;
                price = (float)Convert.ToDouble(PriceTxt.Text);
                quan = (float) Convert.ToDouble(PurQtyTxt.Text);
                total = price * quan;
                TotalAmountTxt.Text = total.ToString();
            }
        }
        private void PurQtyTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(PurQtyTxt, purchaseError);
            MainClass.isEmpty(PurQtyTxt);
            CalculatePrice();
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

        private void DiscountPerTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(DiscountPerTxt, purchaseError);
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

        int purchaceinvoiceid;
        private int savePurchase()
        {
            MainClass.isEmpty(DiscountAmountTxt);
            int vendorID = (int)vendorBox.SelectedValue;
            float discountAmount = (float)Convert.ToDouble(DiscountAmountTxt.Text);
            float DP = (float)Convert.ToDouble(DiscountPerTxt.Text);
            if (discountAmount == 0)
            {
                DP = 0;
            }
            float amount = (float)Convert.ToDecimal(TotalPaymentTxt.Text);
            int purNo = generateNO();
            log.addPurchase(notesText.Text, purNo, vendorID,1,DP, discountAmount,amount,0,0);
            purchaceinvoiceid = log.getPurchaseID();
            return purchaceinvoiceid;
        }

        int count = 0;
        private int savePurchaseDetails()
        {
            string Batch, AutoBatch;
            int purID, proID, no;
            purID = purchaceinvoiceid;
            foreach (DataGridViewRow row in cartGV.Rows)
            {
                proID = 0;
                proID = Convert.ToInt32(row.Cells["idGV"].Value.ToString());
                float quantity = (float)Convert.ToDouble(row.Cells["quanGV"].Value.ToString());
                float total = (float)Convert.ToDouble(row.Cells["totalGV"].Value.ToString());
                float price = (float)Convert.ToDouble(row.Cells["priceGV"].Value.ToString());
                log.addPurchaseDetail(purID,proID,quantity,price,total);
                if(batchText.Text != "")
                {
                    Batch = batchText.Text;
                    log.addInventory(proID, quantity, price, Batch,null);
                }
                else
                {
                    AutoBatch = log.getBatchNO(proID);
                    if (AutoBatch == "")
                    {
                        AutoBatch = "B1";
                    }
                    else
                    {
                        no = Convert.ToInt32(Regex.Match(AutoBatch, @"\d+\.*\d*").Value);
                        no += 1;
                        AutoBatch = "B" + no;
                    }
                    log.addInventory(proID, quantity, price, null , AutoBatch);
                }            
                count++;
            }
            return count;
        }

        private void saveBtn()
        {
            if (cartGV.Rows.Count > 0)
            {
                
                savePurchase();
                savePurchaseDetails();
                
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

        private int generateNO()
        {
            int purchaseNO = log.getPurchaseNO();
            purchaseNO += 1;
            return purchaseNO;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveBtn();
            clearBox();
            receiptGroup.Enabled = false;
            productGroup.Enabled = true;
            ProductNameTxt.Focus();
        }

        private void PriceTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.onlyNumeric(PriceTxt, purchaseError);
            MainClass.isEmpty(PriceTxt);
            CalculatePrice();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ProductNameTxt.Clear();
            clearControl();
            ProductNameTxt.Focus();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            if(cartGV.Rows.Count == 0)
            {
                MessageBox.Show("Please Add Products to Cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductNameTxt.Focus();
            }
            else
            {
                receiptGroup.Enabled = true;
                batchText.Focus();
                productGroup.Enabled = false;
            }
        }
    }
}
