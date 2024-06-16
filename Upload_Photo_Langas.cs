using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FotoKlubas
{
    public partial class Upload_Photo_Langas : Form
    {
        private Database database;
        private byte[] photoBytes;
        private string loggedInUsername;
        private string loggedInPassword;
        private int loggedInNarysId;
        private int loggedInKlubasId;
        public event EventHandler PhotoUploaded;

        public Upload_Photo_Langas()
        {
            InitializeComponent();

            // Replace with your actual connection string
            string connectionString = "server=localhost;database=fotoklubas3;uid=root";
            database = new Database(connectionString);

            // Get the logged-in Username and Password from the login form
            loggedInUsername = Prisijungimas.LoggedInUsername;
            loggedInPassword = Prisijungimas.LoggedInPassword;

            // Get the NarysID and KlubasID for the logged-in user
            loggedInNarysId = GetNarysId(loggedInUsername, loggedInPassword);
            loggedInKlubasId = GetKlubasId(loggedInUsername, loggedInPassword);
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFileName = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(selectedFileName);

                    // Store the original image bytes for saving into the database
                    using (MemoryStream ms = new MemoryStream())
                    {
                        selectedImage.Save(ms, selectedImage.RawFormat);
                        photoBytes = ms.ToArray();
                    }

                    // Display the image in the Photo panel
                    DisplayImage(selectedImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading photo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayImage(Image image)
        {
            // Scale the image to fit into the Panel without stretching
            Bitmap scaledImage = ScaleImage(image, Photo.Size);

            // Display the image in the Photo panel
            Photo.BackgroundImage = scaledImage;
            Photo.BackgroundImageLayout = ImageLayout.Center;

            // Enable the Save button after the image is loaded
            button_save.Enabled = true;
        }

        private Bitmap ScaleImage(Image image, Size size)
        {
            int newWidth, newHeight;
            double ratio = Math.Min((double)size.Width / image.Width, (double)size.Height / image.Height);

            newWidth = (int)(image.Width * ratio);
            newHeight = (int)(image.Height * ratio);

            Bitmap bitmap = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return bitmap;
        }

        private void button_save_Click_1(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (photoBytes == null || string.IsNullOrWhiteSpace(Pavadinimas.Text) || string.IsNullOrWhiteSpace(aprasymas.Text))
            {
                MessageBox.Show("Please upload a photo and fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Exit the method, do not proceed
            }

            // Insert the photo into the database
            string query = "INSERT INTO fotografija (Pavadinimas, Aprasymas, NarysID, KlubasID, FotoData) " +
                           "VALUES (@Pavadinimas, @Aprasymas, @NarysID, @KlubasID, @FotoData)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Pavadinimas", Pavadinimas.Text),
                new MySqlParameter("@Aprasymas", aprasymas.Text),
                new MySqlParameter("@NarysID", loggedInNarysId),
                new MySqlParameter("@KlubasID", loggedInKlubasId),
                new MySqlParameter("@FotoData", photoBytes)
            };

            try
            {
                int rowsAffected = database.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    OnPhotoUploaded();
                    MessageBox.Show("Photo uploaded and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Photo.BackgroundImage = null;
                    Pavadinimas.Text = "";
                    aprasymas.Text = "";
                    photoBytes = null;
                }
                else
                {
                    MessageBox.Show("Failed to upload photo. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to get NarysID based on Username and Password
        private int GetNarysId(string username, string password)
        {
            string query = "SELECT NarysID FROM Narys WHERE Username = @Username AND Slap = @Password";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };

            try
            {
                object result = database.ExecuteScalar(query, parameters);
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Indicates failure
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching NarysID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicates failure
            }
        }

        // Method to get KlubasID based on Username and Password
        private int GetKlubasId(string username, string password)
        {
            string query = "SELECT KlubasID FROM Narys WHERE NarysID = (SELECT NarysID FROM Narys WHERE Username = @Username AND Slap = @Password)";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Password", password)
            };

            try
            {
                object result = database.ExecuteScalar(query, parameters);
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Indicates failure
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching KlubasID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Indicates failure
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back to the login page?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Narys_Pagrindinis_Langas narys_langas = new Narys_Pagrindinis_Langas();
                narys_langas.ShowDialog();
                this.Close();
            }
        }

        protected virtual void OnPhotoUploaded()
        {
            // Check if there are any subscribers to the event
            PhotoUploaded?.Invoke(this, EventArgs.Empty);
        }
    }
}
