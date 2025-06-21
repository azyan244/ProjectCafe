using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormFood : Form
    {
        private int custID;

        public FormFood(int custID)
        {
            InitializeComponent();
            this.custID = custID; // Store the customer ID for later use


            toolTip1.SetToolTip(btnRemoveFood, "Click to remove the selected item from the cart.");

            
        }

        private void btnCart_Click(object sender, EventArgs e)

        {

            string food = GetSelectedFood();
            string menuId = GetMenuID(food);
            int quantity = Convert.ToInt32(numericUpDownFood.Value); decimal unitPrice = GetFoodPrice();
            decimal totalPrice = unitPrice * quantity;

            var existingItem = CartData.CartItems.FirstOrDefault(x => x.MenuID == menuId);

            if (existingItem != null)
            {
                // Update quantity and subtotal
                existingItem.Quantity += quantity;
            }
            else
            {
                // Add new item
                CartData.CartItems.Add(new CartItem
                {
                    MenuID = menuId,
                    MenuName = food,
                    Quantity = quantity,
                    Price = unitPrice,
                });
            }

            if (string.IsNullOrEmpty(food) || quantity == 0)
            {
                MessageBox.Show("Please select a food item and quantity.");
                return;
            }

            string item = $"{quantity}x {food}";
            listBoxCartFood.Items.Add(item);
            listBoxPriceFood.Items.Add($"RM{totalPrice:0.00}");

            UpdateTotalPrice();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FormMethod formMethod = new FormMethod(this.custID);
            this.Hide();
            formMethod.ShowDialog(); // Wait until this form is closed
            this.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVanillaWhirl.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM11.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/vanilla whirl.png");
            }
        }



        private void rbButterCroissant_CheckedChanged(object sender, EventArgs e)
        {
            if (rbButterCroissant.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM8.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/butter-croissant.png");
            }
        }

        private void rbPainauChoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPainauChoc.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM10.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/pain-au-chocolate.png");
            }
        }

        private void rbCinRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCinRoll.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM10.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/cinnamon-roll.png");
            }
        }

        private void rbBBC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBBC.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM15.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/basque-burnt-cheesecake.png");
            }
        }

        private void rbCarrotCake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCarrotCake.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM14.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/carrot-walnut-cake.png");
            }
        }

        private void rbChocFudgeCake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChocFudgeCake.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM14.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/chocolate-fudge-cake.png");
            }
        }

        private void rbRVCake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRVCake.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM14.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/red-velvet-cake.png");
            }
        }

        private void rbSausageRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSausageRoll.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM10.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/sausage-roll.png");
            }
        }

        private void rbCMP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCMP.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM11.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/chicken-puff.png");
            }
        }

        private void rbCurryPuff_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCurryPuff.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM8.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/curry-puff.png");
            }
        }

        private void rbMCS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMCS.Checked)
            {
                listBoxPrice.Items.Clear();
                listBoxPrice.Items.Add("RM12.00");
                ptrbxFood.Image = System.Drawing.Image.FromFile($"images/croissant-sandwich.png");
            }
        }


        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxCartFood.SelectedIndex;

            if (selectedIndex >= 0)
            {
                listBoxCartFood.Items.RemoveAt(selectedIndex);
                listBoxPriceFood.Items.RemoveAt(selectedIndex);
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        // Get selected food
        private string GetSelectedFood()
        {
            if (rbVanillaWhirl.Checked) return "Vanilla Whirl";
            if (rbButterCroissant.Checked) return "Butter Croissant";
            if (rbPainauChoc.Checked) return "Pain au Chocolat";
            if (rbCinRoll.Checked) return "Cinnamon Roll";
            if (rbBBC.Checked) return "Basque Burnt Cheesecake";
            if (rbCarrotCake.Checked) return "Carrot Cake";
            if (rbChocFudgeCake.Checked) return "Chocolate Fudge Cake";
            if (rbRVCake.Checked) return "Red Velvet Cake";
            if (rbSausageRoll.Checked) return "Sausage Roll";
            if (rbCMP.Checked) return "Chicken Mushroom Pie";
            if (rbCurryPuff.Checked) return "Curry Puff";
            if (rbMCS.Checked) return "Mini Cheese Sandwich";

            return "";
        }


        private decimal GetFoodPrice()
        {
            if (rbVanillaWhirl.Checked) return 11.00m;
            if (rbButterCroissant.Checked) return 8.00m;
            if (rbPainauChoc.Checked) return 10.00m;
            if (rbCinRoll.Checked) return 10.00m;
            if (rbBBC.Checked) return 15.00m;
            if (rbCarrotCake.Checked) return 14.00m;
            if (rbChocFudgeCake.Checked) return 14.00m;
            if (rbRVCake.Checked) return 14.00m;
            if (rbSausageRoll.Checked) return 10.00m;
            if (rbCMP.Checked) return 11.00m;
            if (rbCurryPuff.Checked) return 8.00m;
            if (rbMCS.Checked) return 12.00m;

            return 0.00m;
        }

        private string GetMenuID(string foodName)
        {
            switch (foodName)
            {
                case "Vanilla Whirl": return "P04";
                case "Butter Croissant": return "P01";
                case "Pain au Chocolat": return "P02";
                case "Cinnamon Roll": return "P03";
                case "Basque Burnt Cheesecake": return "C01";
                case "Carrot Cake": return "C02";
                case "Chocolate Fudge Cake": return "C03";
                case "Red Velvet Cake": return "C04";
                case "Sausage Roll": return "S01";
                case "Chicken Mushroom Pie": return "S02";
                case "Curry Puff": return "S03";
                case "Mini Cheese Sandwich": return "S04";
                default: return "Null";
            }
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (var item in listBoxPriceFood.Items)
            {
                string priceText = item.ToString().Replace("RM", "");
                if (decimal.TryParse(priceText, out decimal price))
                {
                    total += price;
                }
            }

            listBoxTotalFood.Items.Clear(); // Clear previous total
            listBoxTotalFood.Items.Add($"RM{total:0.00}");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDrink formdrink = new FormDrink(this.custID);
            this.Hide();
            formdrink.ShowDialog(); // Wait until this form is closed
            this.Close(); ;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
