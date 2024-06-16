using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FotoKlubas
{
    public partial class Create_Account_Langas : Form
    {
        private Database database;
        public Create_Account_Langas()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=fotoklubas3;uid=root";
            database = new Database(connectionString);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(textBox_name.Text) ||
                string.IsNullOrWhiteSpace(textBox_lastname.Text) ||
                string.IsNullOrWhiteSpace(textBox_email.Text) ||
                string.IsNullOrWhiteSpace(textBox_tel.Text) ||
                string.IsNullOrWhiteSpace(textBox_adress.Text) ||
                string.IsNullOrWhiteSpace(textBox_username.Text) ||
                string.IsNullOrWhiteSpace(textBox_password.Text) ||
                string.IsNullOrWhiteSpace(comboBox_Mem.Text)
                )
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Exit the method, do not proceed
            }

            // Construct the query and parameters
            string query = "INSERT INTO Narys (Vardas, Pavarde, Elpas, TelNR, Naryste, PrisijungimoDAT, KlubasID, Slap, Username, Administratorius_AdministratoriusID) " +
                           "VALUES (@Name, @LastName, @Email, @Telephone, @Membership, @JoinDate, @Address, @Password, @Username, @adminID)";

            // First, find the KlubasID based on the provided address
            string klubasQuery = "SELECT KlubasID FROM Klubas WHERE Adresas = @Address";
            string adminQuery = "SELECT administratoriusID FROM administratorius ORDER BY RAND() LIMIT 1";

            MySqlParameter[] klubasParameters = new MySqlParameter[]
            {
                new MySqlParameter("@Address", textBox_adress.Text)
            };

            int klubasID = -1;
            int adminID = -1;

            try
            {
                object klubasIdResult = database.ExecuteScalar(klubasQuery, klubasParameters);

                if (klubasIdResult != null && klubasIdResult != DBNull.Value)
                {
                    klubasID = Convert.ToInt32(klubasIdResult);
                }
                else
                {
                    MessageBox.Show("Klubas with the provided address was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                object adminIdResult = database.ExecuteScalar(adminQuery, null);
                if (adminIdResult != null && adminIdResult != DBNull.Value)
                {
                    adminID = Convert.ToInt32(adminIdResult);
                }
                else
                {
                    MessageBox.Show("No administrator found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching KlubasID or AdministratoriusID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Name", textBox_name.Text),
                new MySqlParameter("@LastName", textBox_lastname.Text),
                new MySqlParameter("@Email", textBox_email.Text),
                new MySqlParameter("@Telephone", textBox_tel.Text),
                new MySqlParameter("@JoinDate", DateTime.Today),
                new MySqlParameter("@Address", klubasID),
                new MySqlParameter("@Username", textBox_username.Text),
                new MySqlParameter("@Password", textBox_password.Text),
                new MySqlParameter("@Membership", comboBox_Mem.Text),
                new MySqlParameter("@adminID", adminID)
            };

            try
            {
                // Execute the query
                int rowsAffected = database.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally, clear the text boxes after successful creation
                    textBox_name.Text = "";
                    textBox_lastname.Text = "";
                    textBox_email.Text = "";
                    textBox_tel.Text = "";
                    textBox_adress.Text = "";
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                    comboBox_Mem.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back to the login page?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Prisijungimas login_langas = new Prisijungimas();
                login_langas.ShowDialog();
                this.Close();
            }
        }


    }
}
