namespace RentalApp.UI.Sections
{
    partial class BillingView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.billingGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.overviewgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(118, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Pending Rentals";
            this.headerLabel.DoubleClick += new System.EventHandler(this.billingGrid_DoubleClick);
            // 
            // billingGrid
            // 
            this.billingGrid.AllowUserToAddRows = false;
            this.billingGrid.AllowUserToDeleteRows = false;
            this.billingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billingGrid.BackgroundColor = System.Drawing.Color.White;
            this.billingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGrid.Location = new System.Drawing.Point(15, 43);
            this.billingGrid.Name = "billingGrid";
            this.billingGrid.ReadOnly = true;
            this.billingGrid.RowHeadersVisible = false;
            this.billingGrid.Size = new System.Drawing.Size(627, 182);
            this.billingGrid.TabIndex = 1;
            this.billingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingGrid_CellContentClick);
            this.billingGrid.DoubleClick += new System.EventHandler(this.billingGrid_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(11, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Billings Overview";
            // 
            // overviewgrid
            // 
            this.overviewgrid.AllowUserToAddRows = false;
            this.overviewgrid.AllowUserToDeleteRows = false;
            this.overviewgrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.overviewgrid.BackgroundColor = System.Drawing.Color.White;
            this.overviewgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overviewgrid.Location = new System.Drawing.Point(15, 274);
            this.overviewgrid.Name = "overviewgrid";
            this.overviewgrid.ReadOnly = true;
            this.overviewgrid.RowHeadersVisible = false;
            this.overviewgrid.Size = new System.Drawing.Size(627, 182);
            this.overviewgrid.TabIndex = 3;
            this.overviewgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.overviewgrid_CellContentClick);
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.overviewgrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billingGrid);
            this.Controls.Add(this.headerLabel);
            this.Name = "BillingView";
            this.Size = new System.Drawing.Size(660, 476);
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView billingGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView overviewgrid;
    }
}



