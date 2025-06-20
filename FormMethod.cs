using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace ProjectCafe
{
    public partial class FormMethod : Form
    {
        public decimal grandTotal = 0;

        private int custID;

        private List<CartItem> cartItems = new List<CartItem>();


        public FormMethod(int custID)
        {
            InitializeComponent();
            this.custID = custID; // Store the customer ID for later use
        }
        private void FormMethod_Load(object sender, EventArgs e)
        {
            listBoxCart.Items.Clear();
            listBoxPrice.Items.Clear();

            foreach (var item in CartData.CartItems)
            {
                string displayItem = $"{item.Quantity}x {item.MenuName}";
                listBoxCart.Items.Add(displayItem);

                string displayPrice = $"RM{item.Subtotal:0.00}";
                listBoxPrice.Items.Add(displayPrice);

                // Add to local cartItems list for calculations if needed
                cartItems.Add(item);
            }

            // Calculate grand total
            grandTotal = cartItems.Sum(x => x.Subtotal);

            listBoxGrandTotal.Items.Clear();
            listBoxGrandTotal.Items.Add($"RM{grandTotal:0.00}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPayment paymentForm = new FormPayment(grandTotal, custID, cartItems);
            this.Hide();
            paymentForm.ShowDialog();
            this.Close();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FormDrink drink = new FormDrink(this.custID);
            this.Hide();
            drink.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveOrder_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCart.SelectedIndex;

            if (selectedIndex >= 0)
            {
                // Remove item from UI
                listBoxCart.Items.RemoveAt(selectedIndex);
                listBoxPrice.Items.RemoveAt(selectedIndex);

                // Remove from cart data
                cartItems.RemoveAt(selectedIndex);
                CartData.CartItems.RemoveAt(selectedIndex);

                // Update grand total
                UpdateGrandTotal();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
        private void UpdateGrandTotal()
        {
            grandTotal = cartItems.Sum(x => x.Subtotal);
            listBoxGrandTotal.Items.Clear();
            listBoxGrandTotal.Items.Add($"RM{grandTotal:0.00}");
        }
       

    }
}
