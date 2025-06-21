using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormPayment : Form
    {
        private decimal grandTotal;
        private int pickupNumber = 0;
        private int CustID;

        private List<CartItem> CartItems;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\ProjectCafe\ProjectCafe\Cafe.mdf;Integrated Security=True";


        public FormPayment(decimal total, int CustID, List<CartItem> cartItems)
        {
            InitializeComponent();

            comboBoxBank.Visible = false;
            labelNameDelivery.Visible = false;
            labelPhoneDelivery.Visible = false;
            labelAddressDelivery.Visible = false;
            txtBoxAddressDelivery.Visible = false;
            txtBoxNameDelivery.Visible = false;
            txtBoxPhoneDelivery.Visible = false;
            btnEdit.Visible = false;

            comboBoxBank.DropDownStyle = ComboBoxStyle.DropDownList;

            this.CustID = CustID;
            grandTotal = total;

            this.CartItems = cartItems;

            listBoxTotalPrice.Items.Clear(); // Clear any previous entries
            listBoxTotalPrice.Items.Add($"RM{grandTotal:0.00}");

        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            // Initially disable editing
            txtBoxNameDelivery.ReadOnly = true;
            txtBoxPhoneDelivery.ReadOnly = true;
            txtBoxAddressDelivery.ReadOnly = true;

            // Fetch customer data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT Name, Phone, Address FROM CUSTOMER WHERE CustID = @custID";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@custID", CustID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBoxNameDelivery.Text = reader["Name"].ToString();
                                txtBoxPhoneDelivery.Text = reader["Phone"].ToString();
                                txtBoxAddressDelivery.Text = reader["Address"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Check if delivery/pickup is selected
                if (!rbDelivery.Checked && !rbPickUp.Checked)
                {
                    MessageBox.Show("Please select either Delivery or Pick-Up option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Check if a payment method is selected
                if (!rbCash.Checked && !rbTNG.Checked && !rbBank.Checked)
                {
                    MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ If Bank is selected, ensure a bank is selected from comboBox
                if (rbBank.Checked && comboBoxBank.SelectedItem == null)
                {
                    MessageBox.Show("Please select a bank from the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceed with order creation
                string orderId = GenerateOrderID();
                int custId = CustID;
                DateTime orderDate = DateTime.Now;
                string orderType = rbDelivery.Checked ? "Delivery" : "Pickup";
                decimal totalAmount = grandTotal;
                string paymentStatus = "Paid";

                InsertOrder(orderId, custId, orderDate, orderType, totalAmount, paymentStatus);

                foreach (var item in CartItems)
                {
                    int orderItemId = GenerateOrderItemID();
                    InsertOrderItem(orderItemId, orderId, item.MenuID, item.Quantity, item.Subtotal);
                }

                if (orderType == "Delivery")
                {
                    string deliveryId = GenerateDeliveryID();
                    string address = txtBoxAddressDelivery.Text;
                    DateTime deliveryTime = DateTime.Now.AddHours(1);
                    string deliveryStatus = "Pending";

                    InsertDeliveryDetails(deliveryId, orderId, address, deliveryTime, deliveryStatus);
                }

                string paymentId = GeneratePaymentID();
                string paymentMethod = rbCash.Checked ? "Cash" :
                                       rbTNG.Checked ? "TNG" :
                                       "Bank - " + comboBoxBank.SelectedItem.ToString();

                InsertPayment(paymentId, orderId, DateTime.Now, paymentMethod, totalAmount);

                MessageBox.Show("Order successfully added to the system!");

                FormThanks formThanks = (pickupNumber != 0) ? new FormThanks(pickupNumber) : new FormThanks();
                formThanks.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void rdbtnBank_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBank.Checked)
            {
                comboBoxBank.Visible = true;
            }
            else
            {
                comboBoxBank.Visible = false;
            }

            if (rbBank.Checked && comboBoxBank.SelectedItem == null)
            {
                MessageBox.Show("Please select a bank.");
                return;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelivery.Checked)
            {
                labelNameDelivery.Visible = true;
                labelPhoneDelivery.Visible = true;
                labelAddressDelivery.Visible = true;
                txtBoxNameDelivery.Visible = true;
                txtBoxPhoneDelivery.Visible = true;
                txtBoxAddressDelivery.Visible = true;
                btnEdit.Visible = true;
            }
            else
            {
                labelNameDelivery.Visible = false;
                labelPhoneDelivery.Visible = false;
                labelAddressDelivery.Visible = false;
                txtBoxNameDelivery.Visible = false;
                txtBoxPhoneDelivery.Visible = false;
                txtBoxAddressDelivery.Visible = false;
                btnEdit.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool isReadOnly = txtBoxNameDelivery.ReadOnly;

            txtBoxNameDelivery.ReadOnly = !isReadOnly;
            txtBoxPhoneDelivery.ReadOnly = !isReadOnly;
            txtBoxAddressDelivery.ReadOnly = !isReadOnly;

            btnEdit.Text = isReadOnly ? "Done" : "Edit";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPickUp.Checked)
            {
                Random rnd = new Random();
                pickupNumber = rnd.Next(0, 9999);
            }
            else
            {
                pickupNumber = 0; // Reset or keep as is
            }
        }

        // Helper to generate a random OrderID (or use a better unique generation logic)
        private string GenerateOrderID()
        {
            return "O" + DateTime.Now.Ticks.ToString().Substring(10);
        }

        private int GenerateOrderItemID()
        {
            int newID = 1; // Default ID if no records exist
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MAX(OrderItemID) FROM Order_Item";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        int lastID = Convert.ToInt32(result);
                        newID = lastID + 1; // increment
                    }
                }

            }
            return newID;
        }


        private string GenerateDeliveryID()
        {
            return "D" + DateTime.Now.Ticks.ToString().Substring(10);
        }

        private string GeneratePaymentID()
        {
            return "P" + DateTime.Now.Ticks.ToString().Substring(10);
        }

        // Insert into Order table
        private void InsertOrder(string orderId, int custId, DateTime orderDate, string orderType, decimal totalAmount, string paymentStatus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO [Orders] (OrderID, CustID, OrderDate, OrderType, TotalAmount, PaymentStatus) VALUES (@OrderID, @CustID, @OrderDate, @OrderType, @TotalAmount, @PaymentStatus)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@CustID", custId);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    cmd.Parameters.AddWithValue("@OrderType", orderType);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Insert into OrderItem table (requires your cartItems list)
        private void InsertOrderItem(int orderItemId, string orderId, string menuId, int quantity, decimal subtotal)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO ORDER_ITEM (OrderItemID, OrderID, MenuID, Quantity, Subtotal) VALUES (@OrderItemID, @OrderID, @MenuID, @Quantity, @Subtotal)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderItemID", orderItemId);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@MenuID", menuId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Insert into DeliveryDetails
        private void InsertDeliveryDetails(string deliveryId, string orderId, string address, DateTime deliveryTime, string deliveryStatus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO DELIVERYDETAILS (DeliveryID, OrderID, DeliveryAddress, DeliveryTime, DeliveryStatus) VALUES (@DeliveryID, @OrderID, @DeliveryAddress, @DeliveryTime, @DeliveryStatus)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@DeliveryID", deliveryId);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@DeliveryAddress", address);
                    cmd.Parameters.AddWithValue("@DeliveryTime", deliveryTime);
                    cmd.Parameters.AddWithValue("@DeliveryStatus", deliveryStatus);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Insert into Payment
        private void InsertPayment(string paymentId, string orderId, DateTime paymentDate, string paymentMethod, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Payment (PaymentID, OrderID, PaymentDate, PaymentMethod, Amount) VALUES (@PaymentID, @OrderID, @PaymentDate, @PaymentMethod, @Amount)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", paymentId);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

