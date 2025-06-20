using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormAdminPayment : Form
    {
        public FormAdminPayment()
        {
            InitializeComponent();
        }

        private void FormAdminPayment_Load(object sender, EventArgs e)
        {
            this.paymentTableAdapter.Fill(this.cafeDataSet.Payment);

            // Calculate total sales
            decimal totalSales = 0;

            foreach (DataRow row in cafeDataSet.Payment.Rows)
            {
                if (row["Amount"] != DBNull.Value)
                {
                    totalSales += Convert.ToDecimal(row["Amount"]);
                }
            }

            // Display the total sales in the label
            lblTotalSales.Text = "Total Sales: RM " + totalSales.ToString("F2");

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminMenu menu = new FormAdminMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }
    }
}
