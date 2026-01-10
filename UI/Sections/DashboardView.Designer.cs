using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RentalApp.UI.Sections
{
    partial class DashboardView
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
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(0, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(404, 41);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Dashboard - Welcome, Nino";
            // 
            // cardsPanel
            // 
            this.cardsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardsPanel.Location = new System.Drawing.Point(0, 60);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(1426, 200);
            this.cardsPanel.TabIndex = 1;
            this.cardsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cardsPanel_Paint);
            // 
            // DashboardView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cardsPanel);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1446, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.FlowLayoutPanel cardsPanel;
    }
}
