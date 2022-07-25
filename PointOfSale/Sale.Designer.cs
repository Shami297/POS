
namespace PointOfSale
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.TotalAmountTxt = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.saleNameTxt = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.SaleQtyTxt = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.AvailableQtyTxt = new System.Windows.Forms.TextBox();
            this.saleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.delbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartGV = new System.Windows.Forms.DataGridView();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewRecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.InvoiceNoTxt = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.productGroup = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.receiptGroup = new System.Windows.Forms.GroupBox();
            this.notesText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.FlatDiscTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DiscountAmountTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DiscountPerTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PaymentDueTxt = new System.Windows.Forms.TextBox();
            this.TotalPaymentTxt = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.TaxAmtTxt = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.TaxPerTxt = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.SubTotalTxt = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.saleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.productGroup.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.receiptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalAmountTxt
            // 
            this.TotalAmountTxt.Location = new System.Drawing.Point(384, 262);
            this.TotalAmountTxt.Name = "TotalAmountTxt";
            this.TotalAmountTxt.ReadOnly = true;
            this.TotalAmountTxt.Size = new System.Drawing.Size(132, 20);
            this.TotalAmountTxt.TabIndex = 7279;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(40, 265);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(57, 17);
            this.Label11.TabIndex = 7308;
            this.Label11.Text = "Sale Qty.";
            // 
            // Cart
            // 
            this.Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cart.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart.Location = new System.Drawing.Point(536, 186);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(87, 23);
            this.Cart.TabIndex = 7265;
            this.Cart.Text = "&Add To Cart";
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(40, 192);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 17);
            this.Label5.TabIndex = 7304;
            this.Label5.Text = "Product Name";
            // 
            // saleNameTxt
            // 
            this.saleNameTxt.Location = new System.Drawing.Point(152, 187);
            this.saleNameTxt.Name = "saleNameTxt";
            this.saleNameTxt.Size = new System.Drawing.Size(321, 20);
            this.saleNameTxt.TabIndex = 7263;
            this.saleNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.saleNameTxt_KeyDown);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(40, 226);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(61, 17);
            this.Label12.TabIndex = 7307;
            this.Label12.Text = "Unit Price";
            // 
            // SaleQtyTxt
            // 
            this.SaleQtyTxt.Location = new System.Drawing.Point(152, 258);
            this.SaleQtyTxt.Name = "SaleQtyTxt";
            this.SaleQtyTxt.Size = new System.Drawing.Size(89, 20);
            this.SaleQtyTxt.TabIndex = 7264;
            this.SaleQtyTxt.TextChanged += new System.EventHandler(this.PurQtyTxt_TextChanged);
            this.SaleQtyTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurQtyTxt_KeyPress);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(285, 226);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 17);
            this.Label9.TabIndex = 7305;
            this.Label9.Text = "Available Qty";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(152, 223);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(89, 20);
            this.PriceTxt.TabIndex = 7278;
            this.PriceTxt.TextChanged += new System.EventHandler(this.PriceTxt_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(285, 265);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 17);
            this.Label10.TabIndex = 7306;
            this.Label10.Text = "Total Amount";
            // 
            // AvailableQtyTxt
            // 
            this.AvailableQtyTxt.Location = new System.Drawing.Point(384, 223);
            this.AvailableQtyTxt.Name = "AvailableQtyTxt";
            this.AvailableQtyTxt.ReadOnly = true;
            this.AvailableQtyTxt.Size = new System.Drawing.Size(89, 20);
            this.AvailableQtyTxt.TabIndex = 7277;
            // 
            // saleError
            // 
            this.saleError.ContainerControl = this;
            // 
            // delbtn
            // 
            this.delbtn.HeaderText = "Action";
            this.delbtn.Name = "delbtn";
            this.delbtn.ReadOnly = true;
            this.delbtn.Text = "DELETE";
            this.delbtn.UseColumnTextForButtonValue = true;
            // 
            // editGV
            // 
            this.editGV.HeaderText = "Action";
            this.editGV.Name = "editGV";
            this.editGV.ReadOnly = true;
            this.editGV.Text = "EDIT";
            this.editGV.UseColumnTextForButtonValue = true;
            // 
            // totalGV
            // 
            this.totalGV.HeaderText = "Gross Total";
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // quanGV
            // 
            this.quanGV.HeaderText = "Quantity";
            this.quanGV.Name = "quanGV";
            this.quanGV.ReadOnly = true;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Product";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // idGV
            // 
            this.idGV.HeaderText = "ID";
            this.idGV.Name = "idGV";
            this.idGV.ReadOnly = true;
            this.idGV.Visible = false;
            // 
            // cartGV
            // 
            this.cartGV.AllowUserToAddRows = false;
            this.cartGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.cartGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.cartGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGV,
            this.nameGV,
            this.priceGV,
            this.quanGV,
            this.totalGV,
            this.editGV,
            this.delbtn});
            this.cartGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.cartGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartGV.Location = new System.Drawing.Point(0, 0);
            this.cartGV.Name = "cartGV";
            this.cartGV.ReadOnly = true;
            this.cartGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.cartGV.Size = new System.Drawing.Size(651, 341);
            this.cartGV.TabIndex = 10;
            this.cartGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGV_CellClick);
            // 
            // priceGV
            // 
            this.priceGV.HeaderText = "UnitPrice";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(15, 9);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(98, 43);
            this.NewRecord.TabIndex = 11;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1142, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7290;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.cartGV);
            this.panel3.Location = new System.Drawing.Point(15, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 341);
            this.panel3.TabIndex = 7289;
            // 
            // customerBox
            // 
            this.customerBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(136, 93);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(136, 21);
            this.customerBox.TabIndex = 7271;
            this.customerBox.Text = "         ....SELECT....";
            this.customerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerBox_KeyPress);
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInvoiceDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(136, 57);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(136, 24);
            this.dtpInvoiceDate.TabIndex = 7287;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 58);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 17);
            this.Label3.TabIndex = 7285;
            this.Label3.Text = "Date";
            // 
            // InvoiceNoTxt
            // 
            this.InvoiceNoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvoiceNoTxt.Location = new System.Drawing.Point(331, 13);
            this.InvoiceNoTxt.Name = "InvoiceNoTxt";
            this.InvoiceNoTxt.ReadOnly = true;
            this.InvoiceNoTxt.Size = new System.Drawing.Size(185, 20);
            this.InvoiceNoTxt.TabIndex = 7286;
            this.InvoiceNoTxt.Visible = false;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(257, 13);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 17);
            this.Label4.TabIndex = 7284;
            this.Label4.Text = "Order No.";
            this.Label4.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(11, 97);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 17);
            this.Label1.TabIndex = 7283;
            this.Label1.Text = "Customer";
            // 
            // Label13
            // 
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.LightGray;
            this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(10, 16);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(41, 22);
            this.Label13.TabIndex = 7282;
            this.Label13.Text = "Sale";
            // 
            // productGroup
            // 
            this.productGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productGroup.Controls.Add(this.clearBtn);
            this.productGroup.Location = new System.Drawing.Point(15, 171);
            this.productGroup.Name = "productGroup";
            this.productGroup.Size = new System.Drawing.Size(651, 147);
            this.productGroup.TabIndex = 7270;
            this.productGroup.TabStop = false;
            this.productGroup.Text = "Product Details";
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(457, 16);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(23, 20);
            this.clearBtn.TabIndex = 7311;
            this.clearBtn.Text = "X";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.NewRecord);
            this.Panel1.Location = new System.Drawing.Point(521, 43);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(131, 62);
            this.Panel1.TabIndex = 7288;
            // 
            // receiptGroup
            // 
            this.receiptGroup.Controls.Add(this.notesText);
            this.receiptGroup.Controls.Add(this.label2);
            this.receiptGroup.Controls.Add(this.label21);
            this.receiptGroup.Controls.Add(this.label20);
            this.receiptGroup.Controls.Add(this.FlatDiscTxt);
            this.receiptGroup.Controls.Add(this.label6);
            this.receiptGroup.Controls.Add(this.cmbPaymentType);
            this.receiptGroup.Controls.Add(this.label18);
            this.receiptGroup.Controls.Add(this.DiscountAmountTxt);
            this.receiptGroup.Controls.Add(this.label17);
            this.receiptGroup.Controls.Add(this.DiscountPerTxt);
            this.receiptGroup.Controls.Add(this.label8);
            this.receiptGroup.Controls.Add(this.PaymentDueTxt);
            this.receiptGroup.Controls.Add(this.TotalPaymentTxt);
            this.receiptGroup.Controls.Add(this.Label19);
            this.receiptGroup.Controls.Add(this.payment);
            this.receiptGroup.Controls.Add(this.TotalTxt);
            this.receiptGroup.Controls.Add(this.Label16);
            this.receiptGroup.Controls.Add(this.TaxAmtTxt);
            this.receiptGroup.Controls.Add(this.Label24);
            this.receiptGroup.Controls.Add(this.TaxPerTxt);
            this.receiptGroup.Controls.Add(this.Label15);
            this.receiptGroup.Controls.Add(this.SubTotalTxt);
            this.receiptGroup.Controls.Add(this.Label14);
            this.receiptGroup.Controls.Add(this.SaveBtn);
            this.receiptGroup.Controls.Add(this.PrintBtn);
            this.receiptGroup.Location = new System.Drawing.Point(699, 258);
            this.receiptGroup.Name = "receiptGroup";
            this.receiptGroup.Size = new System.Drawing.Size(476, 418);
            this.receiptGroup.TabIndex = 7311;
            this.receiptGroup.TabStop = false;
            this.receiptGroup.Text = "Receipt Details";
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(12, 274);
            this.notesText.Multiline = true;
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(456, 65);
            this.notesText.TabIndex = 7336;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7335;
            this.label2.Text = "Notes (optional)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(296, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 21);
            this.label21.TabIndex = 7334;
            this.label21.Text = "Rupees";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(296, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 21);
            this.label20.TabIndex = 7333;
            this.label20.Text = "Rupees";
            // 
            // FlatDiscTxt
            // 
            this.FlatDiscTxt.Location = new System.Drawing.Point(106, 130);
            this.FlatDiscTxt.Name = "FlatDiscTxt";
            this.FlatDiscTxt.ReadOnly = true;
            this.FlatDiscTxt.Size = new System.Drawing.Size(81, 20);
            this.FlatDiscTxt.TabIndex = 7320;
            this.FlatDiscTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 7332;
            this.label6.Text = "Flat Discount";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbPaymentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "COD",
            "Debit Card",
            "Credit Card",
            "By Cheque",
            "By DD",
            "Online"});
            this.cmbPaymentType.Location = new System.Drawing.Point(331, 221);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(137, 21);
            this.cmbPaymentType.TabIndex = 7319;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(222, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 17);
            this.label18.TabIndex = 7331;
            this.label18.Text = "Payment Type";
            // 
            // DiscountAmountTxt
            // 
            this.DiscountAmountTxt.Location = new System.Drawing.Point(210, 98);
            this.DiscountAmountTxt.Name = "DiscountAmountTxt";
            this.DiscountAmountTxt.ReadOnly = true;
            this.DiscountAmountTxt.Size = new System.Drawing.Size(80, 20);
            this.DiscountAmountTxt.TabIndex = 7317;
            this.DiscountAmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(164, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 21);
            this.label17.TabIndex = 7330;
            this.label17.Text = "%";
            // 
            // DiscountPerTxt
            // 
            this.DiscountPerTxt.Location = new System.Drawing.Point(106, 99);
            this.DiscountPerTxt.Name = "DiscountPerTxt";
            this.DiscountPerTxt.Size = new System.Drawing.Size(52, 20);
            this.DiscountPerTxt.TabIndex = 7311;
            this.DiscountPerTxt.Text = "5.78";
            this.DiscountPerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 7329;
            this.label8.Text = "Discount";
            // 
            // PaymentDueTxt
            // 
            this.PaymentDueTxt.Location = new System.Drawing.Point(106, 224);
            this.PaymentDueTxt.Name = "PaymentDueTxt";
            this.PaymentDueTxt.ReadOnly = true;
            this.PaymentDueTxt.Size = new System.Drawing.Size(81, 20);
            this.PaymentDueTxt.TabIndex = 7321;
            this.PaymentDueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalPaymentTxt
            // 
            this.TotalPaymentTxt.Location = new System.Drawing.Point(106, 191);
            this.TotalPaymentTxt.Name = "TotalPaymentTxt";
            this.TotalPaymentTxt.ReadOnly = true;
            this.TotalPaymentTxt.Size = new System.Drawing.Size(81, 20);
            this.TotalPaymentTxt.TabIndex = 7312;
            this.TotalPaymentTxt.Text = "0.00";
            this.TotalPaymentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(9, 224);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(83, 17);
            this.Label19.TabIndex = 7328;
            this.Label19.Text = "Payment Due";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(9, 192);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(89, 17);
            this.payment.TabIndex = 7327;
            this.payment.Text = "Total Payment";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(106, 158);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(81, 20);
            this.TotalTxt.TabIndex = 7315;
            this.TotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(9, 158);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(75, 17);
            this.Label16.TabIndex = 7326;
            this.Label16.Text = "Grand Total";
            // 
            // TaxAmtTxt
            // 
            this.TaxAmtTxt.Location = new System.Drawing.Point(210, 63);
            this.TaxAmtTxt.Name = "TaxAmtTxt";
            this.TaxAmtTxt.ReadOnly = true;
            this.TaxAmtTxt.Size = new System.Drawing.Size(80, 20);
            this.TaxAmtTxt.TabIndex = 7316;
            this.TaxAmtTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.White;
            this.Label24.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(164, 63);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(23, 21);
            this.Label24.TabIndex = 7325;
            this.Label24.Text = "%";
            // 
            // TaxPerTxt
            // 
            this.TaxPerTxt.Location = new System.Drawing.Point(106, 64);
            this.TaxPerTxt.Name = "TaxPerTxt";
            this.TaxPerTxt.Size = new System.Drawing.Size(52, 20);
            this.TaxPerTxt.TabIndex = 7322;
            this.TaxPerTxt.Text = "17.00";
            this.TaxPerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(10, 67);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(34, 17);
            this.Label15.TabIndex = 7324;
            this.Label15.Text = "GST";
            // 
            // SubTotalTxt
            // 
            this.SubTotalTxt.Location = new System.Drawing.Point(106, 30);
            this.SubTotalTxt.Name = "SubTotalTxt";
            this.SubTotalTxt.ReadOnly = true;
            this.SubTotalTxt.Size = new System.Drawing.Size(184, 20);
            this.SubTotalTxt.TabIndex = 7318;
            this.SubTotalTxt.TextChanged += new System.EventHandler(this.SubTotalTxt_TextChanged_1);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(9, 32);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(61, 17);
            this.Label14.TabIndex = 7323;
            this.Label14.Text = "Sub Total";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(127, 364);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(99, 29);
            this.SaveBtn.TabIndex = 7313;
            this.SaveBtn.Text = "&Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Location = new System.Drawing.Point(238, 364);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(99, 29);
            this.PrintBtn.TabIndex = 7314;
            this.PrintBtn.Text = "&Print Receipt";
            this.PrintBtn.UseVisualStyleBackColor = true;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 676);
            this.ControlBox = false;
            this.Controls.Add(this.receiptGroup);
            this.Controls.Add(this.TotalAmountTxt);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.saleNameTxt);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.SaleQtyTxt);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.AvailableQtyTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.InvoiceNoTxt);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.productGroup);
            this.Controls.Add(this.Panel1);
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.productGroup.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.receiptGroup.ResumeLayout(false);
            this.receiptGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox TotalAmountTxt;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button Cart;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox saleNameTxt;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox SaleQtyTxt;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox PriceTxt;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox AvailableQtyTxt;
        private System.Windows.Forms.ErrorProvider saleError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cartGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn editGV;
        private System.Windows.Forms.DataGridViewButtonColumn delbtn;
        private System.Windows.Forms.ComboBox customerBox;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox InvoiceNoTxt;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox productGroup;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button NewRecord;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox receiptGroup;
        internal System.Windows.Forms.TextBox notesText;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox FlatDiscTxt;
        internal System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbPaymentType;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox DiscountAmountTxt;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox DiscountPerTxt;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox PaymentDueTxt;
        internal System.Windows.Forms.TextBox TotalPaymentTxt;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label payment;
        internal System.Windows.Forms.TextBox TotalTxt;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox TaxAmtTxt;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox TaxPerTxt;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox SubTotalTxt;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button SaveBtn;
        internal System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Timer Timer;
    }
}