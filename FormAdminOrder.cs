using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormAdminOrder : Form
    {
        public FormAdminOrder()
        {
            InitializeComponent();
        }

        private void FormAdminOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.cafeDataSet.ORDERS);
            dateTimePickerStart.Value = DateTime.Today.AddMonths(-1);
            dateTimePickerEnd.Value = DateTime.Today;

            // Add grouping options
            comboBoxGroupBy.Items.AddRange(new string[] { "Day", "Month", "Year" });
            comboBoxGroupBy.SelectedIndex = 0; // Default to Day

            // Optional: configure chart
            chartSales.Series.Clear();
            chartSales.ChartAreas[0].AxisX.Title = "Date";
            chartSales.ChartAreas[0].AxisY.Title = "Number of Orders";
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
            FormAdminOrder_Item formAdminOrder_Item = new FormAdminOrder_Item();
            this.Hide();
            formAdminOrder_Item.ShowDialog();
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminMenu menu = new FormAdminMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void chartSales_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePickerStart.Value.Date;
            DateTime end = dateTimePickerEnd.Value.Date;

            if (start > end)
            {
                MessageBox.Show("Start date must be earlier than end date.");
                return;
            }

            string groupBy = comboBoxGroupBy.SelectedItem.ToString();

            // Load from database (replace this with your TableAdapter or SQL code)
            DataTable dt = GetOrderData(start, end); // Implement this function below

            var groupedData = dt.AsEnumerable()
                .Where(row =>
                {
                    DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);
                    return orderDate >= start && orderDate <= end;
                })
                .GroupBy(row =>
                {
                    DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);
                    switch (groupBy)
                    {
                        case "Month": return orderDate.ToString("yyyy-MM");
                        case "Year": return orderDate.Year.ToString();
                        default: return orderDate.ToString("yyyy-MM-dd");
                    }
                })
                .Select(g => new
                {
                    Period = g.Key,
                    OrderCount = g.Count()
                })
                .OrderBy(g => g.Period)
                .ToList();

            // Draw chart
            chartSales.Series.Clear();
            var series = chartSales.Series.Add("Orders");
            series.Points.Clear();
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (var item in groupedData)
            {
                series.Points.AddXY(item.Period, item.OrderCount);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private DataTable GetOrderData(DateTime start, DateTime end)
        {
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\ProjectCafe\\ProjectCafe\\Cafe.mdf;Integrated Security=True";
            string query = "SELECT OrderID, OrderDate FROM Orders WHERE OrderDate BETWEEN @start AND @end";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        private void oRDERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDERSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }
    }
}
