using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace ProjectCafe
{
    public partial class FormRegister : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\ProjectCafe\ProjectCafe\Cafe.mdf;Integrated Security=True";
        public FormRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHomepage form = new FormHomepage();
            form.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                labelUsernameStatus.Text = ""; // Clear label if empty
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE Username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            labelUsernameStatus.Text = "Username is already taken.";
                            labelUsernameStatus.ForeColor = Color.Red;
                        }
                        else
                        {
                            labelUsernameStatus.Text = "Username is available.";
                            labelUsernameStatus.ForeColor = Color.Green;
                        }
                    }
                }
                catch (Exception ex)
                {
                    labelUsernameStatus.Text = "Error: " + ex.Message;
                    labelUsernameStatus.ForeColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text) ||
            string.IsNullOrWhiteSpace(txtBoxPhone.Text) ||
            string.IsNullOrWhiteSpace(txtBoxAddress.Text) ||
            string.IsNullOrWhiteSpace(txtBoxUsername.Text) ||
            string.IsNullOrWhiteSpace(txtBoxPassword.Text) ||
            string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
            (!rbMale.Checked && !rbFemale.Checked))
                    {
                        MessageBox.Show("Please fill in all fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

            try
            {
                string name = txtBoxName.Text;
                string phone = txtBoxPhone.Text;
                string address = txtBoxAddress.Text;
                DateTime birthday = dtpBirthday.Value;
                string username = txtBoxUsername.Text;
                string password = txtBoxPassword.Text;
                string passwordHash = Password.HashPassword(password, out string salt);
                string email = txtBoxEmail.Text;

                string gender = "";
                foreach (Control c in grpGender.Controls)
                {
                    if (c is RadioButton rb && rb.Checked)
                    {
                        gender = rb.Text.Substring(0, 1);
                        break;
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if username exists
                    string checkQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE Username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists! Please choose another username.");
                            return; // Stop the insertion
                        }
                    }

                    // If username is unique, proceed to insert
                    string sql = @"INSERT INTO CUSTOMER (CustID, Name, Phone, Address, Birthday, Gender, Username, PasswordHash, Email, PasswordSalt)
                    VALUES (@custID, @name, @phone, @address, @birthday, @gender, @username, @passwordHash, @email, @passwordSalt)";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        Random rnd = new Random();
                        int custID = rnd.Next(0, 9999);

                        cmd.Parameters.AddWithValue("@custID", custID);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@passwordSalt", salt);
                        cmd.Parameters.AddWithValue("@email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer registered successfully!");
                            ClearForm();
                            FormHomepage formHome = new FormHomepage();
                            formHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtBoxName.Clear();
            txtBoxPhone.Clear();
            txtBoxAddress.Clear();
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxEmail.Clear();
            dtpBirthday.Value = DateTime.Now;
            foreach (Control c in grpGender.Controls)
            {
                if (c is RadioButton rb)
                    rb.Checked = false;
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string mail = txtBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(mail))
            {
                labelEmailStatus.Text = ""; // Clear label if empty
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", mail);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            labelEmailStatus.Text = "The email has already been registered.";
                            labelEmailStatus.ForeColor = Color.Red;
                        }

                    }
                }
                catch (Exception ex)
                {
                    labelEmailStatus.Text = "Error: " + ex.Message;
                    labelEmailStatus.ForeColor = Color.Red;
                }
            }
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = txtBoxPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone))
            {
                labelPhoneStatus.Text = ""; // Clear label if empty
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE Phone = @phone";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Phone", phone);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            labelPhoneStatus.Text = "The number phone has already been registered.";
                            labelPhoneStatus.ForeColor = Color.Red;
                        }

                    }
                }
                catch (Exception ex)
                {
                    labelPhoneStatus.Text = "Error: " + ex.Message;
                    labelPhoneStatus.ForeColor = Color.Red;
                }
            }
        }

        public static class Password
        {
            public static string HashPassword(string password, out string salt)
            {
                // Generate a cryptographic random salt
                byte[] saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }

                salt = Convert.ToBase64String(saltBytes);

                // Generate the hash using PBKDF2
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000)) // 10000 = iterations
                {
                    byte[] hash = pbkdf2.GetBytes(32); // 20 bytes = 160 bits
                    return Convert.ToBase64String(hash);
                }
            }

            public static bool VerifyPassword(string password, string storedHash, string storedSalt)
            {
                byte[] saltBytes = Convert.FromBase64String(storedSalt);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000))
                {
                    byte[] hash = pbkdf2.GetBytes(20);
                    return Convert.ToBase64String(hash) == storedHash;
                }
            }
        }

    }
}
