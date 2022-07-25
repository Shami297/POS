
namespace PointOfSale
{
    partial class Sample3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.structureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 256);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.searchText);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 638);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1096, 318);
            this.panel3.TabIndex = 21;
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(12, 289);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(208, 25);
            this.searchText.TabIndex = 20;
            this.searchText.Text = "Search...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.structureToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            this.logoutToolStripMenuItem.MouseLeave += new System.EventHandler(this.logoutToolStripMenuItem_MouseLeave);
            this.logoutToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logoutToolStripMenuItem_MouseMove);
            // 
            // structureToolStripMenuItem
            // 
            this.structureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.subCategoryToolStripMenuItem,
            this.manufacturerToolStripMenuItem});
            this.structureToolStripMenuItem.Name = "structureToolStripMenuItem";
            this.structureToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.structureToolStripMenuItem.Text = "Structure";
            this.structureToolStripMenuItem.MouseLeave += new System.EventHandler(this.structureToolStripMenuItem_MouseLeave);
            this.structureToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.structureToolStripMenuItem_MouseMove);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            this.productToolStripMenuItem.MouseLeave += new System.EventHandler(this.productToolStripMenuItem_MouseLeave);
            this.productToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.productToolStripMenuItem_MouseMove);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.vendorToolStripMenuItem.Text = "Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            this.vendorToolStripMenuItem.MouseLeave += new System.EventHandler(this.vendorToolStripMenuItem_MouseLeave);
            this.vendorToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vendorToolStripMenuItem_MouseMove);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            this.customerToolStripMenuItem.MouseLeave += new System.EventHandler(this.customerToolStripMenuItem_MouseLeave);
            this.customerToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customerToolStripMenuItem_MouseMove);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            this.categoryToolStripMenuItem.MouseLeave += new System.EventHandler(this.categoryToolStripMenuItem_MouseLeave);
            this.categoryToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.categoryToolStripMenuItem_MouseMove);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.subCategoryToolStripMenuItem.Text = "Sub-Category";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            this.subCategoryToolStripMenuItem.MouseLeave += new System.EventHandler(this.subCategoryToolStripMenuItem_MouseLeave);
            this.subCategoryToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.subCategoryToolStripMenuItem_MouseMove);
            // 
            // manufacturerToolStripMenuItem
            // 
            this.manufacturerToolStripMenuItem.Name = "manufacturerToolStripMenuItem";
            this.manufacturerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.manufacturerToolStripMenuItem.Text = "Manufacturer";
            this.manufacturerToolStripMenuItem.Click += new System.EventHandler(this.manufacturerToolStripMenuItem_Click);
            this.manufacturerToolStripMenuItem.MouseLeave += new System.EventHandler(this.manufacturerToolStripMenuItem_MouseLeave);
            this.manufacturerToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.manufacturerToolStripMenuItem_MouseMove);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoicesToolStripMenuItem.Text = "Invoice";
            this.invoicesToolStripMenuItem.MouseLeave += new System.EventHandler(this.invoicesToolStripMenuItem_MouseLeave);
            this.invoicesToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.invoicesToolStripMenuItem_MouseMove);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            this.addToolStripMenuItem.MouseLeave += new System.EventHandler(this.addToolStripMenuItem_MouseLeave);
            this.addToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addToolStripMenuItem_MouseMove);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.MouseLeave += new System.EventHandler(this.viewToolStripMenuItem_MouseLeave);
            this.viewToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewToolStripMenuItem_MouseMove);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.viewToolStripMenuItem1});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.MouseLeave += new System.EventHandler(this.purchaseToolStripMenuItem_MouseLeave);
            this.purchaseToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.purchaseToolStripMenuItem_MouseMove);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            this.addToolStripMenuItem1.MouseLeave += new System.EventHandler(this.addToolStripMenuItem1_MouseLeave);
            this.addToolStripMenuItem1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.addToolStripMenuItem1_MouseMove);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            this.viewToolStripMenuItem1.MouseLeave += new System.EventHandler(this.viewToolStripMenuItem1_MouseLeave);
            this.viewToolStripMenuItem1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewToolStripMenuItem1_MouseMove);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyReportToolStripMenuItem,
            this.annualReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.MouseLeave += new System.EventHandler(this.reportsToolStripMenuItem_MouseLeave);
            this.reportsToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reportsToolStripMenuItem_MouseMove);
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            this.monthlyReportToolStripMenuItem.MouseLeave += new System.EventHandler(this.monthlyReportToolStripMenuItem_MouseLeave);
            this.monthlyReportToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthlyReportToolStripMenuItem_MouseMove);
            // 
            // annualReportToolStripMenuItem
            // 
            this.annualReportToolStripMenuItem.Name = "annualReportToolStripMenuItem";
            this.annualReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.annualReportToolStripMenuItem.Text = "Annual Report";
            this.annualReportToolStripMenuItem.MouseLeave += new System.EventHandler(this.annualReportToolStripMenuItem_MouseLeave);
            this.annualReportToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.annualReportToolStripMenuItem_MouseMove);
            // 
            // Sample3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 638);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sample3";
            this.Text = "Sample3";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem structureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualReportToolStripMenuItem;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem;
    }
}