namespace RentalApp.UI.Popups
{
    partial class VehicleDetailsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstFeatures = new System.Windows.Forms.ListBox();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblMakeModel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstFeatures);
            this.panel1.Controls.Add(this.lblFeatures);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblLicense);
            this.panel1.Controls.Add(this.lblMakeModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 480);
            this.panel1.TabIndex = 0;
            // 
            // lstFeatures
            // 
            this.lstFeatures.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFeatures.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstFeatures.FormattingEnabled = true;
            this.lstFeatures.ItemHeight = 23;
            this.lstFeatures.Location = new System.Drawing.Point(25, 230);
            this.lstFeatures.Name = "lstFeatures";
            this.lstFeatures.Size = new System.Drawing.Size(350, 161);
            this.lstFeatures.TabIndex = 6;
            this.lstFeatures.SelectedIndexChanged += new System.EventHandler(this.lstFeatures_SelectedIndexChanged);
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeatures.ForeColor = System.Drawing.Color.DimGray;
            this.lblFeatures.Location = new System.Drawing.Point(21, 200);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(78, 23);
            this.lblFeatures.TabIndex = 5;
            this.lblFeatures.Text = "Features";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.Location = new System.Drawing.Point(25, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(350, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(20, 155);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(51, 25);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(20, 115);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 25);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLicense.ForeColor = System.Drawing.Color.Black;
            this.lblLicense.Location = new System.Drawing.Point(20, 75);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(73, 25);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "License";
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.AutoSize = true;
            this.lblMakeModel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMakeModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblMakeModel.Location = new System.Drawing.Point(20, 25);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(191, 37);
            this.lblMakeModel.TabIndex = 0;
            this.lblMakeModel.Text = "Vehicle Name";
            // 
            // VehicleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.ListBox lstFeatures;
    }
}
