using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace ProjectCafe
{
    public partial class FormAdminHome : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\ProjectCafe\\ProjectCafe\\Cafe.mdf;Integrated Security=True");
        public FormAdminHome()
        {
            InitializeComponent();
            LoadTopSellingChart();
        }

        private void LoadTopSellingChart()
        {
            chartTopItems.Series[0].ChartType = SeriesChartType.Column;
            chartTopItems.Series[0].IsValueShownAsLabel = true;
            chartTopItems.ChartAreas[0].AxisX.Title = "Menu Item";
            chartTopItems.ChartAreas[0].AxisY.Title = "Quantity Sold";

            con.Open();
            SqlCommand cmd = new SqlCommand(@"
        SELECT TOP 5 m.MenuName, SUM(oi.Quantity) AS TotalSold
        FROM Order_Item oi
        JOIN Menu m ON oi.MenuId = m.MenuId
        GROUP BY m.MenuName
        ORDER BY TotalSold DESC", con); // Get top 5 items

            SqlDataReader reader = cmd.ExecuteReader();

            // Store results in a list to sort manually
            var topItems = new List<KeyValuePair<string, int>>();
            while (reader.Read())
            {
                topItems.Add(new KeyValuePair<string, int>(
                    reader[0].ToString(),
                    Convert.ToInt32(reader[1])
                ));
            }
            reader.Close();
            con.Close();

            // Sort the list in ascending order
            var sortedItems = topItems.OrderBy(item => item.Value).ToList();

            chartTopItems.Series[0].Points.Clear();
            foreach (var item in sortedItems)
            {
                chartTopItems.Series[0].Points.AddXY(item.Key, item.Value);
            }
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
        
        private void FormAdminHome_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminHome formAdminHome = new FormAdminHome();
            this.Hide();
            formAdminHome.ShowDialog();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminMenu formAdminMenu = new FormAdminMenu();
            this.Hide();
            formAdminMenu.ShowDialog();
            this.Close();
        }
    }
}
