namespace RentalApp.UI.Popups
{
    partial class EditVehicle
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
            this.cnclbt = new System.Windows.Forms.Button();
            this.svbt = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.materialLabel13 = new System.Windows.Forms.Label();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.materialLabel10 = new System.Windows.Forms.Label();
            this.cmbTT = new System.Windows.Forms.ComboBox();
            this.materialLabel9 = new System.Windows.Forms.Label();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.materialLabel12 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new System.Windows.Forms.Label();
            this.txtmileage = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new System.Windows.Forms.Label();
            this.txtLP = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new System.Windows.Forms.Label();
            this.txtyr = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.txtmake = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cnclbt);
            this.panel1.Controls.Add(this.svbt);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.materialLabel13);
            this.panel1.Controls.Add(this.cmbVT);
            this.panel1.Controls.Add(this.materialLabel10);
            this.panel1.Controls.Add(this.cmbTT);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Controls.Add(this.txtSC);
            this.panel1.Controls.Add(this.materialLabel12);
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.txtmileage);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.txtVIN);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.txtLP);
            this.panel1.Controls.Add(this.materialLabel11);
            this.panel1.Controls.Add(this.txtyr);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.txtmodel);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.txtmake);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cnclbt
            // 
            this.cnclbt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnclbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnclbt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cnclbt.ForeColor = System.Drawing.Color.DimGray;
            this.cnclbt.Location = new System.Drawing.Point(320, 520);
            this.cnclbt.Name = "cnclbt";
            this.cnclbt.Size = new System.Drawing.Size(140, 45);
            this.cnclbt.TabIndex = 24;
            this.cnclbt.Text = "Cancel";
            this.cnclbt.UseVisualStyleBackColor = false;
            this.cnclbt.Click += new System.EventHandler(this.cnclbt_Click);
            // 
            // svbt
            // 
            this.svbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.svbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.svbt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.svbt.ForeColor = System.Drawing.Color.White;
            this.svbt.Location = new System.Drawing.Point(30, 520);
            this.svbt.Name = "svbt";
            this.svbt.Size = new System.Drawing.Size(270, 45);
            this.svbt.TabIndex = 23;
            this.svbt.Text = "Save Changes";
            this.svbt.UseVisualStyleBackColor = false;
            this.svbt.Click += new System.EventHandler(this.svbt_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(30, 450);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 31);
            this.cmbStatus.TabIndex = 22;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel13.Location = new System.Drawing.Point(26, 425);
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(52, 20);
            this.materialLabel13.TabIndex = 21;
            this.materialLabel13.Text = "Status:";
            // 
            // cmbVT
            // 
            this.cmbVT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(260, 380);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(200, 31);
            this.cmbVT.TabIndex = 20;
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.cmbVT_SelectedIndexChanged);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel10.Location = new System.Drawing.Point(256, 355);
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(43, 20);
            this.materialLabel10.TabIndex = 19;
            this.materialLabel10.Text = "Type:";
            // 
            // cmbTT
            // 
            this.cmbTT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTT.FormattingEnabled = true;
            this.cmbTT.Location = new System.Drawing.Point(30, 380);
            this.cmbTT.Name = "cmbTT";
            this.cmbTT.Size = new System.Drawing.Size(200, 31);
            this.cmbTT.TabIndex = 18;
            this.cmbTT.SelectedIndexChanged += new System.EventHandler(this.cmbTT_SelectedIndexChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel9.Location = new System.Drawing.Point(26, 355);
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(135, 20);
            this.materialLabel9.TabIndex = 17;
            this.materialLabel9.Text = "Transmission Type:";
            // 
            // txtSC
            // 
            this.txtSC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSC.Location = new System.Drawing.Point(260, 310);
            this.txtSC.Name = "txtSC";
            this.txtSC.Size = new System.Drawing.Size(200, 30);
            this.txtSC.TabIndex = 16;
            this.txtSC.TextChanged += new System.EventHandler(this.txtSC_TextChanged);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel12.Location = new System.Drawing.Point(256, 285);
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(124, 20);
            this.materialLabel12.TabIndex = 15;
            this.materialLabel12.Text = "Seating Capacity:";
            this.materialLabel12.Click += new System.EventHandler(this.materialLabel12_Click);
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcolor.Location = new System.Drawing.Point(30, 310);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(200, 30);
            this.txtcolor.TabIndex = 14;
            this.txtcolor.TextChanged += new System.EventHandler(this.txtcolor_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel5.Location = new System.Drawing.Point(26, 285);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 20);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Color:";
            // 
            // txtmileage
            // 
            this.txtmileage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmileage.Location = new System.Drawing.Point(260, 240);
            this.txtmileage.Name = "txtmileage";
            this.txtmileage.Size = new System.Drawing.Size(200, 30);
            this.txtmileage.TabIndex = 12;
            this.txtmileage.TextChanged += new System.EventHandler(this.txtmileage_TextChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel7.Location = new System.Drawing.Point(256, 215);
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(66, 20);
            this.materialLabel7.TabIndex = 11;
            this.materialLabel7.Text = "Mileage:";
            // 
            // txtVIN
            // 
            this.txtVIN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVIN.Location = new System.Drawing.Point(30, 240);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(200, 30);
            this.txtVIN.TabIndex = 10;
            this.txtVIN.TextChanged += new System.EventHandler(this.txtVIN_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel6.Location = new System.Drawing.Point(26, 215);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(37, 20);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "VIN:";
            // 
            // txtLP
            // 
            this.txtLP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLP.Location = new System.Drawing.Point(30, 170);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(430, 30);
            this.txtLP.TabIndex = 8;
            this.txtLP.TextChanged += new System.EventHandler(this.txtLP_TextChanged);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel11.Location = new System.Drawing.Point(26, 145);
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(97, 20);
            this.materialLabel11.TabIndex = 7;
            this.materialLabel11.Text = "License Plate:";
            // 
            // txtyr
            // 
            this.txtyr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtyr.Location = new System.Drawing.Point(30, 100);
            this.txtyr.Name = "txtyr";
            this.txtyr.Size = new System.Drawing.Size(100, 30);
            this.txtyr.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(26, 75);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 20);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Year:";
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmodel.Location = new System.Drawing.Point(320, 100);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(140, 30);
            this.txtmodel.TabIndex = 4;
            this.txtmodel.TextChanged += new System.EventHandler(this.txtmodel_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel3.Location = new System.Drawing.Point(316, 75);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 20);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Model:";
            // 
            // txtmake
            // 
            this.txtmake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmake.Location = new System.Drawing.Point(150, 100);
            this.txtmake.Name = "txtmake";
            this.txtmake.Size = new System.Drawing.Size(150, 30);
            this.txtmake.TabIndex = 2;
            this.txtmake.TextChanged += new System.EventHandler(this.txtmake_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel2.Location = new System.Drawing.Point(146, 75);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 20);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Make:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 20);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(182, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Edit Vehicle";
            // 
            // EditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Vehicle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.TextBox txtmake;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.TextBox txtyr;
        private System.Windows.Forms.Label materialLabel11;
        private System.Windows.Forms.TextBox txtLP;
        private System.Windows.Forms.Label materialLabel6;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.Label materialLabel7;
        private System.Windows.Forms.TextBox txtmileage;
        private System.Windows.Forms.Label materialLabel5;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label materialLabel12;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.Label materialLabel9;
        private System.Windows.Forms.ComboBox cmbTT;
        private System.Windows.Forms.Label materialLabel10;
        private System.Windows.Forms.ComboBox cmbVT;
        private System.Windows.Forms.Label materialLabel13;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button svbt;
        private System.Windows.Forms.Button cnclbt;
    }
}
