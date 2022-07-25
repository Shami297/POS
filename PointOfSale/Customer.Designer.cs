
namespace PointOfSale
{
    partial class Customer
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.emailText = new System.Windows.Forms.TextBox();
            this.accountText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nmbrText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.customerView = new System.Windows.Forms.DataGridView();
            this.Editbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.accountText);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nmbrText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerView);
            // 
            // searchText
            // 
            this.searchText.TabIndex = 6;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            this.searchText.Enter += new System.EventHandler(this.searchText_Enter);
            this.searchText.Leave += new System.EventHandler(this.searchText_Leave);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(884, 176);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(174, 39);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // emailText
            // 
            this.emailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(820, 82);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(238, 29);
            this.emailText.TabIndex = 4;
            this.emailText.Leave += new System.EventHandler(this.emailText_Leave);
            // 
            // accountText
            // 
            this.accountText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountText.Location = new System.Drawing.Point(618, 82);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(154, 29);
            this.accountText.TabIndex = 3;
            this.accountText.TextChanged += new System.EventHandler(this.accountText_TextChanged);
            // 
            // addressText
            // 
            this.addressText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(221, 82);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(153, 29);
            this.addressText.TabIndex = 1;
            this.addressText.TextChanged += new System.EventHandler(this.addressText_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(227, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 82;
            this.label9.Text = "Address :";
            // 
            // nmbrText
            // 
            this.nmbrText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmbrText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbrText.Location = new System.Drawing.Point(417, 82);
            this.nmbrText.Name = "nmbrText";
            this.nmbrText.Size = new System.Drawing.Size(154, 29);
            this.nmbrText.TabIndex = 2;
            this.nmbrText.Leave += new System.EventHandler(this.nmbrText_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(826, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 80;
            this.label4.Text = "Account No :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Contact No :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 84;
            this.label2.Text = "Name :";
            // 
            // nameText
            // 
            this.nameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(19, 82);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(153, 29);
            this.nameText.TabIndex = 0;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // customerView
            // 
            this.customerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editbtn,
            this.DeleteBtn});
            this.customerView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerView.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerView.Location = new System.Drawing.Point(0, 0);
            this.customerView.Name = "customerView";
            this.customerView.Size = new System.Drawing.Size(1096, 318);
            this.customerView.TabIndex = 7;
            this.customerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerView_CellClick);
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
            // customerError
            // 
            this.customerError.ContainerControl = this;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 638);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nmbrText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.DataGridView customerView;
        private System.Windows.Forms.DataGridViewButtonColumn Editbtn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
        private System.Windows.Forms.ErrorProvider customerError;
    }
}