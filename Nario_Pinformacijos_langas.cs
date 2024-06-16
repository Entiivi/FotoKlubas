using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FotoKlubas
{
    public partial class Nario_Pinformacijos_langas : Form
    {
        private string loggedInUsername;
        private string loggedInPassword;
        private Database dbHelper;
        public string narysID = "";

        public Nario_Pinformacijos_langas()
        {
            InitializeComponent();

            // Replace with your actual connection string
            string connectionString = "server=localhost;database=fotoklubas3;uid=root";
            dbHelper = new Database(connectionString);

            // Get the logged-in Username and Password from the login form
            loggedInUsername = Prisijungimas.LoggedInUsername;
            loggedInPassword = Prisijungimas.LoggedInPassword;

            // Fetch and display the information
            FetchAndDisplayNarysInformation(loggedInUsername, loggedInPassword);
        }

        private void FetchAndDisplayNarysInformation(string username, string password)
        {
            // Query to fetch information from Narys and Klubas tables with join
            string query = "SELECT Narys.NarysID, Narys.Vardas, Narys.Pavarde, Narys.Elpas, Narys.TelNR, Narys.Naryste, Narys.PrisijungimoDAT, Klubas.Adresas " +
                           "FROM Narys " +
                           "INNER JOIN Klubas ON Narys.KlubasID = Klubas.KlubasID " +
                           "WHERE Narys.Username = @Username AND Narys.Slap = @Password";

            MySqlParameter[] parameters = {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };

            try
            {
                DataTable result = dbHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];

                    // Populate labels with fetched information
                    textBox_name.Text = row["Vardas"].ToString();
                    textBox_lastname.Text = row["Pavarde"].ToString();
                    textBox_email.Text = row["Elpas"].ToString();
                    textBox_tel.Text = row["TelNR"].ToString();
                    textBox_tday.Text = Convert.ToDateTime(row["PrisijungimoDAT"]).ToString("yyyy-MM-dd");
                    textBox_adress.Text = row["Adresas"].ToString();
                    textBox_mem.Text = row["Naryste"].ToString();
                    // Store NarysID for later use
                    narysID = row["NarysID"].ToString();
                }
                else
                {
                    MessageBox.Show("No user found with the provided credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Close the form if no user found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form on error
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE Narys SET Vardas = @Vardas, Pavarde = @Pavarde, Elpas = @Elpas, TelNR = @TelNR, Naryste = @Naryste, PrisijungimoDAT = @PrisijungimoDAT " +
                                 "WHERE NarysID = @NarysID";

            MySqlParameter[] parameters = {
                new MySqlParameter("@Vardas", textBox_name.Text),
                new MySqlParameter("@Pavarde", textBox_lastname.Text),
                new MySqlParameter("@Elpas", textBox_email.Text),
                new MySqlParameter("@TelNR", textBox_tel.Text),
                new MySqlParameter("@Naryste", textBox_mem.Text),
                new MySqlParameter("@PrisijungimoDAT", Convert.ToDateTime(textBox_tday.Text)),
                new MySqlParameter("@Username", loggedInUsername),
                new MySqlParameter("@Password", loggedInPassword),
                new MySqlParameter("@NarysID", narysID),
            };

            try
            {
                int rowsAffected = dbHelper.ExecuteNonQuery(updateQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
