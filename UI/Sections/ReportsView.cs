using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace RentalApp.UI.Sections
{
    public partial class ReportsView : UserControl
    {
        public ReportsView()
        {
            InitializeComponent();
            InitializeDragAndDrop();
            InitializeCharts();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            reportsGrid.Columns.Add("Date", "Date");
            reportsGrid.Columns.Add("Category", "Category");
            reportsGrid.Columns.Add("Description", "Description");
            reportsGrid.Columns.Add("Amount", "Amount (₱)");
            reportsGrid.Columns.Add("Status", "Status");

            // Dummy Data
            reportsGrid.Rows.Add("01/01/2026", "Rental", "Toyota Vios Rental - 3 Days", "4,500.00", "Completed");
            reportsGrid.Rows.Add("01/02/2026", "Rental", "Honda City Rental - 2 Days", "3,200.00", "Completed");
            reportsGrid.Rows.Add("01/03/2026", "Maintenance", "Oil Change - Ford Everest", "-1,500.00", "Paid");
            reportsGrid.Rows.Add("01/05/2026", "Rental", "Isuzu D-Max Rental - 5 Days", "12,500.00", "Active");
            reportsGrid.Rows.Add("01/08/2026", "Fine", "Late Return Penalty", "500.00", "Collected");
            reportsGrid.Rows.Add("01/10/2026", "Rental", "Mitsubishi Montero - 7 Days", "21,000.00", "Reserved");
            reportsGrid.Rows.Add("01/11/2026", "Insurance", "Monthly Fleet Insurance", "-5,000.00", "Pending");
            reportsGrid.Rows.Add("01/12/2026", "Rental", "Nissan NV350 - 1 Day", "3,500.00", "Active");
            reportsGrid.Rows.Add("01/15/2026", "Service", "Tire Replacement - Plate ABC 123", "-8,000.00", "Scheduled");
        }

        private void InitializeCharts()
        {
            // Revenue Chart config
            revenueChart.Series.Clear();
            revenueChart.Titles.Clear();
            revenueChart.Titles.Add("Monthly Revenue");
            revenueChart.Palette = ChartColorPalette.SeaGreen;

            Series revenueSeries = new Series("Revenue")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            // Dummy data for Revenue
            revenueSeries.Points.AddXY("Jan", 12000);
            revenueSeries.Points.AddXY("Feb", 14500);
            revenueSeries.Points.AddXY("Mar", 13200);
            revenueSeries.Points.AddXY("Apr", 16000);
            revenueSeries.Points.AddXY("May", 21000);
            revenueSeries.Points.AddXY("Jun", 24000);

            revenueChart.Series.Add(revenueSeries);
            revenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            revenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;


            // Status Chart config
            statusChart.Series.Clear();
            statusChart.Titles.Clear();
            statusChart.Titles.Add("Fleet Status");
            statusChart.Palette = ChartColorPalette.BrightPastel;

            Series statusSeries = new Series("Status")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };

            // Dummy data for Status
            statusSeries.Points.AddXY("Available", 45);
            statusSeries.Points.AddXY("Rented", 30);
            statusSeries.Points.AddXY("Maintenance", 5);
            statusSeries.Points.AddXY("Reserved", 10);

            statusChart.Series.Add(statusSeries);
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += ReportsView_DragEnter;
            this.DragDrop += ReportsView_DragDrop;
        }

        private void ReportsView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ReportsView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                HandleDroppedFiles(files);
            }
        }

        private void HandleDroppedFiles(string[] files)
        {
            string fileList = string.Join("\n", files);
            MessageBox.Show($"Files dropped on Reports View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void statusChart_Click(object sender, EventArgs e)
        {

        }
    }
}



