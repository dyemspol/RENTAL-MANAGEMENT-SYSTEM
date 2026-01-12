namespace RentalApp.UI.Sections
{
    partial class UsersView
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
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(17, 16);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(123, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "System Users";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "All Users",
            "Admin",
            "Manager",
            "RentalAgent"});
            this.filterComboBox.Location = new System.Drawing.Point(93, 49);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(228, 28);
            this.filterComboBox.TabIndex = 2;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterLabel.ForeColor = System.Drawing.Color.DimGray;
            this.filterLabel.Location = new System.Drawing.Point(20, 52);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(62, 20);
            this.filterLabel.TabIndex = 1;
            this.filterLabel.Text = "Filter by";
            // 
            // usersGrid
            // 
            this.usersGrid.AllowUserToAddRows = false;
            this.usersGrid.AllowUserToDeleteRows = false;
            this.usersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGrid.BackgroundColor = System.Drawing.Color.White;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Location = new System.Drawing.Point(20, 85);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.ReadOnly = true;
            this.usersGrid.RowHeadersVisible = false;
            this.usersGrid.RowHeadersWidth = 51;
            this.usersGrid.Size = new System.Drawing.Size(836, 299);
            this.usersGrid.TabIndex = 3;
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(596, 42);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(120, 35);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "+ Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.Location = new System.Drawing.Point(736, 42);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(120, 35);
            this.deleteUserButton.TabIndex = 5;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersGrid);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "UsersView";
            this.Size = new System.Drawing.Size(880, 405);
            this.Load += new System.EventHandler(this.UsersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteUserButton;
    }
}
