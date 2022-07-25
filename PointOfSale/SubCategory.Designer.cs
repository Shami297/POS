
namespace PointOfSale
{
    partial class SubCategory
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.SubCategoryView = new System.Windows.Forms.DataGridView();
            this.Editbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SubCatError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubCategoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubCatError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.categoryBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Size = new System.Drawing.Size(461, 187);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(461, 385);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SubCategoryView);
            this.panel3.Location = new System.Drawing.Point(0, 259);
            this.panel3.Size = new System.Drawing.Size(461, 126);
            this.panel3.TabIndex = 5;
            // 
            // searchText
            // 
            this.searchText.ForeColor = System.Drawing.Color.Gray;
            this.searchText.Location = new System.Drawing.Point(12, 217);
            this.searchText.Size = new System.Drawing.Size(112, 25);
            this.searchText.TabIndex = 4;
            this.searchText.Enter += new System.EventHandler(this.textBox1_Enter);
            this.searchText.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(211, 141);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 34);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Name :";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(33, 36);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(153, 29);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Category :";
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(34, 102);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(153, 29);
            this.categoryBox.TabIndex = 2;
            this.categoryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoryBox_KeyPress);
            // 
            // SubCategoryView
            // 
            this.SubCategoryView.AllowUserToAddRows = false;
            this.SubCategoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubCategoryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubCategoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SubCategoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubCategoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editbtn,
            this.deletebtn});
            this.SubCategoryView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubCategoryView.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubCategoryView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubCategoryView.Location = new System.Drawing.Point(0, 0);
            this.SubCategoryView.Name = "SubCategoryView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubCategoryView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SubCategoryView.Size = new System.Drawing.Size(461, 126);
            this.SubCategoryView.TabIndex = 5;
            this.SubCategoryView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubCategoryView_CellClick);
            // 
            // Editbtn
            // 
            this.Editbtn.HeaderText = "Edit";
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Text = "EDIT";
            this.Editbtn.UseColumnTextForButtonValue = true;
            // 
            // deletebtn
            // 
            this.deletebtn.HeaderText = "Delete";
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseColumnTextForButtonValue = true;
            // 
            // SubCatError
            // 
            this.SubCatError.ContainerControl = this;
            // 
            // SubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 385);
            this.MinimumSize = new System.Drawing.Size(354, 424);
            this.Name = "SubCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubCategory";
            this.Load += new System.EventHandler(this.SubCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubCategoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubCatError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.DataGridView SubCategoryView;
        private System.Windows.Forms.DataGridViewButtonColumn Editbtn;
        private System.Windows.Forms.DataGridViewButtonColumn deletebtn;
        private System.Windows.Forms.ErrorProvider SubCatError;
    }
}