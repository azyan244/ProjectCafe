using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq; 
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting; 



namespace ProjectCafe
{
    public partial class FormAdminMenu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\Desktop\\ProjectCafe\\ProjectCafe\\Cafe.mdf;Integrated Security=True");
        public FormAdminMenu()
        {
            InitializeComponent();
        }

        private void mENUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mENUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }

        private void FormAdminMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.MENU' table. You can move, or remove it, as needed.
            this.mENUTableAdapter.Fill(this.cafeDataSet.MENU);
            LoadLowestSellingItemsChart();

        }


        private void mENUDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadMenuData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Menu", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMenu.DataSource = dt;
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAdminHome formAdminHome = new FormAdminHome();
            this.Hide();
            formAdminHome.ShowDialog();
            this.Close();
        }

        private void orderToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void chartItemnotsoldwell_Click(object sender, EventArgs e)
        {
        }
        private void LoadLowestSellingItemsChart()
        {
            chartItemnotsoldwell.Series.Clear();
            chartItemnotsoldwell.ChartAreas[0].AxisX.Title = "Menu Item";
            chartItemnotsoldwell.ChartAreas[0].AxisY.Title = "Quantity Sold";

            Series series = new Series("Low Selling Items");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            con.Open();
            SqlCommand cmd = new SqlCommand(@"
            SELECT TOP 5 m.MenuName, 
            ISNULL(SUM(oi.Quantity), 0) AS TotalSold
            FROM Menu m
            LEFT JOIN Order_Item oi ON oi.MenuId = m.MenuId
            GROUP BY m.MenuName
            ORDER BY TotalSold ASC", con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string menuName = reader[0].ToString();
                int quantity = Convert.ToInt32(reader[1]);
                series.Points.AddXY(menuName, quantity);
            }
            reader.Close();
            con.Close();

            chartItemnotsoldwell.Series.Add(series);
        }

    }
}
