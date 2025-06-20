using System;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormAdminOrder_Item : Form
    {
        public FormAdminOrder_Item()
        {
            InitializeComponent();
        }

        private void FormAdminOrder_Item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.ORDER_ITEM' table. You can move, or remove it, as needed.
            this.oRDER_ITEMTableAdapter.Fill(this.cafeDataSet.ORDER_ITEM);

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

        private void oRDER_ITEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oRDER_ITEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }
    }
}