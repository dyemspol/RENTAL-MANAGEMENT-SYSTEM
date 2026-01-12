namespace RentalApp.UI.Sections
{
    partial class ReturnsView
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
            this.returnsGrid = new System.Windows.Forms.DataGridView();
            this.startReturnButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.returnsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(126, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Vehicle Returns   ";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // returnsGrid
            // 
            this.returnsGrid.AllowUserToAddRows = false;
            this.returnsGrid.AllowUserToDeleteRows = false;
            this.returnsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnsGrid.BackgroundColor = System.Drawing.Color.White;
            this.returnsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnsGrid.Location = new System.Drawing.Point(15, 69);
            this.returnsGrid.Name = "returnsGrid";
            this.returnsGrid.ReadOnly = true;
            this.returnsGrid.RowHeadersVisible = false;
            this.returnsGrid.Size = new System.Drawing.Size(627, 243);
            this.returnsGrid.TabIndex = 3;
            this.returnsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.returnsGrid_CellContentClick);
            this.returnsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.returnsGrid_CellContentDoubleClick);
            // 
            // startReturnButton
            // 
            this.startReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.startReturnButton.FlatAppearance.BorderSize = 0;
            this.startReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startReturnButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startReturnButton.ForeColor = System.Drawing.Color.White;
            this.startReturnButton.Location = new System.Drawing.Point(548, 42);
            this.startReturnButton.Name = "startReturnButton";
            this.startReturnButton.Size = new System.Drawing.Size(94, 21);
            this.startReturnButton.TabIndex = 4;
            this.startReturnButton.Text = "Start Return";
            this.startReturnButton.UseVisualStyleBackColor = false;
            this.startReturnButton.Click += new System.EventHandler(this.startReturnButton_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.summaryLabel.ForeColor = System.Drawing.Color.DimGray;
            this.summaryLabel.Location = new System.Drawing.Point(15, 42);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(279, 15);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "Inspect condition, record odometer and finalize bill.";
            this.summaryLabel.Click += new System.EventHandler(this.summaryLabel_Click);
            // 
            // ReturnsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.startReturnButton);
            this.Controls.Add(this.returnsGrid);
            this.Controls.Add(this.headerLabel);
            this.Name = "ReturnsView";
            this.Size = new System.Drawing.Size(660, 329);
            ((System.ComponentModel.ISupportInitialize)(this.returnsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView returnsGrid;
        private System.Windows.Forms.Button startReturnButton;
        private System.Windows.Forms.Label summaryLabel;
    }
}



