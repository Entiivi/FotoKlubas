using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace FotoKlubas
{
    public partial class Prisijungimas : Form
    {
        private Database dbHelper;

        // Store Username and Password statically
        public static string LoggedInUsername { get; private set; }
        public static string LoggedInPassword { get; private set; }

        public Prisijungimas()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=fotoklubas3;uid=root";
            dbHelper = new Database(connectionString);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_pass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Fill all the fields.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM Narys WHERE Username = @Username AND Slap = @Slap";
            MySqlParameter[] parameters = {
            new MySqlParameter("@Username", username),
            new MySqlParameter("@Slap", password)
        };

            DataTable result = dbHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                LoggedInUsername = username;
                LoggedInPassword = password;
                this.Hide();
                Narys_Pagrindinis_Langas mainForm = new Narys_Pagrindinis_Langas();
                mainForm.Show();
            }
            else
            {
                // User not found
                MessageBox.Show("Incorrect username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_createaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Account_Langas mainForm = new Create_Account_Langas();
            mainForm.Show();
        }
    }
}
 