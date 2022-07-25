
namespace PointOfSale
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productView = new System.Windows.Forms.DataGridView();
            this.Editbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.TargetText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimumText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.locationText = new System.Windows.Forms.TextBox();
            this.descrpText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saleText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.costText = new System.Windows.Forms.TextBox();
            this.ManfBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subCategoryBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.productError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.barcodeText);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TargetText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MinimumText);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.locationText);
            this.panel1.Controls.Add(this.descrpText);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.saleText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.costText);
            this.panel1.Controls.Add(this.ManfBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.subCategoryBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.categoryBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productView);
            // 
            // searchText
            // 
            this.searchText.TabIndex = 14;
            this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchText.Enter += new System.EventHandler(this.textBox1_Enter);
            this.searchText.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // productView
            // 
            this.productView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editbtn,
            this.DeleteBtn});
            this.productView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productView.Location = new System.Drawing.Point(0, 0);
            this.productView.Name = "productView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.productView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView.Size = new System.Drawing.Size(1096, 318);
            this.productView.TabIndex = 0;
            this.productView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productView_CellClick);
            // 
            // Editbtn
            // 
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.HeaderText = "EDIT";
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Text = "EDIT";
            this.Editbtn.UseColumnTextForButtonValue = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.HeaderText = "DELETE";
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseColumnTextForButtonValue = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(930, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 21);
            this.label11.TabIndex = 69;
            this.label11.Text = "Target Qty :";
            // 
            // TargetText
            // 
            this.TargetText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TargetText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetText.Location = new System.Drawing.Point(928, 128);
            this.TargetText.Name = "TargetText";
            this.TargetText.Size = new System.Drawing.Size(153, 29);
            this.TargetText.TabIndex = 11;
            this.TargetText.TextChanged += new System.EventHandler(this.TargetText_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 67;
            this.label1.Text = "Minimum Qty :";
            // 
            // MinimumText
            // 
            this.MinimumText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinimumText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumText.Location = new System.Drawing.Point(733, 128);
            this.MinimumText.Name = "MinimumText";
            this.MinimumText.Size = new System.Drawing.Size(153, 29);
            this.MinimumText.TabIndex = 10;
            this.MinimumText.TextChanged += new System.EventHandler(this.MinimumText_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(545, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "Location :";
            // 
            // locationText
            // 
            this.locationText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationText.Location = new System.Drawing.Point(543, 128);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(153, 29);
            this.locationText.TabIndex = 9;
            this.locationText.TextChanged += new System.EventHandler(this.locationText_TextChanged);
            // 
            // descrpText
            // 
            this.descrpText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descrpText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrpText.Location = new System.Drawing.Point(373, 37);
            this.descrpText.Name = "descrpText";
            this.descrpText.Size = new System.Drawing.Size(153, 29);
            this.descrpText.TabIndex = 2;
            this.descrpText.TextChanged += new System.EventHandler(this.descrpText_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(379, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 21);
            this.label9.TabIndex = 62;
            this.label9.Text = "Description :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Sale Price :";
            // 
            // saleText
            // 
            this.saleText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleText.Location = new System.Drawing.Point(362, 128);
            this.saleText.Name = "saleText";
            this.saleText.Size = new System.Drawing.Size(153, 29);
            this.saleText.TabIndex = 8;
            this.saleText.TextChanged += new System.EventHandler(this.saleText_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "List Price :";
            // 
            // listText
            // 
            this.listText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listText.Location = new System.Drawing.Point(182, 128);
            this.listText.Name = "listText";
            this.listText.Size = new System.Drawing.Size(153, 29);
            this.listText.TabIndex = 7;
            this.listText.TextChanged += new System.EventHandler(this.listText_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Cost :";
            // 
            // costText
            // 
            this.costText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costText.Location = new System.Drawing.Point(6, 128);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(154, 29);
            this.costText.TabIndex = 6;
            this.costText.TextChanged += new System.EventHandler(this.costText_TextChanged);
            // 
            // ManfBox
            // 
            this.ManfBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManfBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManfBox.FormattingEnabled = true;
            this.ManfBox.Location = new System.Drawing.Point(911, 36);
            this.ManfBox.Name = "ManfBox";
            this.ManfBox.Size = new System.Drawing.Size(153, 29);
            this.ManfBox.TabIndex = 5;
            this.ManfBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManfBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(917, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "Manufacture :";
            // 
            // subCategoryBox
            // 
            this.subCategoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subCategoryBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCategoryBox.FormattingEnabled = true;
            this.subCategoryBox.Location = new System.Drawing.Point(721, 36);
            this.subCategoryBox.Name = "subCategoryBox";
            this.subCategoryBox.Size = new System.Drawing.Size(153, 29);
            this.subCategoryBox.TabIndex = 4;
            this.subCategoryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subCategoryBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(726, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sub Category :";
            // 
            // categoryBox
            // 
            this.categoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(538, 36);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(153, 29);
            this.categoryBox.TabIndex = 3;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            this.categoryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoryBox_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Category :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Name :";
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(6, 36);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(153, 29);
            this.nameText.TabIndex = 0;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(892, 196);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(174, 39);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // productError
            // 
            this.productError.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 21);
            this.label12.TabIndex = 71;
            this.label12.Text = "Barcode :";
            // 
            // barcodeText
            // 
            this.barcodeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barcodeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeText.Location = new System.Drawing.Point(182, 36);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(153, 29);
            this.barcodeText.TabIndex = 1;
            this.barcodeText.TextChanged += new System.EventHandler(this.barcodeText_TextChanged);
            this.barcodeText.DoubleClick += new System.EventHandler(this.barcodeText_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(335, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 638);
            this.MinimumSize = new System.Drawing.Size(1112, 677);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TargetText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MinimumText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox descrpText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox saleText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox listText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox costText;
        private System.Windows.Forms.ComboBox ManfBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox subCategoryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewButtonColumn Editbtn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
        private System.Windows.Forms.ErrorProvider productError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Button button1;
    }
}