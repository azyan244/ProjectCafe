using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormAdminCustomer : Form
    {
        public FormAdminCustomer()
        {
            InitializeComponent();
        }

        private void cUSTOMERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cafeDataSet);

        }

        private void FormAdminCustomer_Load(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.cafeDataSet.CUSTOMER);
            ShowBigSpender();
            ShowTop3FrequentBuyers();

        }


        private void orderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAdminOrder formAdminOrder = new FormAdminOrder();
            this.Hide();
            formAdminOrder.ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminHome formAdminHome = new FormAdminHome();
            this.Hide(); 
            formAdminHome.ShowDialog();
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
        private void ShowBigSpender()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\ProjectCafe\ProjectCafe\Cafe.mdf;Integrated Security=True"))
            {
                string query = @"SELECT TOP 1 C.Name, O.TotalAmount
                         FROM CUSTOMER C
                         JOIN [ORDERS] O ON C.CustID = O.CustID
                         ORDER BY O.TotalAmount DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    labelBigSpender.Text = $"Big Spender: {reader["Name"]} - RM{reader["TotalAmount"]:0.00}";
                }

                reader.Close();
            }
         }

        private void ShowTop3FrequentBuyers()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\ProjectCafe\ProjectCafe\Cafe.mdf;Integrated Security=True"))
            {
                string query = @"SELECT TOP 3 C.Name, COUNT(O.OrderID) AS TotalOrders
                         FROM CUSTOMER C
                         JOIN [ORDERS] O ON C.CustID = O.CustID
                         GROUP BY C.Name
                         ORDER BY TotalOrders DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                int index = 1;
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    int totalOrders = Convert.ToInt32(reader["TotalOrders"]);

                    if (index == 1)
                        labelTop1.Text = $"1. {name} - {totalOrders} orders";
                    else if (index == 2)
                        labelTop2.Text = $"2. {name} - {totalOrders} orders";
                    else if (index == 3)
                        labelTop3.Text = $"3. {name} - {totalOrders} orders";

                    index++;
                }

                reader.Close();
            }
        }

        private void labelTop1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminMenu formAdminMenu = new FormAdminMenu();
            this.Hide();
            formAdminMenu.Show();
            this.Close();
        }
    }
}
