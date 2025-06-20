using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;




namespace ProjectCafe
{
    public partial class FormHomepage : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\ProjectCafe\ProjectCafe\Cafe.mdf;Integrated Security=True";
        public FormHomepage()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister form = new FormRegister();
            form.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CustID, PasswordHash, PasswordSalt FROM CUSTOMER WHERE Username = @username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int custID = reader.GetInt32(0);
                            string storedHashBase64 = reader["PasswordHash"].ToString();
                            string storedSaltBase64 = reader["PasswordSalt"].ToString();


                            byte[] storedHash = Convert.FromBase64String(storedHashBase64);
                            byte[] storedSalt = Convert.FromBase64String(storedSaltBase64);
                            // Hash the entered password using the same salt
                            using (var pbkdf2 = new System.Security.Cryptography.Rfc2898DeriveBytes(password, storedSalt, 10000))
                            {
                                byte[] hashAttempt = pbkdf2.GetBytes(32);

                                // Compare hashAttempt to storedHash
                                bool passwordMatch = hashAttempt.SequenceEqual(storedHash);
                                if (passwordMatch)
                                {
                                    if (username.StartsWith("Admin", StringComparison.OrdinalIgnoreCase))
                                    {
                                        FormAdminHome adminForm = new FormAdminHome();
                                        this.Hide();
                                        adminForm.ShowDialog();
                                        this.Close();
                                        
                                        
                                    }
                                    else
                                    {
                                        FormDrink drinkForm = new FormDrink(custID);
                                        drinkForm.ShowDialog();
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
