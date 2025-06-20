using System;
using System.Windows.Forms;

namespace ProjectCafe
{
    public partial class FormThanks : Form
    {
        public FormThanks(int pickupNumber)
        {
            InitializeComponent();
            label1.Visible = true;
            listBoxPickup.Visible = true;

            listBoxPickup.Items.Clear();
            listBoxPickup.Items.Add($"{pickupNumber}");
        }

        public FormThanks()
        {
            InitializeComponent();
            label1.Visible = false;
            listBoxPickup.Visible = false;
        }

        private void listBoxPickup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Random rnd = new Random();
            int pickupNumber = rnd.Next(1000, 9999);

            listBoxPickup.Items.Clear(); // Clear previous entries
            listBoxPickup.Items.Add($"{pickupNumber}");

        }

    }
}
