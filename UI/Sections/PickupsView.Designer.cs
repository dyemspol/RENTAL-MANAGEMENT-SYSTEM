namespace RentalApp.UI.Sections
{
    partial class PickupsView
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
            this.pickupsGrid = new System.Windows.Forms.DataGridView();
            this.viewChecklistButton = new System.Windows.Forms.Button();
            this.startPickupButton = new System.Windows.Forms.Button();
            this.dateRangeLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.dtpTO = new System.Windows.Forms.DateTimePicker();
            this.dtpFROM = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pickupsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(115, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Today\'s Pickups";
            // 
            // pickupsGrid
            // 
            this.pickupsGrid.AllowUserToAddRows = false;
            this.pickupsGrid.AllowUserToDeleteRows = false;
            this.pickupsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupsGrid.BackgroundColor = System.Drawing.Color.White;
            this.pickupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pickupsGrid.Location = new System.Drawing.Point(19, 66);
            this.pickupsGrid.Name = "pickupsGrid";
            this.pickupsGrid.ReadOnly = true;
            this.pickupsGrid.RowHeadersVisible = false;
            this.pickupsGrid.Size = new System.Drawing.Size(624, 249);
            this.pickupsGrid.TabIndex = 5;
            this.pickupsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pickupsGrid_CellContentClick);
            // 
            // viewChecklistButton
            // 
            this.viewChecklistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewChecklistButton.BackColor = System.Drawing.Color.White;
            this.viewChecklistButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewChecklistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewChecklistButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewChecklistButton.ForeColor = System.Drawing.Color.DimGray;
            this.viewChecklistButton.Location = new System.Drawing.Point(547, 37);
            this.viewChecklistButton.Name = "viewChecklistButton";
            this.viewChecklistButton.Size = new System.Drawing.Size(96, 23);
            this.viewChecklistButton.TabIndex = 7;
            this.viewChecklistButton.Text = "Walk-In Client";
            this.viewChecklistButton.UseVisualStyleBackColor = false;
            this.viewChecklistButton.Click += new System.EventHandler(this.viewChecklistButton_Click);
            // 
            // startPickupButton
            // 
            this.startPickupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startPickupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.startPickupButton.FlatAppearance.BorderSize = 0;
            this.startPickupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPickupButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startPickupButton.ForeColor = System.Drawing.Color.White;
            this.startPickupButton.Location = new System.Drawing.Point(447, 37);
            this.startPickupButton.Name = "startPickupButton";
            this.startPickupButton.Size = new System.Drawing.Size(94, 23);
            this.startPickupButton.TabIndex = 6;
            this.startPickupButton.Text = "Start Pickup";
            this.startPickupButton.UseVisualStyleBackColor = false;
            this.startPickupButton.Click += new System.EventHandler(this.startPickupButton_Click);
            // 
            // dateRangeLabel
            // 
            this.dateRangeLabel.AutoSize = true;
            this.dateRangeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateRangeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.dateRangeLabel.Location = new System.Drawing.Point(16, 42);
            this.dateRangeLabel.Name = "dateRangeLabel";
            this.dateRangeLabel.Size = new System.Drawing.Size(67, 15);
            this.dateRangeLabel.TabIndex = 9;
            this.dateRangeLabel.Text = "Date Range";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toLabel.ForeColor = System.Drawing.Color.DimGray;
            this.toLabel.Location = new System.Drawing.Point(188, 40);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(18, 15);
            this.toLabel.TabIndex = 8;
            this.toLabel.Text = "to";
            // 
            // dtpTO
            // 
            this.dtpTO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTO.Location = new System.Drawing.Point(209, 37);
            this.dtpTO.Name = "dtpTO";
            this.dtpTO.Size = new System.Drawing.Size(95, 23);
            this.dtpTO.TabIndex = 11;
            this.dtpTO.ValueChanged += new System.EventHandler(this.dtpTO_ValueChanged);
            // 
            // dtpFROM
            // 
            this.dtpFROM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFROM.Location = new System.Drawing.Point(89, 37);
            this.dtpFROM.Name = "dtpFROM";
            this.dtpFROM.Size = new System.Drawing.Size(95, 23);
            this.dtpFROM.TabIndex = 10;
            this.dtpFROM.ValueChanged += new System.EventHandler(this.dtpFROM_ValueChanged);
            // 
            // PickupsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateRangeLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.dtpTO);
            this.Controls.Add(this.dtpFROM);
            this.Controls.Add(this.viewChecklistButton);
            this.Controls.Add(this.startPickupButton);
            this.Controls.Add(this.pickupsGrid);
            this.Controls.Add(this.headerLabel);
            this.Name = "PickupsView";
            this.Size = new System.Drawing.Size(660, 341);
            ((System.ComponentModel.ISupportInitialize)(this.pickupsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView pickupsGrid;
        private System.Windows.Forms.Button viewChecklistButton;
        private System.Windows.Forms.Button startPickupButton;
        private System.Windows.Forms.Label dateRangeLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker dtpTO;
        private System.Windows.Forms.DateTimePicker dtpFROM;
    }
}



