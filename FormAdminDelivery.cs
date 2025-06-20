using System;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

namespace ProjectCafe
{
    public partial class FormAdminDelivery : Form
    {
        public FormAdminDelivery()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deliveryDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }

        private void FormAdminDelivery_Load(object sender, EventArgs e)
        {
            this.deliveryDetailsTableAdapter.Fill(this.cafeDataSet.DeliveryDetails);

            // Extract area from address (e.g., last part before "Melaka")
            var areaCounts = cafeDataSet.DeliveryDetails
                .AsEnumerable()
                .Select(row =>
                {
                    string address = row.Field<string>("DeliveryAddress"); // Use your actual column name
                    string area = "Unknown";

                    if (!string.IsNullOrEmpty(address))
                    {
                        // Split by comma, take 2nd last part as area (before "Melaka")
                        var parts = address.Split(',');
                        if (parts.Length >= 2)
                            area = parts[parts.Length - 2].Trim();
                    }

                    return area;
                })
                .GroupBy(area => area)
                .Select(group => new
                {
                    Area = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(x => x.Count)
                .Take(5) // Top 5 areas
                .ToList();

            // Prepare chart
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Top Delivery Areas");

            Series series = new Series
            {
                Name = "DeliveryArea",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie // or .Bar / .Column
            };

            chart1.Series.Add(series);

            foreach (var item in areaCounts)
            {
                series.Points.AddXY(item.Area, item.Count);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }



        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAdminHome formAdminHome = new FormAdminHome();
            this.Hide();
            formAdminHome.ShowDialog();
            this.Close();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminOrder formAdminOrder = new FormAdminOrder();
            this.Hide();
            formAdminOrder.ShowDialog();
            this.Close();
        }

        private void orderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminOrder_Item orderItem = new FormAdminOrder_Item();
            this.Hide();
            orderItem.ShowDialog();
            this.Close();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminCustomer formAdminCustomer = new FormAdminCustomer();
            this.Hide();
            formAdminCustomer.ShowDialog();
            this.Close();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminDelivery formAdminDelivery = new FormAdminDelivery();
            this.Hide();
            formAdminDelivery.ShowDialog();
            this.Close();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminPayment formAdminPayment = new FormAdminPayment();
            this.Hide();
            formAdminPayment.ShowDialog();
            this.Close();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminMenu mAdminMenu = new FormAdminMenu();
            this.Hide();
            mAdminMenu.ShowDialog();
            this.Close();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
