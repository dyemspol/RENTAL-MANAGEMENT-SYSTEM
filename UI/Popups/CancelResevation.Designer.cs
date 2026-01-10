namespace RentalApp.UI.Popups
{
    partial class CancelResevation
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
            this.exitbt = new System.Windows.Forms.Button();
            this.cancelbt = new System.Windows.Forms.Button();
            this.expectreturndt = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new System.Windows.Forms.Label();
            this.pickupdt = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.vehicletxt = new System.Windows.Forms.Label();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.txtcstmr = new System.Windows.Forms.Label();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.rsvtnID = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.exitbt);
            this.panel1.Controls.Add(this.cancelbt);
            this.panel1.Controls.Add(this.expectreturndt);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.pickupdt);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.vehicletxt);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.txtcstmr);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.rsvtnID);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 0;
            // 
            // exitbt
            // 
            this.exitbt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exitbt.ForeColor = System.Drawing.Color.DimGray;
            this.exitbt.Location = new System.Drawing.Point(235, 380);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(140, 45);
            this.exitbt.TabIndex = 12;
            this.exitbt.Text = "Back";
            this.exitbt.UseVisualStyleBackColor = false;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // cancelbt
            // 
            this.cancelbt.BackColor = System.Drawing.Color.Crimson;
            this.cancelbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cancelbt.ForeColor = System.Drawing.Color.White;
            this.cancelbt.Location = new System.Drawing.Point(25, 380);
            this.cancelbt.Name = "cancelbt";
            this.cancelbt.Size = new System.Drawing.Size(200, 45);
            this.cancelbt.TabIndex = 11;
            this.cancelbt.Text = "Cancel Reservation";
            this.cancelbt.UseVisualStyleBackColor = false;
            this.cancelbt.Click += new System.EventHandler(this.cancelbt_Click);
            // 
            // expectreturndt
            // 
            this.expectreturndt.Enabled = false;
            this.expectreturndt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.expectreturndt.Location = new System.Drawing.Point(25, 310);
            this.expectreturndt.Name = "expectreturndt";
            this.expectreturndt.Size = new System.Drawing.Size(350, 30);
            this.expectreturndt.TabIndex = 10;
            this.expectreturndt.ValueChanged += new System.EventHandler(this.expectreturndt_ValueChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel5.Location = new System.Drawing.Point(21, 285);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(91, 20);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Return Date:";
            // 
            // pickupdt
            // 
            this.pickupdt.Enabled = false;
            this.pickupdt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pickupdt.Location = new System.Drawing.Point(25, 230);
            this.pickupdt.Name = "pickupdt";
            this.pickupdt.Size = new System.Drawing.Size(350, 30);
            this.pickupdt.TabIndex = 8;
            this.pickupdt.ValueChanged += new System.EventHandler(this.pickupdt_ValueChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(21, 205);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(89, 20);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Pickup Date:";
            // 
            // vehicletxt
            // 
            this.vehicletxt.AutoSize = true;
            this.vehicletxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.vehicletxt.ForeColor = System.Drawing.Color.Black;
            this.vehicletxt.Location = new System.Drawing.Point(150, 160);
            this.vehicletxt.Name = "vehicletxt";
            this.vehicletxt.Size = new System.Drawing.Size(125, 25);
            this.vehicletxt.TabIndex = 6;
            this.vehicletxt.Text = "Vehicle Name";
            this.vehicletxt.Click += new System.EventHandler(this.vehicletxt_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel3.Location = new System.Drawing.Point(21, 165);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 20);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Vehicle:";
            // 
            // txtcstmr
            // 
            this.txtcstmr.AutoSize = true;
            this.txtcstmr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtcstmr.ForeColor = System.Drawing.Color.Black;
            this.txtcstmr.Location = new System.Drawing.Point(150, 120);
            this.txtcstmr.Name = "txtcstmr";
            this.txtcstmr.Size = new System.Drawing.Size(155, 25);
            this.txtcstmr.TabIndex = 4;
            this.txtcstmr.Text = "Customer Name";
            this.txtcstmr.Click += new System.EventHandler(this.txtcstmr_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel2.Location = new System.Drawing.Point(21, 125);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 20);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Customer:";
            // 
            // rsvtnID
            // 
            this.rsvtnID.AutoSize = true;
            this.rsvtnID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rsvtnID.ForeColor = System.Drawing.Color.Black;
            this.rsvtnID.Location = new System.Drawing.Point(150, 80);
            this.rsvtnID.Name = "rsvtnID";
            this.rsvtnID.Size = new System.Drawing.Size(32, 25);
            this.rsvtnID.TabIndex = 2;
            this.rsvtnID.Text = "00";
            this.rsvtnID.Click += new System.EventHandler(this.rsvtnID_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel1.Location = new System.Drawing.Point(21, 85);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 20);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Reservation ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cancel Reservation";
            // 
            // CancelResevation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelResevation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancel Reservation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label rsvtnID;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.Label txtcstmr;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.Label vehicletxt;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.DateTimePicker pickupdt;
        private System.Windows.Forms.Label materialLabel5;
        private System.Windows.Forms.DateTimePicker expectreturndt;
        private System.Windows.Forms.Button cancelbt;
        private System.Windows.Forms.Button exitbt;
    }
}
