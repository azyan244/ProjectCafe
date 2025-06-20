using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormDrink : Form
    {
        private int custID;

        public FormDrink(int custID)
        {
            InitializeComponent();
            this.custID = custID; // Store the customer ID for later use

            toolTip1.SetToolTip(btnRemoveDrink, "Click to remove the selected item from the cart.");
        }
        private string GetSelectedDrink()
        {
            if (rbEspresso.Checked) return "Espresso";
            if (rbAmericano.Checked) return "Americano";
            if (rbCappucino.Checked) return "Cappucino";
            if (rbLatte.Checked) return "Latte";
            if (rbMocha.Checked) return "Mocha";
            if (rbCM.Checked) return "Caramel Macchiato";
            if (rbEnglish.Checked) return "English Tea";
            if (rbEarlGrey.Checked) return "Earl Grey Tea";
            if (rbChamomile.Checked) return "Chamomile Tea";
            if (rbMatcha.Checked) return "Matcha Latte";
            if (rbLemon.Checked) return "Lemon Tea";
            if (rbChai.Checked) return "Chai Latte";
            if (rbChocolate.Checked) return "Chocolate";
            if (rbChocShake.Checked) return "Chocolate Shake";
            if (rbVanillaShake.Checked) return "Vanilla Shake";
            if (rbStrawberryShake.Checked) return "Strawberry Shake";
            if (rbCaramelShake.Checked) return "Caramel Shake";
            return null;
        }

        private string GetSelectedDrinkID()
        {
            if (rbEspresso.Checked) return "B01";
            if (rbAmericano.Checked) return "B02";
            if (rbCappucino.Checked) return "B03";
            if (rbLatte.Checked) return "B04";
            if (rbMocha.Checked) return "B05";
            if (rbCM.Checked) return "B06";
            if (rbEnglish.Checked) return "B07";
            if (rbEarlGrey.Checked) return "B08";
            if (rbChamomile.Checked) return "B09";
            if (rbMatcha.Checked) return "B10";
            if (rbLemon.Checked) return "B11";
            if (rbChai.Checked) return "B12";
            if (rbChocolate.Checked) return "B13";
            if (rbChocShake.Checked) return "B14";
            if (rbVanillaShake.Checked) return "B15";
            if (rbStrawberryShake.Checked) return "B16";
            if (rbCaramelShake.Checked) return "B17";
            return null;
        }

        private decimal GetDrinkUnitPrice(string drink)
        {

            switch (drink)
            {
                case "Espresso": return 6.00m;
                case "Americano": return 7.00m;
                case "Cappucino": return 9.00m;
                case "Latte": return 9.00m;
                case "Mocha": return 10.00m;
                case "Caramel Macchiato": return 11.00m;
                case "English Tea": return 6.00m;
                case "Earl Grey Tea": return 6.00m;
                case "Chamomile Tea": return 7.00m;
                case "Matcha Latte": return 10.00m;
                case "Lemon Tea": return 6.00m;
                case "Chai Latte": return 9.00m;
                case "Chocolate": return 9.00m;
                case "Chocolate Shake": return 11.00m;
                case "Vanilla Shake": return 11.00m;
                case "Strawberry Shake": return 11.00m;
                case "Caramel Shake": return 11.00m;
                // Add all drinks here
                default: return 0;
            }
        }

        private string GetHotOrCold()
        {
            if (rbHot.Checked) return "Hot";
            if (rbCold.Checked) return "Cold";
            return "";
        }


        private void btnCart_Click(object sender, EventArgs e)
        {
            string drink = GetSelectedDrink();
            string menuID = GetSelectedDrinkID();
            int quantity = (int)numericUpDownDrink.Value;
            string hotCold = GetHotOrCold();

            if (string.IsNullOrEmpty(drink) || string.IsNullOrEmpty(menuID) || quantity <= 0 || string.IsNullOrEmpty(hotCold))
            {
                MessageBox.Show("Please select a drink, temperature, and quantity.");
                return;
            }

            decimal unitPrice = GetDrinkUnitPrice(drink);
            decimal totalPrice = unitPrice * quantity;

            string item = $"{quantity}x {hotCold} {drink}";
            listBoxDrinkCart.Items.Add(item);
            listBoxDrinkPrice.Items.Add($"RM{totalPrice:0.00}");

            var existing = CartData.CartItems.FirstOrDefault(x => x.MenuID == menuID && x.MenuName.StartsWith(hotCold));
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                CartData.CartItems.Add(new CartItem
                {
                    MenuID = menuID,
                    MenuName = $"{hotCold} {drink}",
                    Quantity = quantity,
                    Price = unitPrice
                });
            }
            UpdateTotalPrice();


        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            FormFood formfood = new FormFood(this.custID);
            this.Hide();
            formfood.ShowDialog(); // Wait until this form is closed
            this.Close();

        }

        private void rdbtnStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEspresso.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM6.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/espresso.png");
            }

        }


        private void rbAmericano_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmericano.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM7.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/americano.png");
            }
        }

        private void rbCappucino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCappucino.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM9.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/cappucino.png");
            }
        }

        private void rbLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLatte.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM9.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/latte.png");
            }
        }

        private void rbMocha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMocha.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM10.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/mocha.png");
            }
        }

        private void rbCM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCM.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM11.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/caramelmacchiato.png");

            }
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnglish.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM6.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/english-breakfast-tea.png");
            }
        }

        private void rbEarlGrey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEarlGrey.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM6.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/earl-grey-tea.png");
            }
        }

        private void rbChamomile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChamomile.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM7.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/chamomile-tea.png");
            }
        }

        private void rbMatcha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMatcha.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM10.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/matcha-latte.png");
            }
        }

        private void rbLemon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLemon.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM6.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/black-tea-lemonade.png");
            }
        }

        private void rbChai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChai.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM9.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/chai-latte.png");
            }
        }

        private void rbChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChocolate.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM9.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/hot-chocolate.png");
            }
        }

        private void rbChocShake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChocShake.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM11.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/chocolate-shake.png");
            }
        }

        private void rbVanillaShake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVanillaShake.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM11.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/vanilla-shake.png");
            }
        }

        private void rbStrawberryShake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStrawberryShake.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM11.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/strawberry-shake.png");
            }
        }

        private void rbCaramelShake_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCaramelShake.Checked)
            {
                listBoxPriceDrink.Items.Clear();
                listBoxPriceDrink.Items.Add("RM11.00");
                ptrbxDrink.Image = System.Drawing.Image.FromFile($"images/caramel-shake.png");
            }
        }



        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (var item in listBoxDrinkPrice.Items)
            {
                string priceText = item.ToString().Replace("RM", "");
                if (decimal.TryParse(priceText, out decimal price))
                {
                    total += price;
                }
            }

            listBoxTotalDrink.Items.Clear(); // Clear previous total
            listBoxTotalDrink.Items.Add($"RM{total:0.00}");
        }

        private void btnRemoveDrink_Click(object sender, EventArgs e)
        {
            int idx = listBoxDrinkCart.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Please select item to remove.");
                return;
            }

            // UI
            listBoxDrinkCart.Items.RemoveAt(idx);
            listBoxDrinkPrice.Items.RemoveAt(idx);

            // CartData
            CartData.CartItems.RemoveAt(CartData.CartItems.Count(x => x.MenuID != null) - CartData.CartItems.Count + idx);

            UpdateTotalPrice();
        }

    }
}
