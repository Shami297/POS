
namespace PointOfSale
{
    partial class Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.NewRecord = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartGV = new System.Windows.Forms.DataGridView();
            this.idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.vendorBox = new System.Windows.Forms.ComboBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.InvoiceNoTxt = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.productGroup = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.TotalAmountTxt = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.PurQtyTxt = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.AvailableQtyTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notesText = new System.Windows.Forms.TextBox();
            this.purchaseError = new System.Windows.Forms.ErrorProvider(this.components);
            this.batchText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.receiptGroup = new System.Windows.Forms.GroupBox();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGV)).BeginInit();
            this.productGroup.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseError)).BeginInit();
            this.receiptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewRecord
            // 
            this.NewRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(15, 9);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(98, 43);
            this.NewRecord.TabIndex = 11;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.cartGV);
            this.panel3.Location = new System.Drawing.Point(17, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 341);
            this.panel3.TabIndex = 149;
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
            // idGV
            // 
            this.idGV.HeaderText = "ID";
            this.idGV.Name = "idGV";
            this.idGV.ReadOnly = true;
            this.idGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Product";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.HeaderText = "UnitPrice";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // quanGV
            // 
            this.quanGV.HeaderText = "Quantity";
            this.quanGV.Name = "quanGV";
            this.quanGV.ReadOnly = true;
            // 
            // totalGV
            // 
            this.totalGV.HeaderText = "Gross Total";
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // editGV
            // 
            this.editGV.HeaderText = "Action";
            this.editGV.Name = "editGV";
            this.editGV.ReadOnly = true;
            this.editGV.Text = "EDIT";
            this.editGV.UseColumnTextForButtonValue = true;
            // 
            // delbtn
            // 
            this.delbtn.HeaderText = "Action";
            this.delbtn.Name = "delbtn";
            this.delbtn.ReadOnly = true;
            this.delbtn.Text = "DELETE";
            this.delbtn.UseColumnTextForButtonValue = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(135, 383);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(99, 29);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "&Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // vendorBox
            // 
            this.vendorBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vendorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vendorBox.FormattingEnabled = true;
            this.vendorBox.Location = new System.Drawing.Point(138, 87);
            this.vendorBox.Name = "vendorBox";
            this.vendorBox.Size = new System.Drawing.Size(136, 21);
            this.vendorBox.TabIndex = 12;
            this.vendorBox.Text = "         ....SELECT....";
            this.vendorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vendorBox_KeyPress);
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInvoiceDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(138, 51);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(136, 24);
            this.dtpInvoiceDate.TabIndex = 141;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(14, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 17);
            this.Label3.TabIndex = 139;
            this.Label3.Text = "Date";
            // 
            // InvoiceNoTxt
            // 
            this.InvoiceNoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvoiceNoTxt.Location = new System.Drawing.Point(333, 7);
            this.InvoiceNoTxt.Name = "InvoiceNoTxt";
            this.InvoiceNoTxt.ReadOnly = true;
            this.InvoiceNoTxt.Size = new System.Drawing.Size(185, 20);
            this.InvoiceNoTxt.TabIndex = 140;
            this.InvoiceNoTxt.Visible = false;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(259, 7);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 17);
            this.Label4.TabIndex = 138;
            this.Label4.Text = "Order No.";
            this.Label4.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 91);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 17);
            this.Label1.TabIndex = 137;
            this.Label1.Text = "Vendor ";
            // 
            // Label13
            // 
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.LightGray;
            this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(12, 10);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(81, 22);
            this.Label13.TabIndex = 136;
            this.Label13.Text = "Purchase \r\n";
            // 
            // productGroup
            // 
            this.productGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productGroup.Controls.Add(this.proceedBtn);
            this.productGroup.Controls.Add(this.ProductNameTxt);
            this.productGroup.Controls.Add(this.clearBtn);
            this.productGroup.Controls.Add(this.TotalAmountTxt);
            this.productGroup.Controls.Add(this.Label5);
            this.productGroup.Controls.Add(this.Label11);
            this.productGroup.Controls.Add(this.AvailableQtyTxt);
            this.productGroup.Controls.Add(this.Cart);
            this.productGroup.Controls.Add(this.Label10);
            this.productGroup.Controls.Add(this.PriceTxt);
            this.productGroup.Controls.Add(this.Label12);
            this.productGroup.Controls.Add(this.Label9);
            this.productGroup.Controls.Add(this.PurQtyTxt);
            this.productGroup.Location = new System.Drawing.Point(17, 163);
            this.productGroup.Name = "productGroup";
            this.productGroup.Size = new System.Drawing.Size(651, 147);
            this.productGroup.TabIndex = 7;
            this.productGroup.TabStop = false;
            this.productGroup.Text = "Product Details";
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(478, 28);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(23, 20);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "&X";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Location = new System.Drawing.Point(246, 383);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(99, 29);
            this.PrintBtn.TabIndex = 4;
            this.PrintBtn.Text = "&Print Receipt";
            this.PrintBtn.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.NewRecord);
            this.Panel1.Location = new System.Drawing.Point(523, 37);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(131, 62);
            this.Panel1.TabIndex = 146;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1144, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(303, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 21);
            this.label21.TabIndex = 7248;
            this.label21.Text = "Rupees";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(303, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 21);
            this.label20.TabIndex = 7247;
            this.label20.Text = "Rupees";
            // 
            // FlatDiscTxt
            // 
            this.FlatDiscTxt.Location = new System.Drawing.Point(113, 162);
            this.FlatDiscTxt.Name = "FlatDiscTxt";
            this.FlatDiscTxt.ReadOnly = true;
            this.FlatDiscTxt.Size = new System.Drawing.Size(81, 20);
            this.FlatDiscTxt.TabIndex = 100;
            this.FlatDiscTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 7245;
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
            this.cmbPaymentType.Location = new System.Drawing.Point(339, 252);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(137, 21);
            this.cmbPaymentType.TabIndex = 100;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(230, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 17);
            this.label18.TabIndex = 7244;
            this.label18.Text = "Payment Type";
            // 
            // DiscountAmountTxt
            // 
            this.DiscountAmountTxt.Location = new System.Drawing.Point(217, 130);
            this.DiscountAmountTxt.Name = "DiscountAmountTxt";
            this.DiscountAmountTxt.ReadOnly = true;
            this.DiscountAmountTxt.Size = new System.Drawing.Size(80, 20);
            this.DiscountAmountTxt.TabIndex = 100;
            this.DiscountAmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(171, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 21);
            this.label17.TabIndex = 7243;
            this.label17.Text = "%";
            // 
            // DiscountPerTxt
            // 
            this.DiscountPerTxt.Location = new System.Drawing.Point(113, 131);
            this.DiscountPerTxt.Name = "DiscountPerTxt";
            this.DiscountPerTxt.Size = new System.Drawing.Size(52, 20);
            this.DiscountPerTxt.TabIndex = 1;
            this.DiscountPerTxt.Text = "5.78";
            this.DiscountPerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DiscountPerTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiscountPerTxt_MouseClick);
            this.DiscountPerTxt.TextChanged += new System.EventHandler(this.DiscountPerTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 7242;
            this.label8.Text = "Discount";
            // 
            // PaymentDueTxt
            // 
            this.PaymentDueTxt.Location = new System.Drawing.Point(114, 255);
            this.PaymentDueTxt.Name = "PaymentDueTxt";
            this.PaymentDueTxt.ReadOnly = true;
            this.PaymentDueTxt.Size = new System.Drawing.Size(81, 20);
            this.PaymentDueTxt.TabIndex = 100;
            this.PaymentDueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalPaymentTxt
            // 
            this.TotalPaymentTxt.Location = new System.Drawing.Point(114, 222);
            this.TotalPaymentTxt.Name = "TotalPaymentTxt";
            this.TotalPaymentTxt.ReadOnly = true;
            this.TotalPaymentTxt.Size = new System.Drawing.Size(81, 20);
            this.TotalPaymentTxt.TabIndex = 6;
            this.TotalPaymentTxt.Text = "0.00";
            this.TotalPaymentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(17, 255);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(83, 17);
            this.Label19.TabIndex = 7241;
            this.Label19.Text = "Payment Due";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(17, 223);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(89, 17);
            this.payment.TabIndex = 7240;
            this.payment.Text = "Total Payment";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Location = new System.Drawing.Point(113, 190);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(81, 20);
            this.TotalTxt.TabIndex = 100;
            this.TotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(16, 190);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(75, 17);
            this.Label16.TabIndex = 7239;
            this.Label16.Text = "Grand Total";
            // 
            // TaxAmtTxt
            // 
            this.TaxAmtTxt.Location = new System.Drawing.Point(217, 95);
            this.TaxAmtTxt.Name = "TaxAmtTxt";
            this.TaxAmtTxt.ReadOnly = true;
            this.TaxAmtTxt.Size = new System.Drawing.Size(80, 20);
            this.TaxAmtTxt.TabIndex = 100;
            this.TaxAmtTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.White;
            this.Label24.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(171, 95);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(23, 21);
            this.Label24.TabIndex = 7238;
            this.Label24.Text = "%";
            // 
            // TaxPerTxt
            // 
            this.TaxPerTxt.Location = new System.Drawing.Point(113, 96);
            this.TaxPerTxt.Name = "TaxPerTxt";
            this.TaxPerTxt.Size = new System.Drawing.Size(52, 20);
            this.TaxPerTxt.TabIndex = 7232;
            this.TaxPerTxt.Text = "17.00";
            this.TaxPerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(17, 99);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(34, 17);
            this.Label15.TabIndex = 7237;
            this.Label15.Text = "GST";
            // 
            // SubTotalTxt
            // 
            this.SubTotalTxt.Location = new System.Drawing.Point(113, 62);
            this.SubTotalTxt.Name = "SubTotalTxt";
            this.SubTotalTxt.ReadOnly = true;
            this.SubTotalTxt.Size = new System.Drawing.Size(184, 20);
            this.SubTotalTxt.TabIndex = 100;
            this.SubTotalTxt.TextChanged += new System.EventHandler(this.SubTotalTxt_TextChanged);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(16, 64);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(61, 17);
            this.Label14.TabIndex = 7236;
            this.Label14.Text = "Sub Total";
            // 
            // TotalAmountTxt
            // 
            this.TotalAmountTxt.Location = new System.Drawing.Point(368, 103);
            this.TotalAmountTxt.Name = "TotalAmountTxt";
            this.TotalAmountTxt.ReadOnly = true;
            this.TotalAmountTxt.Size = new System.Drawing.Size(132, 20);
            this.TotalAmountTxt.TabIndex = 100;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(24, 106);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(57, 17);
            this.Label11.TabIndex = 7260;
            this.Label11.Text = "Buy Qty.";
            // 
            // Cart
            // 
            this.Cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cart.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart.Location = new System.Drawing.Point(520, 27);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(87, 23);
            this.Cart.TabIndex = 2;
            this.Cart.Text = "&Add To Cart";
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(24, 33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 17);
            this.Label5.TabIndex = 7256;
            this.Label5.Text = "Product Name";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(136, 28);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(342, 20);
            this.ProductNameTxt.TabIndex = 0;
            this.ProductNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductNameTxt_KeyDown);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(24, 67);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(61, 17);
            this.Label12.TabIndex = 7259;
            this.Label12.Text = "Unit Price";
            // 
            // PurQtyTxt
            // 
            this.PurQtyTxt.Location = new System.Drawing.Point(136, 99);
            this.PurQtyTxt.Name = "PurQtyTxt";
            this.PurQtyTxt.Size = new System.Drawing.Size(89, 20);
            this.PurQtyTxt.TabIndex = 1;
            this.PurQtyTxt.TextChanged += new System.EventHandler(this.PurQtyTxt_TextChanged);
            this.PurQtyTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurQtyTxt_KeyPress);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(269, 67);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 17);
            this.Label9.TabIndex = 7257;
            this.Label9.Text = "Available Qty";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(136, 64);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(89, 20);
            this.PriceTxt.TabIndex = 100;
            this.PriceTxt.TextChanged += new System.EventHandler(this.PriceTxt_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(269, 106);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 17);
            this.Label10.TabIndex = 7258;
            this.Label10.Text = "Total Amount";
            // 
            // AvailableQtyTxt
            // 
            this.AvailableQtyTxt.Location = new System.Drawing.Point(368, 64);
            this.AvailableQtyTxt.Name = "AvailableQtyTxt";
            this.AvailableQtyTxt.ReadOnly = true;
            this.AvailableQtyTxt.Size = new System.Drawing.Size(89, 20);
            this.AvailableQtyTxt.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7261;
            this.label2.Text = "Notes (optional)";
            // 
            // notesText
            // 
            this.notesText.Location = new System.Drawing.Point(20, 305);
            this.notesText.Multiline = true;
            this.notesText.Name = "notesText";
            this.notesText.Size = new System.Drawing.Size(456, 65);
            this.notesText.TabIndex = 2;
            // 
            // purchaseError
            // 
            this.purchaseError.ContainerControl = this;
            // 
            // batchText
            // 
            this.batchText.Location = new System.Drawing.Point(113, 27);
            this.batchText.Name = "batchText";
            this.batchText.Size = new System.Drawing.Size(184, 20);
            this.batchText.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 7264;
            this.label7.Text = "Product Batch";
            // 
            // receiptGroup
            // 
            this.receiptGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.receiptGroup.Controls.Add(this.label7);
            this.receiptGroup.Controls.Add(this.batchText);
            this.receiptGroup.Controls.Add(this.notesText);
            this.receiptGroup.Controls.Add(this.Label14);
            this.receiptGroup.Controls.Add(this.label2);
            this.receiptGroup.Controls.Add(this.SubTotalTxt);
            this.receiptGroup.Controls.Add(this.Label15);
            this.receiptGroup.Controls.Add(this.TaxPerTxt);
            this.receiptGroup.Controls.Add(this.Label24);
            this.receiptGroup.Controls.Add(this.TaxAmtTxt);
            this.receiptGroup.Controls.Add(this.Label16);
            this.receiptGroup.Controls.Add(this.TotalTxt);
            this.receiptGroup.Controls.Add(this.label8);
            this.receiptGroup.Controls.Add(this.DiscountPerTxt);
            this.receiptGroup.Controls.Add(this.label17);
            this.receiptGroup.Controls.Add(this.DiscountAmountTxt);
            this.receiptGroup.Controls.Add(this.cmbPaymentType);
            this.receiptGroup.Controls.Add(this.SaveBtn);
            this.receiptGroup.Controls.Add(this.label6);
            this.receiptGroup.Controls.Add(this.label18);
            this.receiptGroup.Controls.Add(this.FlatDiscTxt);
            this.receiptGroup.Controls.Add(this.PaymentDueTxt);
            this.receiptGroup.Controls.Add(this.label20);
            this.receiptGroup.Controls.Add(this.TotalPaymentTxt);
            this.receiptGroup.Controls.Add(this.label21);
            this.receiptGroup.Controls.Add(this.Label19);
            this.receiptGroup.Controls.Add(this.payment);
            this.receiptGroup.Controls.Add(this.PrintBtn);
            this.receiptGroup.Enabled = false;
            this.receiptGroup.Location = new System.Drawing.Point(686, 253);
            this.receiptGroup.Name = "receiptGroup";
            this.receiptGroup.Size = new System.Drawing.Size(489, 417);
            this.receiptGroup.TabIndex = 8;
            this.receiptGroup.TabStop = false;
            this.receiptGroup.Text = "Receipt Details";
            // 
            // proceedBtn
            // 
            this.proceedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedBtn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.Location = new System.Drawing.Point(573, 116);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(73, 23);
            this.proceedBtn.TabIndex = 7261;
            this.proceedBtn.Text = "&PROCEED";
            this.proceedBtn.UseVisualStyleBackColor = true;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 676);
            this.ControlBox = false;
            this.Controls.Add(this.receiptGroup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.vendorBox);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.InvoiceNoTxt);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.productGroup);
            this.Controls.Add(this.Panel1);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Purchase_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartGV)).EndInit();
            this.productGroup.ResumeLayout(false);
            this.productGroup.PerformLayout();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseError)).EndInit();
            this.receiptGroup.ResumeLayout(false);
            this.receiptGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button NewRecord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cartGV;
        internal System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox vendorBox;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox InvoiceNoTxt;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox productGroup;
        internal System.Windows.Forms.Button PrintBtn;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn editGV;
        private System.Windows.Forms.DataGridViewButtonColumn delbtn;
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
        internal System.Windows.Forms.TextBox TotalAmountTxt;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button Cart;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox ProductNameTxt;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox PurQtyTxt;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox PriceTxt;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox AvailableQtyTxt;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox notesText;
        private System.Windows.Forms.ErrorProvider purchaseError;
        private System.Windows.Forms.Button clearBtn;
        internal System.Windows.Forms.TextBox batchText;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox receiptGroup;
        internal System.Windows.Forms.Button proceedBtn;
    }
}